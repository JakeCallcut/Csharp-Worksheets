namespace DidYouKnow
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
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(539, 42);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(196, 56);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "Enter";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(46, 179);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(222, 26);
            this.txtheight.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(46, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 26);
            this.txtname.TabIndex = 2;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(46, 296);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(222, 26);
            this.txtweight.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(42, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(188, 20);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Please Enter Your Name:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Location = new System.Drawing.Point(42, 146);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(226, 20);
            this.lblheight.TabIndex = 5;
            this.lblheight.Text = "Please Enter Your Height in m:";
            this.lblheight.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(42, 263);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(233, 20);
            this.lblweight.TabIndex = 6;
            this.lblweight.Text = "Please Enter Your Weight in kg:";
            this.lblweight.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 20;
            this.lstbx.Location = new System.Drawing.Point(460, 121);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(296, 304);
            this.lstbx.TabIndex = 7;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(442, 50);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(91, 40);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Quit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.btngo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.Button btnexit;
    }
}

