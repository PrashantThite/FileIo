
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
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(274, 359);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(75, 23);
            this.btncreatefolder.TabIndex = 6;
            this.btncreatefolder.Text = "create folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btnwritefile
            // 
            this.btnwritefile.Location = new System.Drawing.Point(274, 292);
            this.btnwritefile.Name = "btnwritefile";
            this.btnwritefile.Size = new System.Drawing.Size(75, 23);
            this.btnwritefile.TabIndex = 7;
            this.btnwritefile.Text = "Write to file";
            this.btnwritefile.UseVisualStyleBackColor = true;
            this.btnwritefile.Click += new System.EventHandler(this.btnwritefile_Click);
            // 
            // btnreadfile
            // 
            this.btnreadfile.Location = new System.Drawing.Point(466, 292);
            this.btnreadfile.Name = "btnreadfile";
            this.btnreadfile.Size = new System.Drawing.Size(75, 23);
            this.btnreadfile.TabIndex = 8;
            this.btnreadfile.Text = "Read to file";
            this.btnreadfile.UseVisualStyleBackColor = true;
            this.btnreadfile.Click += new System.EventHandler(this.btnreadfile_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(476, 359);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(75, 24);
            this.btncreatefile.TabIndex = 9;
            this.btncreatefile.Text = "create file";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}