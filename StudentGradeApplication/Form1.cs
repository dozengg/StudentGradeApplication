using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentname = button1.Text;
            double enggrade = Convert.ToDouble(englishbox.Text);
            double mathgrade = Convert.ToDouble(mathbox.Text);
            double filgrade = Convert.ToDouble(filipinobox.Text);
            double scigrade = Convert.ToDouble(sciencebox.Text);
            double hisgrade = Convert.ToDouble(historybox.Text);


            double finalgrade = enggrade + mathgrade + filgrade + scigrade + hisgrade;

            double avegrade = finalgrade / 5;

            result.Text = avegrade >= 75 ? "The Student is pass. The general avarage is" + avegrade :  "The Student is Fail.The general averahe is" + avegrade;
               
               
              




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fingrade_Click(object sender, EventArgs e)
        {

        }
    }
}
