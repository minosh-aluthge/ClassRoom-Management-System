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

namespace vidumina
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From [dbo].[CLASS] where[NAME]=@NAME and [PASSWORD]=@PASSWORD", con);
            cmd.Parameters.AddWithValue("@NAME", NAME.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD.Text);
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("incorrect name or password");
            }
        }


        private void NAME_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}

