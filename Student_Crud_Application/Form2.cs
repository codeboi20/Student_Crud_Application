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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox2.Items.Add("DIT");
            comboBox2.Items.Add("BIT"); 
            comboBox2.Items.Add("BCOM");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
                // Retrieve values from text boxes
                string Student_Num = textBox1.Text;
                string Name = textBox3.Text;
                string Surname = textBox2.Text;
                string age = textBox4.Text;
                string selectedItem = comboBox2.SelectedItem.ToString();
                

            // Combine values into a single line, delimited by commas
            string line = $"{Student_Num},{Name},{Surname},{age},{selectedItem}";

                // Write the line to a text file
                using (StreamWriter writer = new StreamWriter("TextFile1.txt", true))
                {
                    writer.WriteLine(line);
                }

                // Optionally, clear the text boxes after writing to the file
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();


        }
    }
}
