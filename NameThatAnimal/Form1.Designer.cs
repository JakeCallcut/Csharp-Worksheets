namespace NameThatAnimal
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
            this.txtletter = new System.Windows.Forms.TextBox();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.btngen = new System.Windows.Forms.Button();
            this.lblcomment = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngo
            // 
            this.btngo.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngo.Location = new System.Drawing.Point(282, 154);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(109, 61);
            this.btngo.TabIndex = 0;
            this.btngo.Text = "PLAY";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // lblttl
            // 
            this.lblttl.AutoSize = true;
            this.lblttl.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttl.Location = new System.Drawing.Point(115, 15);
            this.lblttl.Name = "lblttl";
            this.lblttl.Size = new System.Drawing.Size(159, 29);
            this.lblttl.TabIndex = 1;
            this.lblttl.Text = "Input a number";
            this.lblttl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtletter
            // 
            this.txtletter.Location = new System.Drawing.Point(124, 171);
            this.txtletter.Name = "txtletter";
            this.txtletter.Size = new System.Drawing.Size(132, 26);
            this.txtletter.TabIndex = 2;
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 20;
            this.lstbx.Location = new System.Drawing.Point(36, 232);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(479, 144);
            this.lstbx.TabIndex = 3;
            this.lstbx.SelectedIndexChanged += new System.EventHandler(this.lstbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "and I will tell you";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "an animal which begins with that letter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblttl);
            this.groupBox1.Location = new System.Drawing.Point(72, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(621, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "an appropriate comment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "and I will Generate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Input a number between 1 and 10";
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(687, 188);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(132, 26);
            this.txtscore.TabIndex = 9;
            // 
            // btngen
            // 
            this.btngen.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngen.Location = new System.Drawing.Point(845, 171);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(142, 79);
            this.btngen.TabIndex = 8;
            this.btngen.Text = "Generate Comment";
            this.btngen.UseVisualStyleBackColor = true;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // lblcomment
            // 
            this.lblcomment.AutoSize = true;
            this.lblcomment.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomment.Location = new System.Drawing.Point(628, 282);
            this.lblcomment.Name = "lblcomment";
            this.lblcomment.Size = new System.Drawing.Size(103, 29);
            this.lblcomment.TabIndex = 10;
            this.lblcomment.Text = "Comment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 426);
            this.Controls.Add(this.lblcomment);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.txtletter);
            this.Controls.Add(this.btngo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label lblttl;
        private System.Windows.Forms.TextBox txtletter;
        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.Label lblcomment;
    }
}

