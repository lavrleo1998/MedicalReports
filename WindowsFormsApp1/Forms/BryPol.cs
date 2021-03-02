using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class BryPol : Form
    {
        public BryPol()
        {
            InitializeComponent();
        }

        

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            int a=3;
            int b=4;
            int c;
            c = a + b;
            Controller.FillIn(comboBox1, label1);
            // Controller.FillIn(comboBox2, label2);
            //Controller.FillIn(comboBox3, label3);
            //Controller.FillIn(comboBox4, label4);
            //Controller.FillIn(comboBox5, 5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller.newTempl(richTextBox1.Text, label1);
            Controller.FillIn(comboBox1, label1);
        }

        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text = comboBox1.Text;
        }
    }
}
