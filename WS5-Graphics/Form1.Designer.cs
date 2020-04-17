namespace WS5_Graphics
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
            this.pctbx = new System.Windows.Forms.PictureBox();
            this.btnrec = new System.Windows.Forms.Button();
            this.btncirc = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbx
            // 
            this.pctbx.Location = new System.Drawing.Point(12, 12);
            this.pctbx.Name = "pctbx";
            this.pctbx.Size = new System.Drawing.Size(590, 426);
            this.pctbx.TabIndex = 0;
            this.pctbx.TabStop = false;
            // 
            // btnrec
            // 
            this.btnrec.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrec.Location = new System.Drawing.Point(618, 12);
            this.btnrec.Name = "btnrec";
            this.btnrec.Size = new System.Drawing.Size(147, 79);
            this.btnrec.TabIndex = 1;
            this.btnrec.Text = "Draw Rectangle";
            this.btnrec.UseVisualStyleBackColor = true;
            // 
            // btncirc
            // 
            this.btncirc.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncirc.Location = new System.Drawing.Point(618, 97);
            this.btncirc.Name = "btncirc";
            this.btncirc.Size = new System.Drawing.Size(147, 80);
            this.btncirc.TabIndex = 2;
            this.btncirc.Text = "Draw Circle";
            this.btncirc.UseVisualStyleBackColor = true;
            // 
            // btnline
            // 
            this.btnline.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnline.Location = new System.Drawing.Point(618, 183);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(147, 77);
            this.btnline.TabIndex = 3;
            this.btnline.Text = "Draw Line";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(618, 332);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(105, 51);
            this.btnclr.TabIndex = 4;
            this.btnclr.Text = "CLEAR";
            this.btnclr.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexit.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(618, 389);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 49);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "QUIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnline);
            this.Controls.Add(this.btncirc);
            this.Controls.Add(this.btnrec);
            this.Controls.Add(this.pctbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbx;
        private System.Windows.Forms.Button btnrec;
        private System.Windows.Forms.Button btncirc;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnexit;
    }
}

