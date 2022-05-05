
namespace FirstWindows
{
    partial class Form1
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtpassw = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.luserid = new System.Windows.Forms.Label();
            this.lpassw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(137, 280);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(308, 280);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // txtpassw
            // 
            this.txtpassw.Location = new System.Drawing.Point(240, 151);
            this.txtpassw.Name = "txtpassw";
            this.txtpassw.Size = new System.Drawing.Size(164, 20);
            this.txtpassw.TabIndex = 2;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(240, 106);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(164, 20);
            this.txtuserid.TabIndex = 3;
            // 
            // luserid
            // 
            this.luserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luserid.Location = new System.Drawing.Point(134, 107);
            this.luserid.Name = "luserid";
            this.luserid.Size = new System.Drawing.Size(92, 20);
            this.luserid.TabIndex = 4;
            this.luserid.Text = "User Id";
            // 
            // lpassw
            // 
            this.lpassw.AutoSize = true;
            this.lpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassw.Location = new System.Drawing.Point(134, 151);
            this.lpassw.Name = "lpassw";
            this.lpassw.Size = new System.Drawing.Size(69, 17);
            this.lpassw.TabIndex = 5;
            this.lpassw.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.lpassw);
            this.Controls.Add(this.luserid);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtpassw);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Name = "Form1";
            this.Text = "User login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtpassw;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label luserid;
        private System.Windows.Forms.Label lpassw;
    }
}

