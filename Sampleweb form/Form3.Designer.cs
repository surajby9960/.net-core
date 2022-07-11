
namespace Sampleweb_form
{
    partial class Form3
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btn_Json_read = new System.Windows.Forms.Button();
            this.btn_Soap_read = new System.Windows.Forms.Button();
            this.btn_Xml_read = new System.Windows.Forms.Button();
            this.btn_Binary_read = new System.Windows.Forms.Button();
            this.btn_Json_write = new System.Windows.Forms.Button();
            this.btn_Soap_write = new System.Windows.Forms.Button();
            this.btn_Xml_Write = new System.Windows.Forms.Button();
            this.btn_Binary_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(159, 78);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(159, 25);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(184, 22);
            this.txtProductId.TabIndex = 5;
            // 
            // btn_Json_read
            // 
            this.btn_Json_read.Location = new System.Drawing.Point(184, 391);
            this.btn_Json_read.Name = "btn_Json_read";
            this.btn_Json_read.Size = new System.Drawing.Size(97, 23);
            this.btn_Json_read.TabIndex = 6;
            this.btn_Json_read.Text = "JSON Read";
            this.btn_Json_read.UseVisualStyleBackColor = true;
            // 
            // btn_Soap_read
            // 
            this.btn_Soap_read.Location = new System.Drawing.Point(184, 350);
            this.btn_Soap_read.Name = "btn_Soap_read";
            this.btn_Soap_read.Size = new System.Drawing.Size(97, 23);
            this.btn_Soap_read.TabIndex = 7;
            this.btn_Soap_read.Text = "SOAP Read";
            this.btn_Soap_read.UseVisualStyleBackColor = true;
            this.btn_Soap_read.Click += new System.EventHandler(this.btn_Soap_read_Click);
            // 
            // btn_Xml_read
            // 
            this.btn_Xml_read.Location = new System.Drawing.Point(184, 307);
            this.btn_Xml_read.Name = "btn_Xml_read";
            this.btn_Xml_read.Size = new System.Drawing.Size(97, 23);
            this.btn_Xml_read.TabIndex = 8;
            this.btn_Xml_read.Text = "XML Read";
            this.btn_Xml_read.UseVisualStyleBackColor = true;
            this.btn_Xml_read.Click += new System.EventHandler(this.btn_Xml_read_Click);
            // 
            // btn_Binary_read
            // 
            this.btn_Binary_read.Location = new System.Drawing.Point(184, 249);
            this.btn_Binary_read.Name = "btn_Binary_read";
            this.btn_Binary_read.Size = new System.Drawing.Size(97, 23);
            this.btn_Binary_read.TabIndex = 9;
            this.btn_Binary_read.Text = "Binary Read";
            this.btn_Binary_read.UseVisualStyleBackColor = true;
            this.btn_Binary_read.Click += new System.EventHandler(this.btn_Binary_read_Click);
            // 
            // btn_Json_write
            // 
            this.btn_Json_write.Location = new System.Drawing.Point(42, 391);
            this.btn_Json_write.Name = "btn_Json_write";
            this.btn_Json_write.Size = new System.Drawing.Size(101, 23);
            this.btn_Json_write.TabIndex = 10;
            this.btn_Json_write.Text = "JSON Write";
            this.btn_Json_write.UseVisualStyleBackColor = true;
            // 
            // btn_Soap_write
            // 
            this.btn_Soap_write.Location = new System.Drawing.Point(42, 350);
            this.btn_Soap_write.Name = "btn_Soap_write";
            this.btn_Soap_write.Size = new System.Drawing.Size(101, 23);
            this.btn_Soap_write.TabIndex = 11;
            this.btn_Soap_write.Text = "SOAP Write";
            this.btn_Soap_write.UseVisualStyleBackColor = true;
            this.btn_Soap_write.Click += new System.EventHandler(this.btn_Soap_write_Click);
            // 
            // btn_Xml_Write
            // 
            this.btn_Xml_Write.Location = new System.Drawing.Point(42, 298);
            this.btn_Xml_Write.Name = "btn_Xml_Write";
            this.btn_Xml_Write.Size = new System.Drawing.Size(104, 23);
            this.btn_Xml_Write.TabIndex = 12;
            this.btn_Xml_Write.Text = "XML Write";
            this.btn_Xml_Write.UseVisualStyleBackColor = true;
            this.btn_Xml_Write.Click += new System.EventHandler(this.btn_Xml_Write_Click);
            // 
            // btn_Binary_Write
            // 
            this.btn_Binary_Write.Location = new System.Drawing.Point(42, 249);
            this.btn_Binary_Write.Name = "btn_Binary_Write";
            this.btn_Binary_Write.Size = new System.Drawing.Size(104, 23);
            this.btn_Binary_Write.TabIndex = 13;
            this.btn_Binary_Write.Text = "Binary Write";
            this.btn_Binary_Write.UseVisualStyleBackColor = true;
            this.btn_Binary_Write.Click += new System.EventHandler(this.btn_Binary_Write_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Binary_Write);
            this.Controls.Add(this.btn_Xml_Write);
            this.Controls.Add(this.btn_Soap_write);
            this.Controls.Add(this.btn_Json_write);
            this.Controls.Add(this.btn_Binary_read);
            this.Controls.Add(this.btn_Xml_read);
            this.Controls.Add(this.btn_Soap_read);
            this.Controls.Add(this.btn_Json_read);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Serilization Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btn_Json_read;
        private System.Windows.Forms.Button btn_Soap_read;
        private System.Windows.Forms.Button btn_Xml_read;
        private System.Windows.Forms.Button btn_Binary_read;
        private System.Windows.Forms.Button btn_Json_write;
        private System.Windows.Forms.Button btn_Soap_write;
        private System.Windows.Forms.Button btn_Xml_Write;
        private System.Windows.Forms.Button btn_Binary_Write;
    }
}