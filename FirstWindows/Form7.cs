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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace FirstWindows
{

    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtcategory.Clear();
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\Test Folder\Product Binary.txt", FileMode.Create, FileAccess.Write);
                prod.Name = txtName.Text;
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtcategory.Text;
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\Test Folder\Product Binary.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
               prod= (Product)binary.Deserialize(fs);
                txtName.Text = prod.Name;
                txtId.Text = prod.Id.ToString();
                txtPrice.Text = prod.Price.ToString();
                txtcategory.Text = prod.Category;
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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Category = txtcategory.Text;
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Product Xml.txt", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
                MessageBox.Show("done");
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\Test Folder\Product Xml.txt", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                txtName.Text = prod.Name;
                txtId.Text = prod.Id.ToString();
                txtPrice.Text = prod.Price.ToString();
                txtcategory.Text = prod.Category;
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

        private void BtnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Category = txtcategory.Text;
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Product soap.txt", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();               
                fs = new FileStream(@"D:\Test Folder\Product soap.txt", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
              prod=(Product)soap.Deserialize(fs);
                txtName.Text = prod.Name;
                txtId.Text = prod.Id.ToString();
                txtPrice.Text = prod.Price.ToString();
                txtcategory.Text = prod.Category;
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

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Category = txtcategory.Text;
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Product Json.txt", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\Test Folder\Product Json.txt", FileMode.Open, FileAccess.Read);
               prod= JsonSerializer.Deserialize<Product>(fs);
                txtName.Text = prod.Name;
                txtId.Text = prod.Id.ToString();
                txtPrice.Text = prod.Price.ToString();
                txtcategory.Text = prod.Category;
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
