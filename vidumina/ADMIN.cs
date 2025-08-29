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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From [dbo].[ADMIN] where[ID]=@ID and [PASS]=@PASS", con);
            cmd.Parameters.AddWithValue("@ID", ID.Text);
            cmd.Parameters.AddWithValue("@PASS", PASS.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login sucsessfulli");
                ADDCLASS myForm = new ADDCLASS();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("incorrect name or password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID.Clear();
            PASS.Clear();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
