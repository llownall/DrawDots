using DrawDots.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new GraphicalForm(new List<Group> { new Group("Группа 1") }).Show(this);
        }
    }
}
