namespace TranslateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.CoBx1 = new System.Windows.Forms.ComboBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBTran = new System.Windows.Forms.TextBox();
            this.TBWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb9);
            this.panel1.Controls.Add(this.TBTran);
            this.panel1.Controls.Add(this.lb8);
            this.panel1.Controls.Add(this.TBWord);
            this.panel1.Controls.Add(this.lb7);
            this.panel1.Controls.Add(this.CoBx1);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 644);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(33, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Write The Word Here";
            // 
            // lb9
            // 
            this.lb9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb9.ForeColor = System.Drawing.Color.Red;
            this.lb9.Location = new System.Drawing.Point(279, 491);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(0, 29);
            this.lb9.TabIndex = 11;
            // 
            // lb8
            // 
            this.lb8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb8.AutoSize = true;
            this.lb8.BackColor = System.Drawing.Color.DarkBlue;
            this.lb8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb8.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb8.ForeColor = System.Drawing.Color.White;
            this.lb8.Location = new System.Drawing.Point(237, 31);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(162, 39);
            this.lb8.TabIndex = 10;
            this.lb8.Text = "Language";
            this.lb8.Click += new System.EventHandler(this.lb9_Click);
            // 
            // lb7
            // 
            this.lb7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb7.AutoSize = true;
            this.lb7.BackColor = System.Drawing.Color.Transparent;
            this.lb7.Cursor = System.Windows.Forms.Cursors.No;
            this.lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb7.ForeColor = System.Drawing.Color.Black;
            this.lb7.Location = new System.Drawing.Point(166, 610);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(304, 25);
            this.lb7.TabIndex = 9;
            this.lb7.Text = "Developer:Eslam Murad Abdullah";
            this.lb7.Click += new System.EventHandler(this.label5_Click);
            // 
            // CoBx1
            // 
            this.CoBx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoBx1.BackColor = System.Drawing.Color.Navy;
            this.CoBx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CoBx1.ForeColor = System.Drawing.Color.White;
            this.CoBx1.FormattingEnabled = true;
            this.CoBx1.ItemHeight = 25;
            this.CoBx1.Location = new System.Drawing.Point(191, 87);
            this.CoBx1.MaxDropDownItems = 4;
            this.CoBx1.MaxLength = 5;
            this.CoBx1.Name = "CoBx1";
            this.CoBx1.Size = new System.Drawing.Size(250, 33);
            this.CoBx1.Sorted = true;
            this.CoBx1.TabIndex = 0;
            this.CoBx1.SelectedIndexChanged += new System.EventHandler(this.CoBx1_SelectedIndexChanged);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.Navy;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(191, 291);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(245, 113);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Translate";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TBTran
            // 
            this.TBTran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TBTran.Location = new System.Drawing.Point(377, 176);
            this.TBTran.Name = "TBTran";
            this.TBTran.Size = new System.Drawing.Size(248, 44);
            this.TBTran.TabIndex = 2;
            this.TBTran.TextChanged += new System.EventHandler(this.TBTran_TextChanged);
            // 
            // TBWord
            // 
            this.TBWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TBWord.Location = new System.Drawing.Point(3, 176);
            this.TBWord.Name = "TBWord";
            this.TBWord.Size = new System.Drawing.Size(247, 44);
            this.TBWord.TabIndex = 1;
            this.TBWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.ComboBox CoBx1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBTran;
        private System.Windows.Forms.TextBox TBWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label label1;
    }
}