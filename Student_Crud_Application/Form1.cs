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

        private void CalculatePeopleAndAverageAge(string filePath)
        {
            int totalAge = 0;
            int rowCount = 0;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {

                string[] values = line.Split(',');

                if (values.Length >= 4 && int.TryParse(values[3], out int age))
                {
                    totalAge += age;
                    rowCount++;
                }
            }


            double averageAge = (rowCount > 0) ? (double)totalAge / rowCount : 0;
            MessageBox.Show($"Number of people: {rowCount}\nAverage age: {averageAge:F2}");
        }

        private void reportSumbtn_Click(object sender, EventArgs e)
        {
            string filePath = "TextFile1.txt";
            CalculatePeopleAndAverageAge(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void deleteStuBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
