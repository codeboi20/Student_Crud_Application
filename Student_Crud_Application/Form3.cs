using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


        private void SaveDataToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] values = new string[dataGridView1.Columns.Count];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            values[i] = row.Cells[i].Value?.ToString();
                        }
                        string line = string.Join(",", values);
                        writer.WriteLine(line);
                    }
                }
            }
        }





        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("DIT");
            comboBox1.Items.Add("BIT");
            comboBox1.Items.Add("BCOM");


            string filePath = "TextFile1.txt"; // Load data from the file into the
            LoadDataFromFile(filePath);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        // dataGridView1_CellContentClick

        private int selectedRowIndex = -1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header cell and is within the valid range
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the text boxes with the values from the selected row
                textBox1.Text = row.Cells["StudentNumber"].Value?.ToString();
                textBox2.Text = row.Cells["Name"].Value?.ToString();
                textBox3.Text = row.Cells["Surname"].Value?.ToString();
                textBox4.Text = row.Cells["Age"].Value?.ToString();
                comboBox1.Text = row.Cells["Course"].Value?.ToString();

                // Store the selected row index
                selectedRowIndex = e.RowIndex;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                // Get the updated values from the text boxes
                string updatedStudentNumber = textBox1.Text;
                string updatedName = textBox2.Text;
                string updatedSurname = textBox3.Text;
                string updatedAge = textBox4.Text;
                string updatedCourse = comboBox1.Text;

                // Update the row with the new values
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                row.Cells["StudentNumber"].Value = updatedStudentNumber;
                row.Cells["Name"].Value = updatedName;
                row.Cells["Surname"].Value = updatedSurname;
                row.Cells["Age"].Value = updatedAge;
                row.Cells["Course"].Value = updatedCourse;

                // Write the updated data back to the text file
                SaveDataToFile("TextFile1.txt");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    SaveDataToFile("TextFile1.txt");
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
        
        
        }

          

        
    }
}
