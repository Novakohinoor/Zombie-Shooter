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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void StartGame(object sender, EventArgs e)
        {
            ZombieSeige work = new ZombieSeige();
            work.Show();

        }
        private void ExitGame(object sender, EventArgs e)
        {
            this.Close();


        }

        private void SettingsGame(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 difficulty = new Form2();
            difficulty.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeaderBoards leaderboard = new LeaderBoards();
            leaderboard.Show();
        }
    }
}
