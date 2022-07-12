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
using System.Text.Json;

namespace Sampleweb_form
{
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_binary_write_Click(object sender, EventArgs e)
        {
            try
            {


                Course c = new Course();
                c.Id = Convert.ToInt32(txt_course_id.Text);
                c.Name = txt_course_name.Text;
                c.Fees = Convert.ToInt32(txt_fees.Text);
                fs = new FileStream(@"D:\course binary", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
                MessageBox.Show("course binary is created");
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }



        }

        private void btn_binary_read_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                fs = new FileStream(@"D:\course binary", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                c = (Course)bf.Deserialize(fs);
                txt_course_id.Text = c.Id.ToString();
                txt_course_name.Text = c.Name;
                txt_fees.Text = c.Fees.ToString();
              
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btn_xml_write_Click(object sender, EventArgs e)
        {

            try
            {


                Course c = new Course();
                c.Id = Convert.ToInt32(txt_course_id.Text);
                c.Name = txt_course_name.Text;
                c.Fees = Convert.ToInt32(txt_fees.Text);
                fs = new FileStream(@"D:\course xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                xs.Serialize(fs, c);
                MessageBox.Show("course xml created");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_xml_read_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                fs = new FileStream(@"D:\course xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                c = (Course)xs.Deserialize(fs);
                txt_course_id.Text = c.Id.ToString();
                txt_course_name.Text = c.Name;
                txt_fees.Text = c.Fees.ToString();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_soap_write_Click(object sender, EventArgs e)
        {

            try
            {


                Course c = new Course();
                c.Id = Convert.ToInt32(txt_course_id.Text);
                c.Name = txt_course_name.Text;
                c.Fees = Convert.ToInt32(txt_fees.Text);
                fs = new FileStream(@"D:\course soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, c);
                MessageBox.Show("course soap created");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_soap_read_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                fs = new FileStream(@"D:\course soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                c = (Course)sf.Deserialize(fs);
                txt_course_id.Text = c.Id.ToString();
                txt_course_name.Text = c.Name;
                txt_fees.Text = c.Fees.ToString();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_json_write_Click(object sender, EventArgs e)
        {

            try
            {


                Course c = new Course();
                c.Id = Convert.ToInt32(txt_course_id.Text);
                c.Name = txt_course_name.Text;
                c.Fees = Convert.ToInt32(txt_fees.Text);
                fs = new FileStream(@"D:\course soap", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, c);
                
                MessageBox.Show("course json created");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btn_jason_read_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                fs = new FileStream(@"D:\course soap", FileMode.Open, FileAccess.Read);
                JsonSerializer.Deserialize<Course>(fs);
                txt_course_id.Text = c.Id.ToString();
                txt_course_name.Text = c.Name;
                txt_fees.Text = c.Fees.ToString();
                }
            catch (SystemException ex)
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
