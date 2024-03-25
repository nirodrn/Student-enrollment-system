namespace SESys
{
    partial class stclass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stclass));
            label1 = new Label();
            label2 = new Label();
            lblstudentinfo = new Label();
            listBoxCoursetime = new ListBox();
            comboBoxregno = new ComboBox();
            comboBoxcoursdetails = new ComboBox();
            btnassign = new Button();
            btnclear = new Button();
            btnsave = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            listBoxstudentcources = new ListBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Reg No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(280, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Info";
            label2.Click += label2_Click;
            // 
            // lblstudentinfo
            // 
            lblstudentinfo.AutoSize = true;
            lblstudentinfo.BackColor = Color.Transparent;
            lblstudentinfo.ForeColor = SystemColors.ActiveCaptionText;
            lblstudentinfo.Location = new Point(362, 93);
            lblstudentinfo.Margin = new Padding(2, 0, 2, 0);
            lblstudentinfo.Name = "lblstudentinfo";
            lblstudentinfo.Size = new Size(28, 15);
            lblstudentinfo.TabIndex = 3;
            lblstudentinfo.Text = ".......";
            // 
            // listBoxCoursetime
            // 
            listBoxCoursetime.BackColor = Color.LightCyan;
            listBoxCoursetime.FormattingEnabled = true;
            listBoxCoursetime.ItemHeight = 15;
            listBoxCoursetime.Location = new Point(44, 124);
            listBoxCoursetime.Margin = new Padding(2, 2, 2, 2);
            listBoxCoursetime.Name = "listBoxCoursetime";
            listBoxCoursetime.Size = new Size(222, 154);
            listBoxCoursetime.TabIndex = 4;
            // 
            // comboBoxregno
            // 
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(44, 45);
            comboBoxregno.Margin = new Padding(2, 2, 2, 2);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(222, 23);
            comboBoxregno.TabIndex = 5;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // comboBoxcoursdetails
            // 
            comboBoxcoursdetails.FormattingEnabled = true;
            comboBoxcoursdetails.Location = new Point(44, 93);
            comboBoxcoursdetails.Margin = new Padding(2, 2, 2, 2);
            comboBoxcoursdetails.Name = "comboBoxcoursdetails";
            comboBoxcoursdetails.Size = new Size(222, 23);
            comboBoxcoursdetails.TabIndex = 6;
            comboBoxcoursdetails.SelectedIndexChanged += comboBoxcoursdetails_SelectedIndexChanged;
            // 
            // btnassign
            // 
            btnassign.Location = new Point(267, 139);
            btnassign.Margin = new Padding(2, 2, 2, 2);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(123, 24);
            btnassign.TabIndex = 7;
            btnassign.Text = "Assign the courses To student";
            btnassign.UseVisualStyleBackColor = true;
            btnassign.Click += btnassign_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(449, 280);
            btnclear.Margin = new Padding(2, 2, 2, 2);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(80, 25);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(503, 7);
            btnsave.Margin = new Padding(2, 2, 2, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(112, 25);
            btnsave.TabIndex = 9;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(534, 280);
            btndelete.Margin = new Padding(2, 2, 2, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(80, 25);
            btndelete.TabIndex = 10;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(503, 35);
            btnupdate.Margin = new Padding(2, 2, 2, 2);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(112, 25);
            btnupdate.TabIndex = 11;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // listBoxstudentcources
            // 
            listBoxstudentcources.BackColor = Color.Beige;
            listBoxstudentcources.ForeColor = SystemColors.WindowText;
            listBoxstudentcources.FormattingEnabled = true;
            listBoxstudentcources.ItemHeight = 15;
            listBoxstudentcources.Location = new Point(394, 124);
            listBoxstudentcources.Margin = new Padding(2, 2, 2, 2);
            listBoxstudentcources.Name = "listBoxstudentcources";
            listBoxstudentcources.Size = new Size(222, 154);
            listBoxstudentcources.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(44, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 13;
            label3.Text = "select cource ";
            // 
            // button1
            // 
            button1.Location = new Point(269, 167);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(121, 20);
            button1.TabIndex = 14;
            button1.Text = "Remove ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stclass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.macos_monterey_wwdc_21_stock_5k_3840x2160_5584;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(661, 322);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBoxstudentcources);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnsave);
            Controls.Add(btnclear);
            Controls.Add(btnassign);
            Controls.Add(comboBoxcoursdetails);
            Controls.Add(comboBoxregno);
            Controls.Add(listBoxCoursetime);
            Controls.Add(lblstudentinfo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "stclass";
            Text = "stclass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblstudentinfo;
        private ListBox listBoxCoursetime;
        private ComboBox comboBoxregno;
        private ComboBox comboBoxcoursdetails;
        private Button btnassign;
        private Button btnclear;
        private Button btnsave;
        private Button btndelete;
        private Button btnupdate;
        private ListBox listBoxstudentcources;
        private Label label3;
        private Button button1;
    }
}