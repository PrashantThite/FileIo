
namespace FirstWindows
{
    partial class Form2
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
            this.Lname = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.Lcontactno = new System.Windows.Forms.Label();
            this.Laddr = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.btndetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(257, 37);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(39, 13);
            this.Lname.TabIndex = 0;
            this.Lname.Text = "Name";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(257, 83);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(52, 13);
            this.Lemail.TabIndex = 1;
            this.Lemail.Text = "Email Id";
            // 
            // Lcontactno
            // 
            this.Lcontactno.AutoSize = true;
            this.Lcontactno.Location = new System.Drawing.Point(237, 135);
            this.Lcontactno.Name = "Lcontactno";
            this.Lcontactno.Size = new System.Drawing.Size(98, 13);
            this.Lcontactno.TabIndex = 2;
            this.Lcontactno.Text = "Contact Number";
            // 
            // Laddr
            // 
            this.Laddr.AutoSize = true;
            this.Laddr.Location = new System.Drawing.Point(257, 178);
            this.Laddr.Name = "Laddr";
            this.Laddr.Size = new System.Drawing.Size(52, 13);
            this.Laddr.TabIndex = 3;
            this.Laddr.Text = "Address";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(260, 258);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(407, 258);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(87, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(341, 132);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(192, 20);
            this.txtcontactno.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(341, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(192, 20);
            this.txtemail.TabIndex = 7;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(341, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 20);
            this.txtname.TabIndex = 8;
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(341, 175);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(192, 20);
            this.txtaddr.TabIndex = 9;
            this.txtaddr.TextChanged += new System.EventHandler(this.txtaddr_TextChanged);
            // 
            // btndetails
            // 
            this.btndetails.Location = new System.Drawing.Point(552, 258);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(90, 23);
            this.btndetails.TabIndex = 10;
            this.btndetails.Text = "Show Details";
            this.btndetails.UseVisualStyleBackColor = true;
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btndetails);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.Laddr);
            this.Controls.Add(this.Lcontactno);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.Lname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label Lcontactno;
        private System.Windows.Forms.Label Laddr;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.Button btndetails;
    }
}