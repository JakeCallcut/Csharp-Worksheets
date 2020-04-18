namespace PasswordChecking
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
            this.btnchange = new System.Windows.Forms.Button();
            this.btnlogon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(12, 128);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(277, 110);
            this.btnchange.TabIndex = 1;
            this.btnchange.Text = "Change Password";
            this.btnchange.UseVisualStyleBackColor = true;
            // 
            // btnlogon
            // 
            this.btnlogon.Location = new System.Drawing.Point(12, 12);
            this.btnlogon.Name = "btnlogon";
            this.btnlogon.Size = new System.Drawing.Size(277, 110);
            this.btnlogon.TabIndex = 2;
            this.btnlogon.Text = "Log On";
            this.btnlogon.UseVisualStyleBackColor = true;
            this.btnlogon.Click += new System.EventHandler(this.btnlogon_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 247);
            this.Controls.Add(this.btnlogon);
            this.Controls.Add(this.btnchange);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnlogon;
    }
}