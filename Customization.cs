using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zombie_gampeplay_work.Properties;


namespace Zombie_gampeplay_work
{
    public partial class Customization : Form
    {


        Image customUpImage = Properties.Resources.Up5;
        Image customLeftImage = Properties.Resources.Shooter_1;
        Image customDownImage = Properties.Resources.Down5;
        Image customRightImage = Properties.Resources.Right5;
        Image customupimage2 = Properties.Resources.up6;
        Image customdownimage2 = Properties.Resources.down6;
        Image customrightimage2 = Properties.Resources.right6;
        Image customleftimage2 = Properties.Resources.left6;





        public Customization()
        {
            InitializeComponent();


        }


        public void ChooseCustomPlayer(object sender, EventArgs e)
        {
            Properties.Settings.Default.Customization = true;
            Properties.Settings.Default.Customization2 = false;
            Properties.Settings.Default.Customization3 = false;
            Properties.Settings.Default.Save();
            this.Close();

        }

        public Image GetImageUp()
        {
            return customUpImage;
        }
        public Image GetImageleft()
        {
            return customLeftImage;
        }
        public Image GetImagedown()
        {
            return customDownImage;
        }
        public Image GetImageright()
        {
            return customRightImage;
        }
        public Image GetImageUp2()
        {
            return customupimage2;
        }
        public Image GetImageDown2()
        {
            return customdownimage2;
        }
        public Image GetImageRight2()
        {
            return customrightimage2;
        }
        public Image GetImageLeft2()
        {
            return customleftimage2;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ZombieSeige work = new ZombieSeige();
            work.Show();
        }



        private void Form4_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Customization2 = true;
            Properties.Settings.Default.Customization = false;
            Properties.Settings.Default.Customization3 = false;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings settings = new Settings();
            settings.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Customization = false;
            Properties.Settings.Default.Customization2 = false;
            Properties.Settings.Default.Customization3 = true;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
