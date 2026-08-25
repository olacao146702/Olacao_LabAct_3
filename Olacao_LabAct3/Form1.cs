using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Olacao_LabAct3
{
    public partial class Form1 : Form
    {
        private int queueNumber = 0;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Regular");
            comboBox1.Items.Add("Senior");
            comboBox1.Items.Add("Pregnant");
            comboBox1.Items.Add("Emergency");

            textBox4.Text = "N/A";
            textBox7.Text = "N/A";
            textBox5.Text = "N/A";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the patient's name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the patient's age.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox2.Focus();
                return;
            }

            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the reason for visit.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox3.Focus();
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient type.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboBox1.Focus();
                return;
            }

            queueNumber++;

            string queueCode = "Q" + queueNumber.ToString("D3");

            string patientType = comboBox1.SelectedItem.ToString();

            string priority = "";

            if (patientType == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (patientType == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (patientType == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else if (patientType == "Regular")
            {
                priority = "REGULAR";
            }

            textBox4.Text = queueCode;
            textBox7.Text = patientType;
            textBox5.Text = priority;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;

            textBox4.Text = "N/A";
            textBox7.Text = "N/A";
            textBox5.Text = "N/A";

            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}