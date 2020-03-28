using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DrawDots.Models;
using Newtonsoft.Json;
using SharpGL;

namespace DrawDots
{
    public partial class GraphicalForm : Form
    {
        internal List<Group> Groups { get; set; }

        public GraphicalForm(List<Group> groups)
        {
            Groups = groups;
            InitializeComponent();
            updateComboBox();
            comboBoxGroups.SelectedIndex = 0;
            labelPointThicknessValue.Text = Groups[comboBoxGroups.SelectedIndex].groupThickness.ToString();
            trackBarPointThickness.Value = Groups[comboBoxGroups.SelectedIndex].groupThickness;
            handleDeleteDotButtonEnable();
        }


        private void openGLWindow_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = this.openGLWindow.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Enable(OpenGL.GL_POINT_SMOOTH);
            gl.MatrixMode(SharpGL.Enumerations.MatrixMode.Projection);
            gl.LoadIdentity();
            gl.Ortho2D(0, openGLWindow.Size.Width, 0, openGLWindow.Size.Height);

            foreach (Group group in Groups)
            {
                if (group.elements.Count > 0)
                {
                    gl.PointSize(group.groupThickness);
                    gl.Begin(OpenGL.GL_POINTS);

                    gl.Color(group.groupColor.R, group.groupColor.G, group.groupColor.B);
                    gl.Vertex(
                            group.elements[0].x + group.transformation.xTransition,
                            group.elements[0].y + group.transformation.yTransition
                            );

                    if (group == comboBoxGroups.SelectedItem)
                    {
                        double k = DateTime.Now.Millisecond / 700 == 0 ? 1 : 0;
                        gl.Color(group.groupColor.R * k, group.groupColor.G * k, group.groupColor.B * k);
                    }
                    else
                    {
                        gl.Color(group.groupColor.R, group.groupColor.G, group.groupColor.B);
                    }

                    foreach (MyPoint point in group.rotatedElements())
                    {
                        gl.Vertex(
                            point.x + group.transformation.xTransition,
                            point.y + group.transformation.yTransition
                            );
                    }

                    gl.End();
                }
            }
        }

        private void GraphicalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private void openGLWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (trackBarRotation.Value != 0)
            {
                DialogResult result = MessageBox.Show(
                    "Добавлять или удалять точки можно только при нулевом угле поворота. Сбросить угол поворота?",
                    "Внимание",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                if (result == DialogResult.Yes)
                {
                    trackBarRotation.Value = 0;
                    Groups[comboBoxGroups.SelectedIndex].setRotationAngle(trackBarRotation.Value);
                }
                TopMost = true;
            }
            else
            {
                MyPoint newPoint = new MyPoint(
                e.X - Groups[comboBoxGroups.SelectedIndex].transformation.xTransition,
                openGLWindow.Size.Height - e.Y - Groups[comboBoxGroups.SelectedIndex].transformation.yTransition
                );

                if (checkBoxDeletePointMode.Checked)
                {
                    foreach (MyPoint point in Groups[comboBoxGroups.SelectedIndex].elements)
                    {
                        if (point.isPointed(newPoint, Groups[comboBoxGroups.SelectedIndex].groupThickness / 2))
                        {
                            Groups[comboBoxGroups.SelectedIndex].elements.Remove(point);
                            pointsGridView.Rows.Clear();
                            foreach (MyPoint groupPoint in Groups[comboBoxGroups.SelectedIndex].elements)
                            {
                                pointsGridView.Rows.Add(groupPoint.x, groupPoint.y);
                            }
                            break;
                        }
                    }
                }
                else
                {
                    Groups[comboBoxGroups.SelectedIndex].elements.Add(newPoint);
                    pointsGridView.Rows.Add(newPoint.x, newPoint.y);
                }
            }
            handleDeleteDotButtonEnable();
        }

        private void trackBarPointThickness_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBarPointThickness.Value;
            labelPointThicknessValue.Text = trackBarPointThickness.Value.ToString();
            Groups[comboBoxGroups.SelectedIndex].setGroupThickness(trackBarValue);
        }

        private void updateComboBox()
        {
            comboBoxGroups.Items.Clear();
            comboBoxGroups.Items.AddRange(Groups.ToArray());
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPointThicknessValue.Text = Groups[comboBoxGroups.SelectedIndex].groupThickness.ToString();
            trackBarPointThickness.Value = Groups[comboBoxGroups.SelectedIndex].groupThickness;
            pointsGridView.Rows.Clear();
            foreach (MyPoint groupPoint in Groups[comboBoxGroups.SelectedIndex].elements)
            {
                pointsGridView.Rows.Add(groupPoint.x, groupPoint.y);
            }
            trackBarRotation.Value = Groups[comboBoxGroups.SelectedIndex].transformation.rotationAngle;
        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            Groups.Add(new Group($"Группа {Groups.Last().getNumberOfGroup() + 1}"));
            updateComboBox();
            comboBoxGroups.SelectedIndex = Groups.Count - 1;
            handleDeleteDotButtonEnable();
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            if (Groups.Count > 1)
            {
                Groups.RemoveAt(comboBoxGroups.SelectedIndex);
            }
            else
            {
                Groups = new List<Group> { new Group("Группа 1") };
            }
            updateComboBox();
            handleDeleteDotButtonEnable();
            comboBoxGroups.SelectedIndex = 0;
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON Data|*.json";
            saveFileDialog1.Title = "Сохранить группы точек";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(JsonConvert.SerializeObject(Groups));
                }
            }
        }

        private void pointsGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].elements.RemoveAt(e.Row.Index);
            handleDeleteDotButtonEnable();
        }
        private void chooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = Groups[comboBoxGroups.SelectedIndex].groupColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                Groups[comboBoxGroups.SelectedIndex].setGroupColor(MyDialog.Color);
        }

        private void openGLWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "w":
                    Groups[comboBoxGroups.SelectedIndex].move(y: 1);
                    break;
                case "s":
                    Groups[comboBoxGroups.SelectedIndex].move(y: -1);
                    break;
                case "a":
                    Groups[comboBoxGroups.SelectedIndex].move(x: -1);
                    break;
                case "d":
                    Groups[comboBoxGroups.SelectedIndex].move(x: 1);
                    break;
                default:
                    return;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].move(y: 1);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].move(y: -1);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].move(x: -1);
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].move(x: 1);
        }

        private void deleteDotInTableButton_Click(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].elements.RemoveAt(pointsGridView.CurrentRow.Index);
            pointsGridView.Rows.Clear();
            foreach (MyPoint groupPoint in Groups[comboBoxGroups.SelectedIndex].elements)
            {
                pointsGridView.Rows.Add(groupPoint.x, groupPoint.y);
            }
            handleDeleteDotButtonEnable();
        }

        private void handleDeleteDotButtonEnable()
        {
            deleteDotInTableButton.Enabled = !(Groups[comboBoxGroups.SelectedIndex].elements.Count == 0);
        }
        
        private void trackBarRotation_Scroll(object sender, EventArgs e)
        {
            Groups[comboBoxGroups.SelectedIndex].setRotationAngle(trackBarRotation.Value);
        }
    }
}
