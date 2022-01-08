
namespace hashcoding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EncriptEdilecek = new System.Windows.Forms.RichTextBox();
            this.Decriptedilecek = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.clearbutton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(97, 396);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(134, 55);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(414, 396);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(134, 55);
            this.DecryptButton.TabIndex = 1;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.EncriptEdilecek);
            this.flowLayoutPanel1.Controls.Add(this.Decriptedilecek);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 293);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // EncriptEdilecek
            // 
            this.EncriptEdilecek.Location = new System.Drawing.Point(3, 3);
            this.EncriptEdilecek.Name = "EncriptEdilecek";
            this.EncriptEdilecek.Size = new System.Drawing.Size(261, 290);
            this.EncriptEdilecek.TabIndex = 1;
            this.EncriptEdilecek.Text = "";
            this.EncriptEdilecek.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Decriptedilecek
            // 
            this.Decriptedilecek.Location = new System.Drawing.Point(270, 3);
            this.Decriptedilecek.Name = "Decriptedilecek";
            this.Decriptedilecek.Size = new System.Drawing.Size(243, 290);
            this.Decriptedilecek.TabIndex = 2;
            this.Decriptedilecek.Text = "";
            this.Decriptedilecek.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hash Encryption";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(321, 68);
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(257, 23);
            this.PrivateKeyTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(2, 100);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(46, 290);
            this.Clearbutton.TabIndex = 6;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearbutton2
            // 
            this.clearbutton2.Location = new System.Drawing.Point(570, 100);
            this.clearbutton2.Name = "clearbutton2";
            this.clearbutton2.Size = new System.Drawing.Size(46, 290);
            this.clearbutton2.TabIndex = 7;
            this.clearbutton2.Text = "Clear";
            this.clearbutton2.UseVisualStyleBackColor = true;
            this.clearbutton2.Click += new System.EventHandler(this.clearbutton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Büşra Tanır / Sena Bayramoğlu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearbutton2);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrivateKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DecryptButton);
            this.Name = "Form1";
            this.Text = "Hash Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox Decriptedilecek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button clearbutton2;
        private System.Windows.Forms.RichTextBox EncriptEdilecek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

