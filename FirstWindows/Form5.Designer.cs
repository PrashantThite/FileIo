
namespace FirstWindows
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
            this.Lname = new System.Windows.Forms.Label();
            this.Lstream = new System.Windows.Forms.Label();
            this.Lrollno = new System.Windows.Forms.Label();
            this.Lpercent = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(344, 84);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(35, 13);
            this.Lname.TabIndex = 0;
            this.Lname.Text = "Name";
            // 
            // Lstream
            // 
            this.Lstream.AutoSize = true;
            this.Lstream.Location = new System.Drawing.Point(344, 134);
            this.Lstream.Name = "Lstream";
            this.Lstream.Size = new System.Drawing.Size(40, 13);
            this.Lstream.TabIndex = 1;
            this.Lstream.Text = "Stream";
            // 
            // Lrollno
            // 
            this.Lrollno.AutoSize = true;
            this.Lrollno.Location = new System.Drawing.Point(344, 198);
            this.Lrollno.Name = "Lrollno";
            this.Lrollno.Size = new System.Drawing.Size(42, 13);
            this.Lrollno.TabIndex = 2;
            this.Lrollno.Text = "Roll No";
            // 
            // Lpercent
            // 
            this.Lpercent.AutoSize = true;
            this.Lpercent.Location = new System.Drawing.Point(344, 251);
            this.Lpercent.Name = "Lpercent";
            this.Lpercent.Size = new System.Drawing.Size(62, 13);
            this.Lpercent.TabIndex = 3;
            this.Lpercent.Text = "Percentage";
            this.Lpercent.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(438, 248);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 4;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(438, 191);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(100, 20);
            this.txtRollNo.TabIndex = 5;
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(438, 134);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(100, 20);
            this.txtStream.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(438, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(323, 319);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Write to file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(463, 319);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(583, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.Lpercent);
            this.Controls.Add(this.Lrollno);
            this.Controls.Add(this.Lstream);
            this.Controls.Add(this.Lname);
            this.Name = "Form5";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lstream;
        private System.Windows.Forms.Label Lrollno;
        private System.Windows.Forms.Label Lpercent;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
    }
}