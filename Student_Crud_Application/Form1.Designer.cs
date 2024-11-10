namespace Student_Crud_Application
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            menuButton = new Button();
            panel2 = new Panel();
            addStuBtn = new Button();
            panel3 = new Panel();
            updateStubtn = new Button();
            panel6 = new Panel();
            deleteStuBtn = new Button();
            panel7 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            reportSumbtn = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 203);
            label1.Name = "label1";
            label1.Size = new Size(217, 60);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(29, 20, 49);
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(panel7);
            Sidebar.Controls.Add(panel5);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(205, 450);
            Sidebar.MinimumSize = new Size(77, 450);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(205, 450);
            Sidebar.TabIndex = 1;
            Sidebar.Paint += Sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 100);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(menuButton);
            panel4.Location = new Point(9, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(58, 58);
            panel4.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Dock = DockStyle.Fill;
            menuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            menuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuButton.ForeColor = Color.FromArgb(255, 128, 255);
            menuButton.Location = new Point(0, 0);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(58, 58);
            menuButton.TabIndex = 2;
            menuButton.Text = "=";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(addStuBtn);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 41);
            panel2.TabIndex = 3;
            // 
            // addStuBtn
            // 
            addStuBtn.BackColor = Color.Transparent;
            addStuBtn.BackgroundImageLayout = ImageLayout.None;
            addStuBtn.Cursor = Cursors.Hand;
            addStuBtn.Dock = DockStyle.Fill;
            addStuBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            addStuBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            addStuBtn.FlatStyle = FlatStyle.Popup;
            addStuBtn.ForeColor = Color.Violet;
            addStuBtn.Location = new Point(0, 0);
            addStuBtn.Name = "addStuBtn";
            addStuBtn.Size = new Size(202, 41);
            addStuBtn.TabIndex = 2;
            addStuBtn.Text = "    Add Student";
            addStuBtn.TextAlign = ContentAlignment.MiddleRight;
            addStuBtn.UseVisualStyleBackColor = false;
            addStuBtn.Click += addStuBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(updateStubtn);
            panel3.Location = new Point(3, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(202, 41);
            panel3.TabIndex = 3;
            // 
            // updateStubtn
            // 
            updateStubtn.BackColor = Color.Transparent;
            updateStubtn.BackgroundImageLayout = ImageLayout.None;
            updateStubtn.Cursor = Cursors.Hand;
            updateStubtn.Dock = DockStyle.Fill;
            updateStubtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            updateStubtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            updateStubtn.FlatStyle = FlatStyle.Popup;
            updateStubtn.ForeColor = Color.Violet;
            updateStubtn.Location = new Point(0, 0);
            updateStubtn.Name = "updateStubtn";
            updateStubtn.Size = new Size(202, 41);
            updateStubtn.TabIndex = 2;
            updateStubtn.Text = "    View Students";
            updateStubtn.TextAlign = ContentAlignment.MiddleRight;
            updateStubtn.UseVisualStyleBackColor = false;
            updateStubtn.Click += updateStubtn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Controls.Add(deleteStuBtn);
            panel6.Location = new Point(3, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(202, 41);
            panel6.TabIndex = 3;
            // 
            // deleteStuBtn
            // 
            deleteStuBtn.BackColor = Color.Transparent;
            deleteStuBtn.BackgroundImageLayout = ImageLayout.None;
            deleteStuBtn.Cursor = Cursors.Hand;
            deleteStuBtn.Dock = DockStyle.Fill;
            deleteStuBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            deleteStuBtn.FlatStyle = FlatStyle.Popup;
            deleteStuBtn.ForeColor = Color.Violet;
            deleteStuBtn.Location = new Point(0, 0);
            deleteStuBtn.Name = "deleteStuBtn";
            deleteStuBtn.Size = new Size(202, 41);
            deleteStuBtn.TabIndex = 2;
            deleteStuBtn.Text = "    Delete Student";
            deleteStuBtn.TextAlign = ContentAlignment.MiddleRight;
            deleteStuBtn.UseVisualStyleBackColor = false;
            deleteStuBtn.Click += deleteStuBtn_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Controls.Add(button1);
            panel7.Location = new Point(3, 250);
            panel7.Name = "panel7";
            panel7.Size = new Size(202, 41);
            panel7.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Violet;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(202, 41);
            button1.TabIndex = 2;
            button1.Text = "     Update";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Controls.Add(reportSumbtn);
            panel5.Location = new Point(3, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(202, 41);
            panel5.TabIndex = 3;
            // 
            // reportSumbtn
            // 
            reportSumbtn.BackColor = Color.Transparent;
            reportSumbtn.BackgroundImageLayout = ImageLayout.None;
            reportSumbtn.Cursor = Cursors.Hand;
            reportSumbtn.Dock = DockStyle.Fill;
            reportSumbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            reportSumbtn.FlatStyle = FlatStyle.Popup;
            reportSumbtn.ForeColor = Color.Violet;
            reportSumbtn.Location = new Point(0, 0);
            reportSumbtn.Name = "reportSumbtn";
            reportSumbtn.Size = new Size(202, 41);
            reportSumbtn.TabIndex = 2;
            reportSumbtn.Text = "    Report summary";
            reportSumbtn.TextAlign = ContentAlignment.MiddleRight;
            reportSumbtn.UseVisualStyleBackColor = false;
            reportSumbtn.Click += reportSumbtn_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += Sidebar_timer_tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 223, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(Sidebar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Button addStuBtn;
        private Panel panel2;
        private Panel panel3;
        private Button updateStubtn;
        private Panel panel6;
        private Button deleteStuBtn;
        private Panel panel5;
        private Button reportSumbtn;
        private Panel panel4;
        private Button menuButton;
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel panel7;
        private Button button1;
    }
}
