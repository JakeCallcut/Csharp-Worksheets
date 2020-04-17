namespace GuessMyNumber
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
            this.lblttl = new System.Windows.Forms.Label();
            this.txtguess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(159, 208);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(190, 75);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "PLAY";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // lblttl
            // 
            this.lblttl.AutoSize = true;
            this.lblttl.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttl.Location = new System.Drawing.Point(76, 59);
            this.lblttl.Name = "lblttl";
            this.lblttl.Size = new System.Drawing.Size(359, 32);
            this.lblttl.TabIndex = 1;
            this.lblttl.Text = "Guess a number between 1 and 10";
            // 
            // txtguess
            // 
            this.txtguess.Location = new System.Drawing.Point(132, 136);
            this.txtguess.Name = "txtguess";
            this.txtguess.Size = new System.Drawing.Size(241, 26);
            this.txtguess.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 331);
            this.Controls.Add(this.txtguess);
            this.Controls.Add(this.lblttl);
            this.Controls.Add(this.btngo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label lblttl;
        private System.Windows.Forms.TextBox txtguess;
    }
}

