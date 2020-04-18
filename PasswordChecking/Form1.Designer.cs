namespace PasswordChecking
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
            this.btngo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblatt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Sitka Text", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(78, 327);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(206, 72);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "Enter";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your user ID:";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Location = new System.Drawing.Point(103, 226);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(159, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Enter your Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(279, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(47, 126);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(279, 26);
            this.txtuser.TabIndex = 4;
            // 
            // lblatt
            // 
            this.lblatt.AutoSize = true;
            this.lblatt.Location = new System.Drawing.Point(124, 430);
            this.lblatt.Name = "lblatt";
            this.lblatt.Size = new System.Drawing.Size(95, 20);
            this.lblatt.TabIndex = 5;
            this.lblatt.Text = "Attempts: /3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 475);
            this.Controls.Add(this.lblatt);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblatt;
    }
}

