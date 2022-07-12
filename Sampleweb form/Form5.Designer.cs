
namespace Sampleweb_form
{
    partial class Form5
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
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.txt_course_id = new System.Windows.Forms.TextBox();
            this.btn_binary_write = new System.Windows.Forms.Button();
            this.btn_binary_read = new System.Windows.Forms.Button();
            this.btn_xml_write = new System.Windows.Forms.Button();
            this.btn_xml_read = new System.Windows.Forms.Button();
            this.btn_soap_write = new System.Windows.Forms.Button();
            this.btn_soap_read = new System.Windows.Forms.Button();
            this.btn_json_write = new System.Windows.Forms.Button();
            this.btn_jason_read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fees";
            // 
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(175, 125);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(134, 22);
            this.txt_fees.TabIndex = 3;
            // 
            // txt_course_name
            // 
            this.txt_course_name.Location = new System.Drawing.Point(175, 73);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(134, 22);
            this.txt_course_name.TabIndex = 4;
            // 
            // txt_course_id
            // 
            this.txt_course_id.Location = new System.Drawing.Point(175, 30);
            this.txt_course_id.Name = "txt_course_id";
            this.txt_course_id.Size = new System.Drawing.Size(134, 22);
            this.txt_course_id.TabIndex = 5;
            // 
            // btn_binary_write
            // 
            this.btn_binary_write.Location = new System.Drawing.Point(62, 223);
            this.btn_binary_write.Name = "btn_binary_write";
            this.btn_binary_write.Size = new System.Drawing.Size(109, 23);
            this.btn_binary_write.TabIndex = 6;
            this.btn_binary_write.Text = "Binary Write";
            this.btn_binary_write.UseVisualStyleBackColor = true;
            this.btn_binary_write.Click += new System.EventHandler(this.btn_binary_write_Click);
            // 
            // btn_binary_read
            // 
            this.btn_binary_read.Location = new System.Drawing.Point(200, 223);
            this.btn_binary_read.Name = "btn_binary_read";
            this.btn_binary_read.Size = new System.Drawing.Size(109, 23);
            this.btn_binary_read.TabIndex = 7;
            this.btn_binary_read.Text = "Binary Read";
            this.btn_binary_read.UseVisualStyleBackColor = true;
            this.btn_binary_read.Click += new System.EventHandler(this.btn_binary_read_Click);
            // 
            // btn_xml_write
            // 
            this.btn_xml_write.Location = new System.Drawing.Point(62, 276);
            this.btn_xml_write.Name = "btn_xml_write";
            this.btn_xml_write.Size = new System.Drawing.Size(109, 23);
            this.btn_xml_write.TabIndex = 8;
            this.btn_xml_write.Text = "XML Write";
            this.btn_xml_write.UseVisualStyleBackColor = true;
            this.btn_xml_write.Click += new System.EventHandler(this.btn_xml_write_Click);
            // 
            // btn_xml_read
            // 
            this.btn_xml_read.Location = new System.Drawing.Point(200, 276);
            this.btn_xml_read.Name = "btn_xml_read";
            this.btn_xml_read.Size = new System.Drawing.Size(109, 23);
            this.btn_xml_read.TabIndex = 9;
            this.btn_xml_read.Text = "XML Read";
            this.btn_xml_read.UseVisualStyleBackColor = true;
            this.btn_xml_read.Click += new System.EventHandler(this.btn_xml_read_Click);
            // 
            // btn_soap_write
            // 
            this.btn_soap_write.Location = new System.Drawing.Point(62, 333);
            this.btn_soap_write.Name = "btn_soap_write";
            this.btn_soap_write.Size = new System.Drawing.Size(109, 23);
            this.btn_soap_write.TabIndex = 10;
            this.btn_soap_write.Text = "SOAP Write";
            this.btn_soap_write.UseVisualStyleBackColor = true;
            this.btn_soap_write.Click += new System.EventHandler(this.btn_soap_write_Click);
            // 
            // btn_soap_read
            // 
            this.btn_soap_read.Location = new System.Drawing.Point(200, 333);
            this.btn_soap_read.Name = "btn_soap_read";
            this.btn_soap_read.Size = new System.Drawing.Size(109, 23);
            this.btn_soap_read.TabIndex = 11;
            this.btn_soap_read.Text = "SOAP Read";
            this.btn_soap_read.UseVisualStyleBackColor = true;
            this.btn_soap_read.Click += new System.EventHandler(this.btn_soap_read_Click);
            // 
            // btn_json_write
            // 
            this.btn_json_write.Location = new System.Drawing.Point(62, 385);
            this.btn_json_write.Name = "btn_json_write";
            this.btn_json_write.Size = new System.Drawing.Size(109, 23);
            this.btn_json_write.TabIndex = 12;
            this.btn_json_write.Text = "JSON Write";
            this.btn_json_write.UseVisualStyleBackColor = true;
            this.btn_json_write.Click += new System.EventHandler(this.btn_json_write_Click);
            // 
            // btn_jason_read
            // 
            this.btn_jason_read.Location = new System.Drawing.Point(200, 385);
            this.btn_jason_read.Name = "btn_jason_read";
            this.btn_jason_read.Size = new System.Drawing.Size(109, 23);
            this.btn_jason_read.TabIndex = 13;
            this.btn_jason_read.Text = "JSON Reader";
            this.btn_jason_read.UseVisualStyleBackColor = true;
            this.btn_jason_read.Click += new System.EventHandler(this.btn_jason_read_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_jason_read);
            this.Controls.Add(this.btn_json_write);
            this.Controls.Add(this.btn_soap_read);
            this.Controls.Add(this.btn_soap_write);
            this.Controls.Add(this.btn_xml_read);
            this.Controls.Add(this.btn_xml_write);
            this.Controls.Add(this.btn_binary_read);
            this.Controls.Add(this.btn_binary_write);
            this.Controls.Add(this.txt_course_id);
            this.Controls.Add(this.txt_course_name);
            this.Controls.Add(this.txt_fees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.TextBox txt_course_name;
        private System.Windows.Forms.TextBox txt_course_id;
        private System.Windows.Forms.Button btn_binary_write;
        private System.Windows.Forms.Button btn_binary_read;
        private System.Windows.Forms.Button btn_xml_write;
        private System.Windows.Forms.Button btn_xml_read;
        private System.Windows.Forms.Button btn_soap_write;
        private System.Windows.Forms.Button btn_soap_read;
        private System.Windows.Forms.Button btn_json_write;
        private System.Windows.Forms.Button btn_jason_read;
    }
}