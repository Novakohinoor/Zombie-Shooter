using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;
using Zombie_gampeplay_work.Properties;
using System.Data.SqlClient;


namespace Zombie_gampeplay_work
{

    public partial class ZombieSeige : Form
    {

        bool isLeft, isRight, isDown, isUp, gameOver;
        bool isCustomized1 = Properties.Settings.Default.Customization;
        bool isCustomized2 = Properties.Settings.Default.Customization2;
        bool isCustomized3 = Properties.Settings.Default.Customization3;
        Customization pic = new Customization();
        string direction = "Up";
        int playerHealth = 100;
        int speed = 20;
        int Bulletspeed = 40;
        int ammo = 20;
        int kills;
        int zombieSpeed = 2;
        bool isHealthDropPresent = false;
        private Bullet shootBullet;
        int gamelevel = Properties.Settings.Default.Level;
        SqlConnection connection = new SqlConnection(@"Data Source=RAGHAV\SQLEXPRESS;Initial Catalog=Zombie shooter;Integrated Security=True");
        Random RaNnUM = new Random();
        List<PictureBox> zombiesList = new List<PictureBox>();
        List<Bullet> bulletspresentinform = new List<Bullet>();

        private Vector GetMovementVector()
        {
            float Left = 0;
            float Top = 0;

            if (isLeft == true)
            {
                Left -= speed;
            }
            if (isRight == true)
            {
                Left += speed;
            }
            if (isUp == true)
            {
                Top -= speed;
            }
            if (isDown == true)
            {
                Top += speed;
            }

            return new Vector(Left, Top);
        }
        private Vector playerPosition = new Vector(507, 299);






