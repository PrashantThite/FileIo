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
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)

        {
            try
            {
                int salary = Convert.ToInt32(txtsalary.Text);
                int Id = Convert.ToInt32(txtId.Text);
                fs = new FileStream(@"D:\Test Folder\Employee Details.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(txtname.Text);
                bw.Write(Id);
                bw.Write(txtdepartment.Text);
                bw.Write(txtdesignation.Text);
                bw.Write(salary);
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
               
                fs = new FileStream(@"D:\Test Folder\Employee Details.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtname.Text=br.ReadString();
                txtId.Text = br.ReadInt32().ToString();
                txtdepartment.Text = br.ReadString();
                txtdesignation.Text = br.ReadString();
                txtsalary.Text = br.ReadInt32().ToString();
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
            txtsalary.Clear();
            txtname.Clear();
            txtId.Clear();
            txtdesignation.Clear();
            txtdepartment.Clear();
        }
    }
}
