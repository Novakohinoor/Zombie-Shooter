using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_gampeplay_work
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Level = 1;
            Properties.Settings.Default.Save();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Level = 3;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Level = 5;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
