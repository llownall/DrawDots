using DrawDots.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawDots
{
    public partial class MainForm : Form
    {
        internal List<Group> Groups { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNewPicture_Click(object sender, EventArgs e)
        {
            Hide();
            new GraphicalForm(new List<Group> { new Group("Группа 1") }).Show(this);
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON Data|*.json";
            openFileDialog1.Title = "Открыть данные групп точек";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    Groups = JsonConvert.DeserializeObject<List<Group>>(sr.ReadToEnd());
                }

                Hide();
                new GraphicalForm(Groups).Show(this);
            }
        }
    }
}
