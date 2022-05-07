
namespace FirstWindows
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
            this.Ldid = new System.Windows.Forms.Label();
            this.Ldname = new System.Windows.Forms.Label();
            this.Llocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btnwritefile = new System.Windows.Forms.Button();
            this.btnreadfile = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btnWriteBinary = new System.Windows.Forms.Button();
            this.btnReadBinary = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ldid
            // 
            this.Ldid.AutoSize = true;
            this.Ldid.Location = new System.Drawing.Point(296, 100);
            this.Ldid.Name = "Ldid";
            this.Ldid.Size = new System.Drawing.Size(42, 13);
            this.Ldid.TabIndex = 0;
            this.Ldid.Text = "Dept Id";
            // 
            // Ldname
            // 
            this.Ldname.AutoSize = true;
            this.Ldname.Location = new System.Drawing.Point(296, 146);
            this.Ldname.Name = "Ldname";
            this.Ldname.Size = new System.Drawing.Size(61, 13);
            this.Ldname.TabIndex = 1;
            this.Ldname.Text = "Dept Name";
            // 
            // Llocation
            // 
            this.Llocation.AutoSize = true;
            this.Llocation.Location = new System.Drawing.Point(296, 194);
            this.Llocation.Name = "Llocation";
            this.Llocation.Size = new System.Drawing.Size(48, 13);
            this.Llocation.TabIndex = 2;
            this.Llocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(441, 191);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(441, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(441, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(81, 347);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(75, 23);
            this.btncreatefolder.TabIndex = 6;
            this.btncreatefolder.Text = "create folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btnwritefile
            // 
            this.btnwritefile.Location = new System.Drawing.Point(81, 279);
            this.btnwritefile.Name = "btnwritefile";
            this.btnwritefile.Size = new System.Drawing.Size(75, 23);
            this.btnwritefile.TabIndex = 7;
            this.btnwritefile.Text = "Write to file";
            this.btnwritefile.UseVisualStyleBackColor = true;
            this.btnwritefile.Click += new System.EventHandler(this.btnwritefile_Click);
            // 
            // btnreadfile
            // 
            this.btnreadfile.Location = new System.Drawing.Point(226, 279);
            this.btnreadfile.Name = "btnreadfile";
            this.btnreadfile.Size = new System.Drawing.Size(75, 23);
            this.btnreadfile.TabIndex = 8;
            this.btnreadfile.Text = "Read to file";
            this.btnreadfile.UseVisualStyleBackColor = true;
            this.btnreadfile.Click += new System.EventHandler(this.btnreadfile_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(226, 346);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(75, 24);
            this.btncreatefile.TabIndex = 9;
            this.btncreatefile.Text = "create file";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btnWriteBinary
            // 
            this.btnWriteBinary.Location = new System.Drawing.Point(646, 32);
            this.btnWriteBinary.Name = "btnWriteBinary";
            this.btnWriteBinary.Size = new System.Drawing.Size(75, 23);
            this.btnWriteBinary.TabIndex = 10;
            this.btnWriteBinary.Text = "write binary";
            this.btnWriteBinary.UseVisualStyleBackColor = true;
            this.btnWriteBinary.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnReadBinary
            // 
            this.btnReadBinary.Location = new System.Drawing.Point(646, 61);
            this.btnReadBinary.Name = "btnReadBinary";
            this.btnReadBinary.Size = new System.Drawing.Size(75, 23);
            this.btnReadBinary.TabIndex = 11;
            this.btnReadBinary.Text = "Read binary";
            this.btnReadBinary.UseVisualStyleBackColor = true;
            this.btnReadBinary.Click += new System.EventHandler(this.btnReadBinary_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(646, 123);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 12;
            this.btnSoapWrite.Text = "Soap write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(646, 168);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRead.TabIndex = 13;
            this.btnSoapRead.Text = "Soap read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(654, 232);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 14;
            this.btnXmlWrite.Text = "Xml write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(654, 270);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(75, 23);
            this.btnXmlRead.TabIndex = 15;
            this.btnXmlRead.Text = "Xml Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(654, 330);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJsonWrite.TabIndex = 16;
            this.btnJsonWrite.Text = "Json Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(654, 359);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(75, 23);
            this.btnJsonRead.TabIndex = 17;
            this.btnJsonRead.Text = "Json Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(441, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnReadBinary);
            this.Controls.Add(this.btnWriteBinary);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btnreadfile);
            this.Controls.Add(this.btnwritefile);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.Llocation);
            this.Controls.Add(this.Ldname);
            this.Controls.Add(this.Ldid);
            this.Name = "Form4";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ldid;
        private System.Windows.Forms.Label Ldname;
        private System.Windows.Forms.Label Llocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btnwritefile;
        private System.Windows.Forms.Button btnreadfile;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btnWriteBinary;
        private System.Windows.Forms.Button btnReadBinary;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnClear;
    }
}