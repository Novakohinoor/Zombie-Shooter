using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

namespace Zombie_gampeplay_work
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }
        public static bool loggedin { get; set; } = false;
        public static String Username { get; set; }
        private static String Password { get; set; }

        SqlConnection connection = new SqlConnection(@"Data Source=RAGHAV\SQLEXPRESS;Initial Catalog=Zombie shooter;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            if (loggedin)
            {
                panel1.BringToFront();
                panel1.Visible = true;
                label6.Text = Username;
            }
            else
            {
                panel1.SendToBack();
                panel1.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Username = textBox1.Text;
            Password = textBox2.Text;
            try
            {
                connection.Open();
                String query = "SELECT * FROM User_Login WHERE Player_Name = '" + textBox1.Text + "' AND Player_passWord = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Username = textBox1.Text;
                    Password = textBox2.Text;
                    loggedin = true;
                    MessageBox.Show("Account logged in sucessfully");
                    ZombieSeige form = new ZombieSeige();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount account = new CreateAccount();
            account.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loggedin = false;
            panel1.SendToBack();
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loggedin = false;
            panel1.SendToBack();
            panel1.Visible = false;
            try
            {
                connection.Open();
                String query = "DELETE FROM User_Login WHERE Player_Name = '" + Username + "'";
                String qeury2 = "DELETE FROM LeaderBoards WHERE PlayerName = '" + Username + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlCommand cmd2 = new SqlCommand(qeury2, connection);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Sucessfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
