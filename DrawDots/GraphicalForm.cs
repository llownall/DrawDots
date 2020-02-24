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
        internal int currentGroupIndex;

        public GraphicalForm(List<Group> groups)
        {
            Groups = groups;

            Groups.Add(new Group());
            currentGroupIndex = 0;

            InitializeComponent();
            label1.Text += $"{Groups.Count} groups received";
            thicknessLabel.Text = Groups[currentGroupIndex].groupThickness.ToString();
            trackBar1.Value = Groups[currentGroupIndex].groupThickness;
        }

        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            // Создаем экземпляр
            OpenGL gl = this.openGLControl1.OpenGL;

            // Очистка экрана и буфера глубин
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Сбрасываем модельно-видовую матрицу
            gl.LoadIdentity();

            // Двигаем перо вглубь экрана
            gl.Translate(0.0f, 0.0f, -5.0f);
            gl.PointSize(Groups[currentGroupIndex].groupThickness);

            gl.Begin(OpenGL.GL_POINTS);

            // Указываем цвет вершин
            gl.Color(1f, 1f, 1f);

            foreach (MyPoint point in Groups[currentGroupIndex].elements)
            {
                gl.Vertex(
                    GetOGLCoordinate(point.Position.X, openGLControl1.Size.Width),
                    GetOGLCoordinate(point.Position.Y, openGLControl1.Size.Height)
                    );
            }

            // Завершаем работу
            gl.End();
        }

        private void GraphicalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private double GetOGLCoordinate(int x, int size)
        {
            return -1f * size / 170 / 2 + 1f * x / 170;
        }

        private void openGLControl1_MouseClick(object sender, MouseEventArgs e)
        {
            MyPoint newPoint = new MyPoint(e.X, openGLControl1.Size.Height - e.Y);

            string openGLx = GetOGLCoordinate(newPoint.Position.X, openGLControl1.Size.Width).ToString();
            string openGLy = GetOGLCoordinate(newPoint.Position.Y, openGLControl1.Size.Height).ToString();

            label1.Text = $"Debug Info:\n" +
                $"sizez {openGLControl1.Size.Width} {openGLControl1.Size.Height}\n" +
                $"x = {newPoint.Position.X}\n" +
                $"y = {newPoint.Position.Y}\n" +
                $"openGLx = {openGLx}\n" +
                $"openGLy = {openGLy}";

            Groups[currentGroupIndex].Add(newPoint);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            thicknessLabel.Text = trackBar1.Value.ToString();
            Groups[currentGroupIndex].setGroupThickness(trackBarValue);
        }

    }
}
