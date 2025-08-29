using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidumina
{
    public partial class CONTACT_US : Form
    {
        public CONTACT_US()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            HOME myForm = new HOME();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
