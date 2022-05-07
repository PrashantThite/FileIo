
namespace FirstWindows
{
    partial class Form8
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
            this.Lid = new System.Windows.Forms.Label();
            this.Lauthorname = new System.Windows.Forms.Label();
            this.Lprice = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnxmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lid
            // 
            this.Lid.AutoSize = true;
            this.Lid.Location = new System.Drawing.Point(252, 265);
            this.Lid.Name = "Lid";
            this.Lid.Size = new System.Drawing.Size(18, 13);
            this.Lid.TabIndex = 0;
            this.Lid.Text = "ID";
            // 
            // Lauthorname
            // 
            this.Lauthorname.AutoSize = true;
            this.Lauthorname.Location = new System.Drawing.Point(252, 209);
            this.Lauthorname.Name = "Lauthorname";
            this.Lauthorname.Size = new System.Drawing.Size(69, 13);
            this.Lauthorname.TabIndex = 1;
            this.Lauthorname.Text = "Author Name";
            // 
            // Lprice
            // 
            this.Lprice.AutoSize = true;
            this.Lprice.Location = new System.Drawing.Point(252, 159);
            this.Lprice.Name = "Lprice";
            this.Lprice.Size = new System.Drawing.Size(31, 13);
            this.Lprice.TabIndex = 2;
            this.Lprice.Text = "Price";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(252, 100);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(63, 13);
            this.Lname.TabIndex = 3;
            this.Lname.Text = "Book Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(353, 258);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(353, 202);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(135, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(353, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(353, 93);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(135, 20);
            this.txtbname.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(288, 325);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(606, 369);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(75, 23);
            this.btnJsonRead.TabIndex = 9;
            this.btnJsonRead.Text = "Json Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(606, 340);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJsonWrite.TabIndex = 10;
            this.btnJsonWrite.Text = "Json write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnxmlRead
            // 
            this.btnxmlRead.Location = new System.Drawing.Point(606, 273);
            this.btnxmlRead.Name = "btnxmlRead";
            this.btnxmlRead.Size = new System.Drawing.Size(75, 23);
            this.btnxmlRead.TabIndex = 11;
            this.btnxmlRead.Text = "Xml Read";
            this.btnxmlRead.UseVisualStyleBackColor = true;
            this.btnxmlRead.Click += new System.EventHandler(this.btnxmlRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(606, 244);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 12;
            this.btnXmlWrite.Text = "Xml Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(606, 178);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRead.TabIndex = 13;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(606, 149);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 14;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(606, 29);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 15;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(606, 58);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 16;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnxmlRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lprice);
            this.Controls.Add(this.Lauthorname);
            this.Controls.Add(this.Lid);
            this.Name = "Form8";
            this.Text = "Book Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lid;
        private System.Windows.Forms.Label Lauthorname;
        private System.Windows.Forms.Label Lprice;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnxmlRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
    }
}