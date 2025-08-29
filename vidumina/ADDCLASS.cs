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
    public partial class ADDCLASS : Form
    {
        public ADDCLASS()
        {
            InitializeComponent();
        }

        private void ADDCLASS_Load(object sender, EventArgs e)
        {

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAME.Clear();
            CLASS.Clear();
            FESS.Clear();
            PAYMENT.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True");
            con.Open();
            SqlCommand cmnd = new SqlCommand("INSERT INTO[dbo].[CLASS]([NAME],[CLASS],[FEES],[PAYMENT],[PASSWORD])VALUES('" + NAME.Text + "','" + CLASS.Text + "','" + FESS.Text + "','" + PAYMENT.Text +"','"+PASSWORD.Text+"')",con );

            
            con.Close();
            MessageBox.Show("CLASS DETAIL UPDATED");

            this.Hide();
            Form ADDCLASS = new ADDCLASS();
            ADDCLASS.Close();

            ADDCLASS myForm = new ADDCLASS();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
