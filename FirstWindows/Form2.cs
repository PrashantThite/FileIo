using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name={txtname.Text},\n EmailId={txtemail.Text},\n Contact= {txtcontactno.Text},\n Address={txtaddr.Text}");
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaddr.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtcontactno.Clear();
        }
    }
}
