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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.newTempl(richTextBox1.Text, label1);
            Controller.FillIn(comboBox1, label1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Controller.FillIn(comboBox1, label1);
            // Controller.FillIn(comboBox2, label2);
            //Controller.FillIn(comboBox3, label3);
            //Controller.FillIn(comboBox4, label4);
            //Controller.FillIn(comboBox5, 5);
        }

    }
}
