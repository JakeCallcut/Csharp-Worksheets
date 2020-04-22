namespace SearchTechniques
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
            this.txtsrcitem = new System.Windows.Forms.TextBox();
            this.lblttl = new System.Windows.Forms.Label();
            this.btnbin = new System.Windows.Forms.Button();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.btnser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsrcitem
            // 
            this.txtsrcitem.Location = new System.Drawing.Point(18, 82);
            this.txtsrcitem.Name = "txtsrcitem";
            this.txtsrcitem.Size = new System.Drawing.Size(202, 26);
            this.txtsrcitem.TabIndex = 0;
            this.txtsrcitem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblttl
            // 
            this.lblttl.AutoSize = true;
            this.lblttl.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttl.Location = new System.Drawing.Point(12, 30);
            this.lblttl.Name = "lblttl";
            this.lblttl.Size = new System.Drawing.Size(238, 35);
            this.lblttl.TabIndex = 1;
            this.lblttl.Text = "Enter a search item";
            // 
            // btnbin
            // 
            this.btnbin.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbin.Location = new System.Drawing.Point(237, 81);
            this.btnbin.Name = "btnbin";
            this.btnbin.Size = new System.Drawing.Size(140, 87);
            this.btnbin.TabIndex = 2;
            this.btnbin.Text = "Binary Search";
            this.btnbin.UseVisualStyleBackColor = true;
            this.btnbin.Click += new System.EventHandler(this.btnbin_Click);
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 20;
            this.lstbx.Location = new System.Drawing.Point(18, 114);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(202, 324);
            this.lstbx.TabIndex = 4;
            // 
            // btnser
            // 
            this.btnser.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnser.Location = new System.Drawing.Point(237, 174);
            this.btnser.Name = "btnser";
            this.btnser.Size = new System.Drawing.Size(140, 87);
            this.btnser.TabIndex = 5;
            this.btnser.Text = "Serial search";
            this.btnser.UseVisualStyleBackColor = true;
            this.btnser.Click += new System.EventHandler(this.btnser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 448);
            this.Controls.Add(this.btnser);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.btnbin);
            this.Controls.Add(this.lblttl);
            this.Controls.Add(this.txtsrcitem);
            this.Name = "Form1";
            this.Text = "Search techniques";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblttl;
        private System.Windows.Forms.Button btnbin;
        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.Button btnser;
        public System.Windows.Forms.TextBox txtsrcitem;
    }
}

