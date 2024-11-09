using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Crud_Application
{
    public partial class Form3 : Form
    {
        private void LoadDataFromFile(string filePath)
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Set up the columns if they are not already set
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("StudentNumber", "Student Number");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Surname", "Surname");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Course", "Course");
            }

            // Read the file line by line
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Split the line by comma to get individual values
                string[] values = line.Split(',');

                // Add the values as a new row to the DataGridView
                dataGridView1.Rows.Add(values);
            }
        }

        public Form3()
        {
            InitializeComponent();

           
            string filePath = "TextFile1.txt"; // Load data from the file into the
            LoadDataFromFile(filePath);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
