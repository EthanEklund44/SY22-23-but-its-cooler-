namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.cctextbox = new System.Windows.Forms.TextBox();
            this.exptextbox = new System.Windows.Forms.TextBox();
            this.ziptextbox = new System.Windows.Forms.TextBox();
            this.amounttextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ccvtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "EXP date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "ZIP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(184, 13);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(140, 39);
            this.nametextbox.TabIndex = 6;
            // 
            // cctextbox
            // 
            this.cctextbox.Location = new System.Drawing.Point(184, 76);
            this.cctextbox.Multiline = true;
            this.cctextbox.Name = "cctextbox";
            this.cctextbox.Size = new System.Drawing.Size(140, 39);
            this.cctextbox.TabIndex = 7;
            // 
            // exptextbox
            // 
            this.exptextbox.Location = new System.Drawing.Point(184, 135);
            this.exptextbox.Multiline = true;
            this.exptextbox.Name = "exptextbox";
            this.exptextbox.Size = new System.Drawing.Size(140, 39);
            this.exptextbox.TabIndex = 8;
            // 
            // ziptextbox
            // 
            this.ziptextbox.Location = new System.Drawing.Point(184, 200);
            this.ziptextbox.Multiline = true;
            this.ziptextbox.Name = "ziptextbox";
            this.ziptextbox.Size = new System.Drawing.Size(140, 39);
            this.ziptextbox.TabIndex = 9;
            // 
            // amounttextbox
            // 
            this.amounttextbox.Location = new System.Drawing.Point(184, 322);
            this.amounttextbox.Multiline = true;
            this.amounttextbox.Name = "amounttextbox";
            this.amounttextbox.Size = new System.Drawing.Size(140, 39);
            this.amounttextbox.TabIndex = 10;
            this.amounttextbox.TextChanged += new System.EventHandler(this.amounttextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "CCV:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ccvtextbox
            // 
            this.ccvtextbox.Location = new System.Drawing.Point(184, 261);
            this.ccvtextbox.Multiline = true;
            this.ccvtextbox.Name = "ccvtextbox";
            this.ccvtextbox.Size = new System.Drawing.Size(140, 39);
            this.ccvtextbox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.visalogo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(330, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 43);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fee:";
            // 
            // feetextbox
            // 
            this.feetextbox.Location = new System.Drawing.Point(417, 383);
            this.feetextbox.Multiline = true;
            this.feetextbox.Name = "feetextbox";
            this.feetextbox.Size = new System.Drawing.Size(154, 43);
            this.feetextbox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.blur;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.feetextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ccvtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amounttextbox);
            this.Controls.Add(this.ziptextbox);
            this.Controls.Add(this.exptextbox);
            this.Controls.Add(this.cctextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Visa Checkout";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox cctextbox;
        private System.Windows.Forms.TextBox exptextbox;
        private System.Windows.Forms.TextBox ziptextbox;
        private System.Windows.Forms.TextBox amounttextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ccvtextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox feetextbox;
    }
}

