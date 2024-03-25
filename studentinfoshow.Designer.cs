namespace SESys
{
    partial class studentinfoshow
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
            comboBoxregno = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblfullname = new Label();
            label4 = new Label();
            Birthday = new Label();
            listBoxClasses = new ListBox();
            lblgender = new Label();
            lblage = new Label();
            Classes = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxregno
            // 
            comboBoxregno.BackColor = Color.Lavender;
            comboBoxregno.FormattingEnabled = true;
            comboBoxregno.Location = new Point(155, 25);
            comboBoxregno.Margin = new Padding(2, 2, 2, 2);
            comboBoxregno.Name = "comboBoxregno";
            comboBoxregno.Size = new Size(410, 23);
            comboBoxregno.TabIndex = 0;
            comboBoxregno.SelectedIndexChanged += comboBoxregno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(27, 26);
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
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // lblfullname
            // 
            lblfullname.AutoSize = true;
            lblfullname.BackColor = Color.Transparent;
            lblfullname.ForeColor = SystemColors.ButtonHighlight;
            lblfullname.Location = new Point(155, 58);
            lblfullname.Margin = new Padding(2, 0, 2, 0);
            lblfullname.Name = "lblfullname";
            lblfullname.Size = new Size(25, 15);
            lblfullname.TabIndex = 3;
            lblfullname.Text = "......";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(27, 80);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.BackColor = Color.Transparent;
            Birthday.ForeColor = SystemColors.ButtonHighlight;
            Birthday.Location = new Point(274, 80);
            Birthday.Margin = new Padding(2, 0, 2, 0);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(28, 15);
            Birthday.TabIndex = 5;
            Birthday.Text = "Age";
            // 
            // listBoxClasses
            // 
            listBoxClasses.BackColor = Color.Lavender;
            listBoxClasses.FormattingEnabled = true;
            listBoxClasses.ItemHeight = 15;
            listBoxClasses.Location = new Point(27, 122);
            listBoxClasses.Margin = new Padding(2, 2, 2, 2);
            listBoxClasses.Name = "listBoxClasses";
            listBoxClasses.Size = new Size(538, 64);
            listBoxClasses.TabIndex = 6;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.BackColor = Color.Transparent;
            lblgender.ForeColor = SystemColors.ButtonHighlight;
            lblgender.Location = new Point(155, 80);
            lblgender.Margin = new Padding(2, 0, 2, 0);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(25, 15);
            lblgender.TabIndex = 7;
            lblgender.Text = "......";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.BackColor = Color.Transparent;
            lblage.ForeColor = SystemColors.ButtonHighlight;
            lblage.Location = new Point(401, 80);
            lblage.Margin = new Padding(2, 0, 2, 0);
            lblage.Name = "lblage";
            lblage.Size = new Size(25, 15);
            lblage.TabIndex = 8;
            lblage.Text = "......";
            // 
            // Classes
            // 
            Classes.AutoSize = true;
            Classes.BackColor = Color.Transparent;
            Classes.ForeColor = SystemColors.ButtonHighlight;
            Classes.Location = new Point(520, 105);
            Classes.Margin = new Padding(2, 0, 2, 0);
            Classes.Name = "Classes";
            Classes.Size = new Size(45, 15);
            Classes.TabIndex = 9;
            Classes.Text = "Classes";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 190);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(538, 115);
            dataGridView1.TabIndex = 14;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // studentinfoshow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.macos_monterey_wwdc_21_stock_5k_3840x2160_5584;
            ClientSize = new Size(581, 322);
            Controls.Add(dataGridView1);
            Controls.Add(Classes);
            Controls.Add(lblage);
            Controls.Add(lblgender);
            Controls.Add(listBoxClasses);
            Controls.Add(Birthday);
            Controls.Add(label4);
            Controls.Add(lblfullname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxregno);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "studentinfoshow";
            Text = "Student Info";
            Load += studentinfoshow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxregno;
        private Label label1;
        private Label label2;
        private Label lblfullname;
        private Label label4;
        private Label Birthday;
        private ListBox listBoxClasses;
        private Label lblgender;
        private Label lblage;
        private Label Classes;
        private DataGridView dataGridView1;
    }
}