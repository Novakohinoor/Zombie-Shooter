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
    public partial class GameInstructions : Form
    {
        public GameInstructions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings settings = new Settings();
            settings.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ZombieSeige work = new ZombieSeige();
            work.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GameInstructions_Load(object sender, EventArgs e)
        {

        }
    }
}
