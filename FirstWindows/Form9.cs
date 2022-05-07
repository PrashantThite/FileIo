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
    public partial class Form9 : Form
    {
        FileStream fs;
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtstartdate.Text = dateTimePicker1.Text;
        }
             

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtEndDate.Text = dateTimePicker2.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtBatchId.Clear();
            txtBatchName.Clear();
            txtEndDate.Clear();
            txtLocation.Clear();
            txtstartdate.Clear();
            txtTrainer.Clear();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Test Folder\Batch Details.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(Convert.ToInt32(txtBatchId.Text));
                br.Write(txtBatchName.Text);
                br.Write(txtstartdate.Text);
                br.Write(txtEndDate.Text);
                br.Write(txtLocation.Text);
                br.Write(txtTrainer.Text);
                br.Close();
                MessageBox.Show("Done");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Test Folder\Batch Details.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtBatchId.Text = br.ReadInt32().ToString();
                txtBatchName.Text = br.ReadString();
                txtstartdate.Text = br.ReadString();
                txtEndDate.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                txtTrainer.Text = br.ReadString();
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
    }
}
