namespace SESys
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
            tbxuser = new TextBox();
            tbxpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbxuser
            // 
            tbxuser.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxuser.Location = new Point(304, 254);
            tbxuser.Multiline = true;
            tbxuser.Name = "tbxuser";
            tbxuser.Size = new Size(289, 31);
            tbxuser.TabIndex = 0;
            // 
            // tbxpass
            // 
            tbxpass.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tbxpass.Location = new Point(304, 325);
            tbxpass.Multiline = true;
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(289, 31);
            tbxpass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(409, 155);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(391, 217);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(390, 297);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.SeaShell;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new Point(657, 405);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(106, 46);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.study_4270774;
            pictureBox1.Location = new Point(391, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Neon Future 2.0 Demo", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(100, 405);
            label4.Name = "label4";
            label4.Size = new Size(0, 36);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 8;
            label5.Text = "Exit";
            label5.Click += label5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = Properties.Resources.candy_5212666;
            pictureBox2.InitialImage = Properties.Resources.eye_10910408;
            pictureBox2.Location = new Point(562, 325);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_codioful__formerly_gradienta__7134981;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 493);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxpass);
            Controls.Add(tbxuser);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Enrollment System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxuser;
        private TextBox tbxpass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnlogin;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
    }
}