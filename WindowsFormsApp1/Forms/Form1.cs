using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.newTempl(richTextBox1.Text, 1);
            Controller.FillIn(comboBox1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Controller.FillIn(comboBox1, 1);
            Controller.FillIn(comboBox2, 2);
            Controller.FillIn(comboBox3, 3);
            Controller.FillIn(comboBox4, 4);
            Controller.FillIn(comboBox5, 5);
        }
    }
}
