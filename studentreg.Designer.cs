namespace SESys
{
    partial class studentreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentreg));
            comboBoxregno = new ComboBox();
            tbxFname = new TextBox();
            tbxLname = new TextBox();
            tbxparentaddress = new TextBox();
            tbxparentNIC = new TextBox();
            tbxparentContactno = new TextBox();
            tbxhomephoneNo = new TextBox();
            tbxNIC = new TextBox();
            tbxstudentcontact = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            btnsave = new Button();
            btnUpdate = new Button();
            btndelete = new Button();
            btnclear = new Button();
            label2 = new Label();
            btnGenerateRegNo = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbxparentfullname = new TextBox();
            label13 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxregno
            // 
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(233, 47);
            comboBoxregno.Margin = new Padding(2);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(245, 23);
            comboBoxregno.TabIndex = 0;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(233, 76);
            tbxFname.Margin = new Padding(2);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(245, 23);
            tbxFname.TabIndex = 1;
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(233, 98);
            tbxLname.Margin = new Padding(2);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(245, 23);
            tbxLname.TabIndex = 2;
            // 
            // tbxparentaddress
            // 
            tbxparentaddress.BackColor = Color.MistyRose;
            tbxparentaddress.Location = new Point(233, 47);
            tbxparentaddress.Margin = new Padding(2);
            tbxparentaddress.Multiline = true;
            tbxparentaddress.Name = "tbxparentaddress";
            tbxparentaddress.Size = new Size(245, 51);
            tbxparentaddress.TabIndex = 3;
            // 
            // tbxparentNIC
            // 
            tbxparentNIC.BackColor = Color.MistyRose;
            tbxparentNIC.Location = new Point(233, 165);
            tbxparentNIC.Margin = new Padding(2);
            tbxparentNIC.Name = "tbxparentNIC";
            tbxparentNIC.Size = new Size(245, 23);
            tbxparentNIC.TabIndex = 4;
            // 
            // tbxparentContactno
            // 
            tbxparentContactno.BackColor = Color.MistyRose;
            tbxparentContactno.Location = new Point(233, 111);
            tbxparentContactno.Margin = new Padding(2);
            tbxparentContactno.Name = "tbxparentContactno";
            tbxparentContactno.Size = new Size(245, 23);
            tbxparentContactno.TabIndex = 5;
            // 
            // tbxhomephoneNo
            // 
            tbxhomephoneNo.BackColor = Color.MistyRose;
            tbxhomephoneNo.Location = new Point(233, 138);
            tbxhomephoneNo.Margin = new Padding(2);
            tbxhomephoneNo.Name = "tbxhomephoneNo";
            tbxhomephoneNo.Size = new Size(245, 23);
            tbxhomephoneNo.TabIndex = 6;
            // 
            // tbxNIC
            // 
            tbxNIC.Location = new Point(233, 124);
            tbxNIC.Margin = new Padding(2);
            tbxNIC.Name = "tbxNIC";
            tbxNIC.Size = new Size(245, 23);
            tbxNIC.TabIndex = 7;
            // 
            // tbxstudentcontact
            // 
            tbxstudentcontact.Location = new Point(233, 223);
            tbxstudentcontact.Margin = new Padding(2);
            tbxstudentcontact.Name = "tbxstudentcontact";
            tbxstudentcontact.Size = new Size(245, 23);
            tbxstudentcontact.TabIndex = 8;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(233, 153);
            dateTimePickerDOB.Margin = new Padding(2);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(245, 23);
            dateTimePickerDOB.TabIndex = 9;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.BackColor = Color.Transparent;
            rdoMale.ForeColor = SystemColors.ButtonHighlight;
            rdoMale.Location = new Point(316, 182);
            rdoMale.Margin = new Padding(2);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 10;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.BackColor = Color.Transparent;
            rdoFemale.ForeColor = SystemColors.ButtonHighlight;
            rdoFemale.Location = new Point(411, 179);
            rdoFemale.Margin = new Padding(2);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 11;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(494, 15);
            btnsave.Margin = new Padding(2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(86, 25);
            btnsave.TabIndex = 12;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(494, 44);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 25);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(494, 73);
            btndelete.Margin = new Padding(2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(86, 25);
            btndelete.TabIndex = 14;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(494, 101);
            btnclear.Margin = new Padding(2);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(86, 25);
            btnclear.TabIndex = 15;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 17;
            label2.Text = "Reg No";
            // 
            // btnGenerateRegNo
            // 
            btnGenerateRegNo.BackColor = SystemColors.ButtonHighlight;
            btnGenerateRegNo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateRegNo.Location = new Point(411, 23);
            btnGenerateRegNo.Margin = new Padding(2);
            btnGenerateRegNo.Name = "btnGenerateRegNo";
            btnGenerateRegNo.Size = new Size(66, 20);
            btnGenerateRegNo.TabIndex = 18;
            btnGenerateRegNo.Text = "Generate No";
            btnGenerateRegNo.UseVisualStyleBackColor = false;
            btnGenerateRegNo.Click += btnGenerateRegNo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(16, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 19;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(16, 94);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 20;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(15, 217);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 21;
            label5.Text = "Contact NO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(16, 119);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 22;
            label6.Text = "NIC No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(18, 153);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 23;
            label7.Text = "Date Of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(16, 182);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 24;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(8, 49);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 25;
            label9.Text = "Parent address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(8, 168);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 26;
            label10.Text = "Parent  Nic";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(8, 114);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(107, 15);
            label11.TabIndex = 27;
            label11.Text = "Parent Contact NO";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(8, 138);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 28;
            label12.Text = "Home Phone No";
            // 
            // tbxparentfullname
            // 
            tbxparentfullname.BackColor = Color.MistyRose;
            tbxparentfullname.Location = new Point(232, 15);
            tbxparentfullname.Margin = new Padding(2);
            tbxparentfullname.Name = "tbxparentfullname";
            tbxparentfullname.Size = new Size(245, 23);
            tbxparentfullname.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(8, 15);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 30;
            label13.Text = "Parent Full Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(608, 347);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbxLname);
            panel1.Controls.Add(btnGenerateRegNo);
            panel1.Controls.Add(comboBoxregno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxFname);
            panel1.Controls.Add(tbxNIC);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePickerDOB);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rdoMale);
            panel1.Controls.Add(rdoFemale);
            panel1.Controls.Add(tbxstudentcontact);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 313);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tbxparentfullname);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnclear);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnsave);
            panel2.Controls.Add(tbxparentaddress);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tbxparentContactno);
            panel2.Controls.Add(tbxparentNIC);
            panel2.Controls.Add(tbxhomephoneNo);
            panel2.Location = new Point(2, 319);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 205);
            panel2.TabIndex = 1;
            // 
            // studentreg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.macos_monterey_wwdc_21_stock_5k_3840x2160_5584;
            ClientSize = new Size(616, 347);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "studentreg";
            Text = "STSYS ";
            Load += studentreg_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxregno;
        private TextBox tbxFname;
        private TextBox tbxLname;
        private TextBox tbxparentaddress;
        private TextBox tbxparentNIC;
        private TextBox tbxparentContactno;
        private TextBox tbxhomephoneNo;
        private TextBox tbxNIC;
        private TextBox tbxstudentcontact;
        private DateTimePicker dateTimePickerDOB;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Button btnsave;
        private Button btnUpdate;
        private Button btndelete;
        private Button btnclear;
        private Label label2;
        private Button btnGenerateRegNo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbxparentfullname;
        private Label label13;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
    }
}