
namespace Sampleweb_form
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp_id = new System.Windows.Forms.TextBox();
            this.txt_emp_Name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.btn_binary_read = new System.Windows.Forms.Button();
            this.btn_xml_read = new System.Windows.Forms.Button();
            this.btn_soap_read = new System.Windows.Forms.Button();
            this.btn_json_read = new System.Windows.Forms.Button();
            this.btn_binary_write = new System.Windows.Forms.Button();
            this.btn_xml_write = new System.Windows.Forms.Button();
            this.btn_soap_write = new System.Windows.Forms.Button();
            this.btn_json_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Location = new System.Drawing.Point(132, 30);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(273, 22);
            this.txt_emp_id.TabIndex = 3;
            // 
            // txt_emp_Name
            // 
            this.txt_emp_Name.Location = new System.Drawing.Point(132, 76);
            this.txt_emp_Name.Name = "txt_emp_Name";
            this.txt_emp_Name.Size = new System.Drawing.Size(273, 22);
            this.txt_emp_Name.TabIndex = 4;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(132, 120);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(273, 22);
            this.txt_salary.TabIndex = 5;
            // 
            // btn_binary_read
            // 
            this.btn_binary_read.Location = new System.Drawing.Point(634, 258);
            this.btn_binary_read.Name = "btn_binary_read";
            this.btn_binary_read.Size = new System.Drawing.Size(120, 23);
            this.btn_binary_read.TabIndex = 6;
            this.btn_binary_read.Text = "Binary_Read";
            this.btn_binary_read.UseVisualStyleBackColor = true;
            this.btn_binary_read.Click += new System.EventHandler(this.btn_binary_read_Click);
            // 
            // btn_xml_read
            // 
            this.btn_xml_read.Location = new System.Drawing.Point(634, 308);
            this.btn_xml_read.Name = "btn_xml_read";
            this.btn_xml_read.Size = new System.Drawing.Size(120, 23);
            this.btn_xml_read.TabIndex = 7;
            this.btn_xml_read.Text = "XML Read";
            this.btn_xml_read.UseVisualStyleBackColor = true;
            this.btn_xml_read.Click += new System.EventHandler(this.btn_xml_read_Click);
            // 
            // btn_soap_read
            // 
            this.btn_soap_read.Location = new System.Drawing.Point(634, 358);
            this.btn_soap_read.Name = "btn_soap_read";
            this.btn_soap_read.Size = new System.Drawing.Size(120, 23);
            this.btn_soap_read.TabIndex = 8;
            this.btn_soap_read.Text = "SOAP Read";
            this.btn_soap_read.UseVisualStyleBackColor = true;
            this.btn_soap_read.Click += new System.EventHandler(this.btn_soap_read_Click);
            // 
            // btn_json_read
            // 
            this.btn_json_read.Location = new System.Drawing.Point(634, 400);
            this.btn_json_read.Name = "btn_json_read";
            this.btn_json_read.Size = new System.Drawing.Size(120, 23);
            this.btn_json_read.TabIndex = 9;
            this.btn_json_read.Text = "JSON Read";
            this.btn_json_read.UseVisualStyleBackColor = true;
            this.btn_json_read.Click += new System.EventHandler(this.btn_json_read_Click);
            // 
            // btn_binary_write
            // 
            this.btn_binary_write.Location = new System.Drawing.Point(482, 258);
            this.btn_binary_write.Name = "btn_binary_write";
            this.btn_binary_write.Size = new System.Drawing.Size(120, 23);
            this.btn_binary_write.TabIndex = 10;
            this.btn_binary_write.Text = "Binary Write";
            this.btn_binary_write.UseVisualStyleBackColor = true;
            this.btn_binary_write.Click += new System.EventHandler(this.btn_binary_write_Click);
            // 
            // btn_xml_write
            // 
            this.btn_xml_write.Location = new System.Drawing.Point(482, 308);
            this.btn_xml_write.Name = "btn_xml_write";
            this.btn_xml_write.Size = new System.Drawing.Size(120, 23);
            this.btn_xml_write.TabIndex = 11;
            this.btn_xml_write.Text = "XML Write";
            this.btn_xml_write.UseVisualStyleBackColor = true;
            this.btn_xml_write.Click += new System.EventHandler(this.btn_xml_write_Click);
            // 
            // btn_soap_write
            // 
            this.btn_soap_write.Location = new System.Drawing.Point(482, 358);
            this.btn_soap_write.Name = "btn_soap_write";
            this.btn_soap_write.Size = new System.Drawing.Size(120, 23);
            this.btn_soap_write.TabIndex = 12;
            this.btn_soap_write.Text = "SOAP Write";
            this.btn_soap_write.UseVisualStyleBackColor = true;
            this.btn_soap_write.Click += new System.EventHandler(this.btn_soap_write_Click);
            // 
            // btn_json_write
            // 
            this.btn_json_write.Location = new System.Drawing.Point(482, 400);
            this.btn_json_write.Name = "btn_json_write";
            this.btn_json_write.Size = new System.Drawing.Size(120, 23);
            this.btn_json_write.TabIndex = 13;
            this.btn_json_write.Text = "JSON Write";
            this.btn_json_write.UseVisualStyleBackColor = true;
            this.btn_json_write.Click += new System.EventHandler(this.btn_json_write_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_json_write);
            this.Controls.Add(this.btn_soap_write);
            this.Controls.Add(this.btn_xml_write);
            this.Controls.Add(this.btn_binary_write);
            this.Controls.Add(this.btn_json_read);
            this.Controls.Add(this.btn_soap_read);
            this.Controls.Add(this.btn_xml_read);
            this.Controls.Add(this.btn_binary_read);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_emp_Name);
            this.Controls.Add(this.txt_emp_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Employee Detils";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emp_id;
        private System.Windows.Forms.TextBox txt_emp_Name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Button btn_binary_read;
        private System.Windows.Forms.Button btn_xml_read;
        private System.Windows.Forms.Button btn_soap_read;
        private System.Windows.Forms.Button btn_json_read;
        private System.Windows.Forms.Button btn_binary_write;
        private System.Windows.Forms.Button btn_xml_write;
        private System.Windows.Forms.Button btn_soap_write;
        private System.Windows.Forms.Button btn_json_write;
    }
}