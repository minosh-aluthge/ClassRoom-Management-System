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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GPV2538\SQLEXPRESS;Initial catalog=VIDUMINA;Integrated Security=True");
            con.Open();
            SqlCommand cmnd = new SqlCommand("INSERT INTO[dbo].[REG]([NAME],[PASSWORD],[DOB],[GENDER],[ADDRESS],[CONTACTNO],[SCHOOL],[MEDIUM])VALUES('" + NAME.Text + "','" + PASSWORD.Text + "','" + DOB.Text + "','" + GENDER.Text + "','" + ADDRESS.Text + "','" + CONTACTNO.Text + "','" + SCHOOL.Text + "','" + MEDIUM.Text + "')", con);
     
            cmnd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("your application has been submitted successfully");

            this.Hide();
            Form REGISTER = new REGISTER();
            REGISTER.Close();

            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAME.Clear();
            PASSWORD.Clear();
            ADDRESS.Clear();
            CONTACTNO.Clear();
            SCHOOL.Clear();

        }

        private void CONTACTNO_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CONTACTNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void REGISTER_Load(object sender, EventArgs e)
        {

        }
    }
}
