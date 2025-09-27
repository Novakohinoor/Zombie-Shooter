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

namespace Zombie_gampeplay_work
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=RAGHAV\SQLEXPRESS;Initial Catalog=Zombie shooter;Integrated Security=True");
        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username;
            username = textBox1.Text;

            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                {
                    if (textBox2.Text.Equals(textBox3.Text))
                    {
                        connection.Open();
                        String Query = "SELECT * FROM User_Login WHERE Player_Name = '" + username + "'";
                        SqlDataAdapter da = new SqlDataAdapter(Query, connection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            String query = "INSERT INTO User_Login VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                            String query2 = "INSERT INTO LeaderBoards VALUES ('" + textBox1.Text + "', 0)";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            SqlCommand cmd2 = new SqlCommand(query2, connection);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            int rowsAffected2 = cmd2.ExecuteNonQuery();
                            if (rowsAffected > 0 && rowsAffected2 > 0)
                            {
                                MessageBox.Show("Account created and logged in successfully!");
                                User_Login.loggedin = true;
                                User_Login.Username = textBox1.Text;
                                button2.Visible = true;
                                button1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while creating the account.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Already Exists");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a username and a password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
