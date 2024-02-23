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

namespace StudentGradeApplication
{       
    public partial class Form1 : Form
    {
        private object textBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GenAveBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string name1 = name.Text;
            double English1 = Convert.ToDouble (English.Text);
            double Math1 = Convert.ToDouble(Math.Text);
            double Science1 = Convert.ToDouble(Science.Text);
            double Filipino1 = Convert.ToDouble(Filipino.Text);
            double History1 = Convert.ToDouble(History.Text);

            double GenAve_1 = English1 + Math1 + Science1 + Filipino1 + History1;
            double GenAve_2 = GenAve_1 / 5;




            label8.Text = GenAve_2>= 75 ? "Student passed. \n The general average of " + name1 + " is " + GenAve_2 : "Student failed the exam. \n The general average of " + name1 + " is " + GenAve_2;
          

        }
    }
}
