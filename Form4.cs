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
    public partial class LeaderBoards : Form
    {
        public LeaderBoards()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=RAGHAV\SQLEXPRESS;Initial Catalog=Zombie shooter;Integrated Security=True");
        private void LeaderBoards_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String query = "SELECT * FROM LeaderBoards ORDER BY Kills DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("There is no users to render the leaderboards");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry the leaderboard table could not be loaded");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
