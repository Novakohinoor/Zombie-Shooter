using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_gampeplay_work
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                this.Close();
            }
        }

        private void CustomizationGame(object sender, EventArgs e)
        {
            Customization custom = new Customization();
            custom.Show();
            this.Close();
        }

        private void BackMenu(object sender, EventArgs e)
        {
            this.Close();


        }

        private void GameInstructions(object sender, EventArgs e)
        {
            this.Close();
            GameInstructions help = new GameInstructions(); 
            help.Show();    

        }
    }
}
