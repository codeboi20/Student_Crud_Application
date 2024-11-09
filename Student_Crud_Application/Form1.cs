namespace Student_Crud_Application
{
    public partial class Form1 : Form
    {
        bool SidebarExpand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Sidebar_timer_tick(object sender, EventArgs e)
        {
            //minimum and maximum size setter

            if (SidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            SidebarTimer.Start();
        }

        private void addStuBtn_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();



        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateStubtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
