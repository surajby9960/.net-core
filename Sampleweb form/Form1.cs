using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sampleweb_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtPssword.Text=="123")
            {
                MessageBox.Show("success");

            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPssword.Clear();
        }
    }
}
