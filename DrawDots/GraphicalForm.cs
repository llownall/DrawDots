using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawDots.Models;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace DrawDots
{
    public partial class GraphicalForm : Form
    {
        internal List<Group> Groups { get; set; }

        public GraphicalForm(List<Group> groups)
        {
            Groups = groups;
            InitializeComponent();
            debugInfo.Text += $"{Groups.Count} groups received";
            updateComboBox();
            comboBoxGroups.SelectedIndex = 0;
            labelPointThicknessValue.Text = Groups[comboBoxGroups.SelectedIndex].groupThickness.ToString();
            trackBarPointThickness.Value = Groups[comboBoxGroups.SelectedIndex].groupThickness;
        }

        private void openGLWindow_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = this.openGLWindow.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(SharpGL.Enumerations.MatrixMode.Projection);
            gl.LoadIdentity();
            gl.Ortho2D(0, openGLWindow.Size.Width, 0, openGLWindow.Size.Height);
            gl.MatrixMode(SharpGL.Enumerations.MatrixMode.Modelview);  //в примере это было, но и без неё работает...

            foreach (Group group in Groups)
            {
                gl.PointSize(group.groupThickness);

                gl.Begin(OpenGL.GL_POINTS);

                if (group == comboBoxGroups.SelectedItem)
                {
                    gl.Color(0, 1f, 0);
                }
                else
                {
                    gl.Color(1f, 1f, 1f);
                }
                foreach (MyPoint point in group.elements)
                {
                    gl.Vertex(point.Position.X, point.Position.Y);
                }
                gl.End();
            }
        }

        private void GraphicalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private void openGLWindow_MouseClick(object sender, MouseEventArgs e)
        {
            MyPoint newPoint = new MyPoint(e.X, openGLWindow.Size.Height - e.Y);

            debugInfo.Text = $"Debug Info:\n" +
                $"sizez {openGLWindow.Size.Width} {openGLWindow.Size.Height}\n" +
                $"x = {e.X}\n" +
                $"y = {openGLWindow.Size.Height - e.Y}";

            if (checkBoxDeletePointMode.Checked)
            {
                foreach (MyPoint point in Groups[comboBoxGroups.SelectedIndex].elements)
                {
                    if (point.isPointed(newPoint, Groups[comboBoxGroups.SelectedIndex].groupThickness / 2))
                    {
                        Groups[comboBoxGroups.SelectedIndex].elements.Remove(point);
                        break;
                    }
                }
            }
            else
            {
                Groups[comboBoxGroups.SelectedIndex].elements.Add(newPoint);
            }
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
        }

        private void buttonNewGroup_Click(object sender, EventArgs e)
        {
            Groups.Add(new Group($"Группа {Groups.Last().getNumberOfGroup() + 1}"));
            updateComboBox();
            comboBoxGroups.SelectedIndex = Groups.Count - 1;
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
            comboBoxGroups.SelectedIndex = 0;
        }
    }
}
