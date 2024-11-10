namespace Student_Crud_Application
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            deletebtn = new Button();
            panel1 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(9, 20, 49);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(617, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 378);
            button1.Name = "button1";
            button1.Size = new Size(67, 38);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "Student Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 2;
            label4.Text = "Age";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 2;
            label5.Text = "Course";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 4;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.IndianRed;
            deletebtn.Location = new Point(85, 378);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(67, 38);
            deletebtn.TabIndex = 1;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(49, 47);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(49, 47);
            button3.TabIndex = 6;
            button3.Text = "<-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(deletebtn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private Button deletebtn;
        private Panel panel1;
        private Button button3;
    }
}