        public ZombieSeige()  //constructor
        {
            InitializeComponent();
            shootBullet = new Bullet(this);
            RestartGame();


        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void MainTimerEvent(object sender, EventArgs e)

        {

            playerPosition += GetMovementVector();


            playerPosition.X = Math.Max(0, Math.Min(playerPosition.X, this.ClientSize.Width - Player.Width));
            playerPosition.Y = Math.Max(55, Math.Min(playerPosition.Y, this.ClientSize.Height - Player.Height));



            RestartMessage.Visible = false;
            ExitGame.Visible = false;
            label2.Visible = false;
            label4.Visible = false;

            if (playerHealth > 40)
            {
                isHealthDropPresent = false;
            }


            if (playerHealth > 1)
            {
                if (playerHealth < 40 && !isHealthDropPresent)
                {
                    DropHealth();
                }
                else
                {
                    HealthBar.Value = playerHealth;
                }



            }

            else
            {
                gameOver = true;
                Player.Image = Properties.Resources.dead;
                GameTimer.Enabled = false;
                RestartMessage.Visible = true;
                ExitGame.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                try
                {
                    connection.Open();
                    if (User_Login.loggedin)
                    {
                        String query = "UPDATE LeaderBoards SET Kills = " + kills + " WHERE PlayerName = '" + User_Login.Username + "' AND Kills < " + kills;
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Leaderboards kill count is not updated, error: " + ex.StackTrace);
                }
                finally
                {
                    connection.Close();
                }

            }
            txtAmmo.Text = "Ammo: " + ammo;
            txtKills.Text = "Kills: " + kills;

            Player.Left = (int)playerPosition.X; //cast as player.left and player.top are int values of picturebox player so the picturebox values of left and top are assinged to player position so player position is the picturebox
            Player.Top = (int)playerPosition.Y;

            void AmmoPickup(Control pictureBox)
            {
                if (Player.Bounds.IntersectsWith(pictureBox.Bounds))
                {
                    this.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    ammo += 5;
                }
            }

            void HealthPickup(Control pictureBox)
            {
                if (pictureBox.Bounds.IntersectsWith(Player.Bounds))
                {
                    this.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    playerHealth += 60;
                }
            }

            void ZombieInteraction(Control pictureBox)
            {
                if (Player.Bounds.IntersectsWith(pictureBox.Bounds))
                    playerHealth -= 1;


            }

            foreach (Control picturebox in this.Controls)
            {
                if (picturebox is PictureBox) //if there is a picturebox(like bullet, zombie or health) in the picturebox control
                {
                    if (picturebox.Tag as string == "ammo")
                    {
                        AmmoPickup(picturebox);
                    }
                    else if (picturebox.Tag as string == "health")
                    {
                        HealthPickup(picturebox);
                    }
                    else if (picturebox.Tag as string == "Zombie")
                    {
                        ZombieInteraction(picturebox);

                        if (picturebox.Left > playerPosition.X)
                        {
                            picturebox.Left -= zombieSpeed;
                            ((PictureBox)picturebox).Image = Properties.Resources.Zleft;
                        }
                        if (picturebox.Left < playerPosition.X)
                        {
                            picturebox.Left += zombieSpeed;
                            ((PictureBox)picturebox).Image = Properties.Resources.Zright;
                        }
                        if (picturebox.Top > playerPosition.Y)
                        {
                            picturebox.Top -= zombieSpeed;
                            ((PictureBox)picturebox).Image = Properties.Resources.Zup;
                        }
                        if (picturebox.Top < playerPosition.Y)
                        {
                            picturebox.Top += zombieSpeed;
                            ((PictureBox)picturebox).Image = Properties.Resources.Zdown;
                        }
                    }
                }



                foreach (Control bullet in this.Controls) //we need both bullet and zombie to de disposed to create a new foreach loop
                {
                    if (bullet is PictureBox && picturebox is PictureBox)
                    {
                        if (bullet.Tag as string == "bullet" && picturebox.Tag as string == "Zombie")
                        {
                            if (bullet.Bounds.IntersectsWith(picturebox.Bounds))
                            {
                                this.Controls.Remove(picturebox);
                                ((PictureBox)picturebox).Dispose();
                                this.Controls.Remove(bullet);
                                ((PictureBox)bullet).Dispose();
                                zombiesList.Remove(((PictureBox)picturebox));
                                CreateZombies();
                                kills++;
                            }
                        }
                    }

                }
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {


            if (gameOver == true)
            {
                return;
            }
            if (GameTimer.Enabled == false)
            {
                return;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                isLeft = true;
                direction = "Left";

                if (isCustomized1 == true)
                {
                    Player.Image = pic.GetImageleft();
                }
                else if (isCustomized2 == true)
                {
                    Player.Image = Properties.Resources.left;
                }
                else if (isCustomized3 == true)
                {
                    Player.Image = pic.GetImageLeft2();
                }

            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                isRight = true;
                direction = "Right";



                if (isCustomized1 == true)
                {
                    Player.Image = pic.GetImageright();
                }
                else if (isCustomized2 == true)
                {
                    Player.Image = Properties.Resources.right;
                }
                else if (isCustomized3 == true)
                {
                    Player.Image = pic.GetImageRight2();
                }





            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                isUp = true;
                direction = "Up";


                if (isCustomized1 == true)
                {
                    Player.Image = pic.GetImageUp();
                }
                else if (isCustomized2 == true)
                {
                    Player.Image = Properties.Resources.up;
                }
                else if (isCustomized3 == true)
                {
                    Player.Image = pic.GetImageUp2();
                }

            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                isDown = true;
                direction = "Down";


                if (isCustomized1 == true)
                {
                    Player.Image = pic.GetImagedown();
                }
                else if (isCustomized2 == true)
                {
                    Player.Image = Properties.Resources.down;
                }
                else if (isCustomized3 == true)
                {
                    Player.Image = pic.GetImageDown2();
                }


            }
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                isLeft = false;


            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                isRight = false;

            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                isUp = false;

            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                isDown = false;

            }
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false && GameTimer.Enabled == true)
            {
                ammo--;
                ShootBullet(direction);
                if (ammo == 3)
                {
                    DropAmmo();
                }
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();

            }
            if (e.KeyCode == Keys.E && gameOver == true)
            {
                this.Close();
            }
        }


        public void ShootBullet(string direction)
        {
            Vector bulletStartPosition = new Vector(playerPosition.X + (Player.Width / 2), playerPosition.Y + (Player.Height / 2)); //bullet comes from the middle of the player
            shootBullet = new Bullet(this);
            shootBullet.MakeBullet(bulletStartPosition, GetBulletDirectionVector(direction));
            bulletspresentinform.Add(shootBullet);
        }

        private void CreateZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "Zombie";
            zombie.Image = Properties.Resources.Zdown;
            zombie.Left = RaNnUM.Next(0, 900);
            zombie.Top = RaNnUM.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            Player.BringToFront();
        }
        private void DropAmmo()
        {
            PictureBox ammonution = new PictureBox();
            ammonution.Image = Properties.Resources.ammo_Image;
            ammonution.SizeMode = PictureBoxSizeMode.AutoSize;
            ammonution.Left = RaNnUM.Next(10, this.ClientSize.Width - ammonution.Width);
            ammonution.Top = RaNnUM.Next(60, this.ClientSize.Height - ammonution.Height);
            ammonution.Tag = "ammo";
            this.Controls.Add(ammonution);

        }
        private void DropHealth()

        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.health_image;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = RaNnUM.Next(10, this.ClientSize.Width - health.Width);
            health.Top = RaNnUM.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);



