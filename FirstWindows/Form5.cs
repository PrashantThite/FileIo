using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstWindows
{
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
               
                int rollno = Convert.ToInt32(txtRollNo.Text);
                int percent= Convert.ToInt32(txtPercent.Text);
                fs = new FileStream(@"D:\Test Folder\student Details.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(txtName.Text);
                bw.Write(txtStream.Text);
                bw.Write(rollno);
                bw.Write(percent);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Test Folder\student Details.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtName.Text=br.ReadString();
                txtStream.Text = br.ReadString();
                txtRollNo.Text = br.ReadInt32().ToString();
                txtPercent.Text = br.ReadInt32().ToString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPercent.Clear();
            txtRollNo.Clear();
            txtStream.Clear();
        }
    }
}
