namespace SESys
{
    partial class courses
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
            comboBoxcourseName = new ComboBox();
            comboBoxdays = new ComboBox();
            tbxstarTime = new TextBox();
            tbxendTime = new TextBox();
            btnAddToListbox = new Button();
            listBoxCourseTime = new ListBox();
            btnremovefromListbox = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnsave = new Button();
            btnUpdate = new Button();
            button1 = new Button();
            btndelete = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxcourseName
            // 
            comboBoxcourseName.FormattingEnabled = true;
            comboBoxcourseName.Location = new Point(168, 16);
            comboBoxcourseName.Margin = new Padding(2, 2, 2, 2);
            comboBoxcourseName.Name = "comboBoxcourseName";
            comboBoxcourseName.Size = new Size(232, 23);
            comboBoxcourseName.TabIndex = 1;
            comboBoxcourseName.SelectedIndexChanged += comboBoxcourseName_SelectedIndexChanged;
            // 
            // comboBoxdays
            // 
            comboBoxdays.FormattingEnabled = true;
            comboBoxdays.Location = new Point(168, 60);
            comboBoxdays.Margin = new Padding(2, 2, 2, 2);
            comboBoxdays.Name = "comboBoxdays";
            comboBoxdays.Size = new Size(120, 23);
            comboBoxdays.TabIndex = 2;
            // 
            // tbxstarTime
            // 
            tbxstarTime.Location = new Point(168, 83);
            tbxstarTime.Margin = new Padding(2, 2, 2, 2);
            tbxstarTime.Name = "tbxstarTime";
            tbxstarTime.Size = new Size(120, 23);
            tbxstarTime.TabIndex = 3;
            // 
            // tbxendTime
            // 
            tbxendTime.Location = new Point(169, 106);
            tbxendTime.Margin = new Padding(2, 2, 2, 2);
            tbxendTime.Name = "tbxendTime";
            tbxendTime.Size = new Size(118, 23);
            tbxendTime.TabIndex = 4;
            // 
            // btnAddToListbox
            // 
            btnAddToListbox.Location = new Point(439, 33);
            btnAddToListbox.Margin = new Padding(2, 2, 2, 2);
            btnAddToListbox.Name = "btnAddToListbox";
            btnAddToListbox.Size = new Size(153, 23);
            btnAddToListbox.TabIndex = 5;
            btnAddToListbox.Text = "Add";
            btnAddToListbox.UseVisualStyleBackColor = true;
            btnAddToListbox.Click += btnAddToListbox_Click;
            // 
            // listBoxCourseTime
            // 
            listBoxCourseTime.FormattingEnabled = true;
            listBoxCourseTime.ItemHeight = 15;
            listBoxCourseTime.Location = new Point(298, 60);
            listBoxCourseTime.Margin = new Padding(2, 2, 2, 2);
            listBoxCourseTime.Name = "listBoxCourseTime";
            listBoxCourseTime.Size = new Size(295, 64);
            listBoxCourseTime.TabIndex = 6;
            // 
            // btnremovefromListbox
            // 
            btnremovefromListbox.Location = new Point(298, 126);
            btnremovefromListbox.Margin = new Padding(2, 2, 2, 2);
            btnremovefromListbox.Name = "btnremovefromListbox";
            btnremovefromListbox.Size = new Size(137, 23);
            btnremovefromListbox.TabIndex = 7;
            btnremovefromListbox.Text = "Remove";
            btnremovefromListbox.UseVisualStyleBackColor = true;
            btnremovefromListbox.Click += btnremovefromListbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(22, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 10;
            label3.Text = "Date and Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(100, 85);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(100, 107);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 12;
            label5.Text = "End Time";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(596, 31);
            btnsave.Margin = new Padding(2, 2, 2, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(102, 25);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(596, 60);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 25);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(439, 126);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 15;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(596, 89);
            btndelete.Margin = new Padding(2, 2, 2, 2);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(102, 25);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(168, 43);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 17;
            label2.Text = "Select Day";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 167);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(668, 142);
            dataGridView1.TabIndex = 18;
            // 
            // courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.macos_monterey_wwdc_21_stock_5k_3840x2160_55841;
            ClientSize = new Size(741, 322);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btndelete);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnsave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnremovefromListbox);
            Controls.Add(listBoxCourseTime);
            Controls.Add(btnAddToListbox);
            Controls.Add(tbxendTime);
            Controls.Add(tbxstarTime);
            Controls.Add(comboBoxdays);
            Controls.Add(comboBoxcourseName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "courses";
            Text = "courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxcourseName;
        private ComboBox comboBoxdays;
        private TextBox tbxstarTime;
        private TextBox tbxendTime;
        private Button btnAddToListbox;
        private ListBox listBoxCourseTime;
        private Button btnremovefromListbox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnsave;
        private Button btnUpdate;
        private Button button1;
        private Button btndelete;
        private Label label2;
        private DataGridView dataGridView1;
    }
}