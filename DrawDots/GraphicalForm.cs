﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawDots.Models;
using Newtonsoft.Json;
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
            updateComboBox();
            comboBoxGroups.SelectedIndex = 0;
            labelPointThicknessValue.Text = Groups[comboBoxGroups.SelectedIndex].groupThickness.ToString();
            trackBarPointThickness.Value = Groups[comboBoxGroups.SelectedIndex].groupThickness;
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
                gl.PointSize(group.groupThickness);

                gl.Begin(OpenGL.GL_POINTS);

                if (group == comboBoxGroups.SelectedItem)
                {
                    Color groupColor = Groups[comboBoxGroups.SelectedIndex].groupColor;
                    gl.Color(groupColor.R, groupColor.G, groupColor.B);
                }
                else
                {
                    gl.Color(1f, 1f, 1f);
                }
                foreach (MyPoint point in group.elements)
                {
                    gl.Vertex(point.x, point.y);
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
    }
}