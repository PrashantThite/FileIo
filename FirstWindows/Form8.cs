using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FirstWindows
{
    public partial class Form8 : Form
    {
        FileStream fs;
        public Form8()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtbname.Clear();
            txtId.Clear();
            txtPrice.Clear();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Author = txtAuthor.Text;
                book.Bname = txtbname.Text;
                book.Id = Convert.ToInt32(txtId.Text);
                book.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Book binary.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
               
                fs = new FileStream(@"D:\Test Folder\Book binary.txt", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book= (Book)binary.Deserialize(fs);
                txtbname.Text = book.Bname;
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                txtId.Text = book.Id.ToString();
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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Author = txtAuthor.Text;
                book.Bname = txtbname.Text;
                book.Id = Convert.ToInt32(txtId.Text);
                book.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Book soap.txt", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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
                Book book = new Book();

                fs = new FileStream(@"D:\Test Folder\Book soap.txt", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)  soap.Deserialize(fs);
                txtbname.Text = book.Bname;
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                txtId.Text = book.Id.ToString();
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
                Book book = new Book();
                book.Author = txtAuthor.Text;
                book.Bname = txtbname.Text;
                book.Id = Convert.ToInt32(txtId.Text);
                book.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Book xml.txt", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
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

        private void btnxmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();

                fs = new FileStream(@"D:\Test Folder\Book xml.txt", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                txtbname.Text = book.Bname;
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                txtId.Text = book.Id.ToString();
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
                Book book = new Book();
                book.Author = txtAuthor.Text;
                book.Bname = txtbname.Text;
                book.Id = Convert.ToInt32(txtId.Text);
                book.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Test Folder\Book Json.txt", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();

                fs = new FileStream(@"D:\Test Folder\Book Json.txt", FileMode.Open, FileAccess.Read);
             book=   JsonSerializer.Deserialize<Book>(fs);
                txtbname.Text = book.Bname;
                txtPrice.Text = book.Price.ToString();
                txtAuthor.Text = book.Author;
                txtId.Text = book.Id.ToString();
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
