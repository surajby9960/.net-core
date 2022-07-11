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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sampleweb_form
{
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Binary_Write_Click(object sender, EventArgs e)
        {
            //code for binary write serlialization
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtProductId.Text);
                prod.Name = txtProductName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Product", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, prod);
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btn_Binary_read_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                prod = (Product)bf.Deserialize(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_Xml_Write_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtProductId.Text);
                prod.Name = txtProductName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Productxml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, prod);
                MessageBox.Show("xml file created");
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);


            }
            finally
            {
                fs.Close();
            }


        }

        private void btn_Xml_read_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\productxml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                prod = (Product)xs.Deserialize(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
            }
            catch(SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_Soap_write_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtProductId.Text);
                prod.Name = txtProductName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"D:\Productsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, prod);
                MessageBox.Show("soap file created");
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);


            }
            finally
            {
                fs.Close();
            }
        }

        private void btn_Soap_read_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\productsoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                prod = (Product)sf.Deserialize(fs);
                txtProductId.Text = prod.Id.ToString();
                txtProductName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                fs.Close();
            }


        }
    }
}