            isHealthDropPresent = true;
        }

        private void RestartGame()
        {
            if (isCustomized1 == true)
            {
                Player.Image = pic.GetImageUp();
            }
            else if (isCustomized2 == true)
            {
                Player.Image = Properties.Resources.up;
            }
            else if (isCustomized3 == true)
            {
                Player.Image = pic.GetImageUp2();
            }
            foreach (PictureBox zombie in zombiesList)
            {
                this.Controls.Remove(zombie);                  //removing picturebox of zombie(dont need to specify tag as this is in zombie list which only contains picturebox of zombies)
            }

            zombiesList.Clear(); //removing zombies from zombielist so when the game restarts the new zombies can generate again
            foreach (Control health in this.Controls)
            {
                if (health is PictureBox)
                {
                    if (health.Tag as string == "health")
                    {
                        this.Controls.Remove(health);
                        ((PictureBox)health).Dispose();
                    }
                }
            }
            foreach (Control ammo in this.Controls)
            {
                if (ammo is PictureBox)
                {
                    if (ammo.Tag as string == "ammo")
                    {
                        this.Controls.Remove(ammo);
                        ((PictureBox)ammo).Dispose();
                    }
                }
            }

            for (int zombie = 0; zombie < gamelevel; zombie++)
            {
                CreateZombies();                                  //generate zombies based on the selected game difficulty
            }


            isUp = false;
            isDown = false;
            isLeft = false;
            isRight = false;
            gameOver = false;
            label2.Visible = false;
            label4.Visible = false;

            playerHealth = 100;
            kills = 0;
            ammo = 20;
            Start_Timer.Start();
            Player.BringToFront();
            direction = "Up";
            RestartMessage.Visible = false;
            ExitGame.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            playerPosition = new Vector(507, 299);


        }
        private Vector GetBulletDirectionVector(string direction)
        {
            float deltaX = 0;
            float deltaY = 0;

            switch (direction)
            {
                case "Left":
                    deltaX = -Bulletspeed;
                    break;
                case "Right":
                    deltaX = Bulletspeed;
                    break;
                case "Up":
                    deltaY = -Bulletspeed;
                    break;
                case "Down":
                    deltaY = Bulletspeed;
                    break;
            }

            return new Vector(deltaX, deltaY); //Return the inital positon of the bullet based on the player direction and when bullet is shot(e.keycode space)
        }

        private void Player_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PauseButton(object sender, EventArgs e)
        {

            if (GameTimer.Enabled)
            {
                GameTimer.Enabled = false; //pause
                label1.Text = "Resume";
                label2.Visible = true;
                label4.Visible = true;

                shootBullet.Pause();
            }
            else
            {
                label2.Visible = false;
                label4.Visible = false;

                GameTimer.Enabled = true; //resume
                label1.Text = "Pause";
                shootBullet.Resume();
            }
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {

        }

        private void HealthBar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings settings = new Settings();
            settings.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtAmmo_Click(object sender, EventArgs e)
        {

        }

        private void Start_Timer_Tick(object sender, EventArgs e)
        {
            label5.Visible = true;
            label1.Visible = false;
            if (label5.Text != "Game Start!")
            {

                GameTimer.Enabled = false;
                int count = Convert.ToInt32(label5.Text);
                if (count > 0)
                {
                    count--;
                    label5.Text = count.ToString();
                }
                else if (count == 0)
                {
                    label5.Text = "Game Start!";
                }
            }
            else
            {
                label5.Text = "4";
                label5.Visible = false;
                label1.Visible = true;
                GameTimer.Enabled = true;

                Start_Timer.Stop();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}