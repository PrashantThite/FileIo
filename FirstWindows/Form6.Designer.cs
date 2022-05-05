
namespace FirstWindows
{
    partial class Form6
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
            this.LId = new System.Windows.Forms.Label();
            this.Ldepartment = new System.Windows.Forms.Label();
            this.Ldesignation = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Lsalary = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(290, 64);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(38, 13);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "NAME";
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(290, 113);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(35, 13);
            this.LId.TabIndex = 2;
            this.LId.Text = "ID No";
            // 
            // Ldepartment
            // 
            this.Ldepartment.AutoSize = true;
            this.Ldepartment.Location = new System.Drawing.Point(290, 161);
            this.Ldepartment.Name = "Ldepartment";
            this.Ldepartment.Size = new System.Drawing.Size(62, 13);
            this.Ldepartment.TabIndex = 3;
            this.Ldepartment.Text = "Department";
            // 
            // Ldesignation
            // 
            this.Ldesignation.AutoSize = true;
            this.Ldesignation.Location = new System.Drawing.Point(290, 227);
            this.Ldesignation.Name = "Ldesignation";
            this.Ldesignation.Size = new System.Drawing.Size(63, 13);
            this.Ldesignation.TabIndex = 4;
            this.Ldesignation.Text = "Designation";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(423, 220);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(182, 20);
            this.txtdesignation.TabIndex = 5;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(423, 161);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(182, 20);
            this.txtdepartment.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(423, 110);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(182, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(423, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(182, 20);
            this.txtname.TabIndex = 8;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(230, 327);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write to file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(370, 327);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(530, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Lsalary
            // 
            this.Lsalary.AutoSize = true;
            this.Lsalary.Location = new System.Drawing.Point(293, 275);
            this.Lsalary.Name = "Lsalary";
            this.Lsalary.Size = new System.Drawing.Size(36, 13);
            this.Lsalary.TabIndex = 12;
            this.Lsalary.Text = "Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(423, 268);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(182, 20);
            this.txtsalary.TabIndex = 13;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.Lsalary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.Ldesignation);
            this.Controls.Add(this.Ldepartment);
            this.Controls.Add(this.LId);
            this.Controls.Add(this.Lname);
            this.Name = "Form6";
            this.Text = "Emp Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.Label Ldepartment;
        private System.Windows.Forms.Label Ldesignation;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Lsalary;
        private System.Windows.Forms.TextBox txtsalary;
    }
}