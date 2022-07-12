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


namespace Sampleweb_form
{
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            InitializeComponent();
        }

       private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_binary_write_Click(object sender, EventArgs e)
        {
            try
            {
                Emplyoee emp = new Emplyoee();
                emp.Id = Convert.ToInt32(txt_emp_id.Text);
                emp.Name = txt_emp_Name.Text;
                emp.Salary = Convert.ToInt32(txt_salary.Text);
                fs = new FileStream(@"D:\Emplyoee binary", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emp);
                MessageBox.Show("Create and Write Succesfully");
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
                Emplyoee emp = new Emplyoee();
                fs = new FileStream(@"D:\Emplyoee binary", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                emp = (Emplyoee)bf.Deserialize(fs);
                txt_emp_id.Text = emp.Id.ToString();
                txt_emp_Name.Text = emp.Name;
                txt_salary.Text = emp.Salary.ToString();
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
                Emplyoee emp = new Emplyoee();
                emp.Id = Convert.ToInt32(txt_emp_id.Text);
                emp.Name = txt_emp_Name.Text;
                emp.Salary = Convert.ToInt32(txt_salary.Text);
                fs = new FileStream(@"D:\emplyoee xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Emplyoee));
                xs.Serialize(fs, emp);
                MessageBox.Show("xml file write succesfully");
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

        private void btn_xml_read_Click(object sender, EventArgs e)
        {
            try
            {
                Emplyoee emp = new Emplyoee();
                fs = new FileStream(@"D:\emplyoee xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Emplyoee));
                emp = (Emplyoee)xs.Deserialize(fs);
                txt_emp_id.Text = emp.Id.ToString();
                txt_emp_Name.Text = emp.Name;
                txt_salary.Text = emp.Salary.ToString();
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

        private void btn_soap_write_Click(object sender, EventArgs e)
        {
            try
            {
                Emplyoee emp = new Emplyoee();
                emp.Id = Convert.ToInt32(txt_emp_id.Text);
                emp.Name = txt_emp_Name.Text;
                emp.Salary = Convert.ToInt32(txt_salary.Text);
                fs = new FileStream(@"D:\emplyoee soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, emp);
                MessageBox.Show("soap file write succesfully");
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
            Emplyoee emp = new Emplyoee();
            fs = new FileStream(@"D:\emplyoee xml", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            emp = (Emplyoee)sf.Deserialize(fs);
            txt_emp_id.Text = emp.Id.ToString();
            txt_emp_Name.Text = emp.Name;
            txt_salary.Text = emp.Salary.ToString();
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

        private void btn_json_write_Click(object sender, EventArgs e)
        {
            try
            {
                Emplyoee emp = new Emplyoee();
                emp.Id = Convert.ToInt32(txt_emp_id.Text);
                emp.Name = txt_emp_Name.Text;
                emp.Salary = Convert.ToInt32(txt_salary.Text);
                fs = new FileStream(@"D:\emplyoee json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, emp);
                MessageBox.Show("json file write succesfully");
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

        private void btn_json_read_Click(object sender, EventArgs e)
        {
            try
            {
                Emplyoee emp = new Emplyoee();
                fs = new FileStream(@"D:\emplyoee json", FileMode.Open, FileAccess.Read);
                JsonSerializer.Deserialize<Emplyoee>(fs);
                txt_emp_id.Text = emp.Id.ToString();
                txt_emp_Name.Text = emp.Name;
                txt_salary.Text = emp.Salary.ToString();
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
    }
    
}
