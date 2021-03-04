using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class AbdominalCavity : Form
    {
        public AbdominalCavity(string surname, string name, string patronym, string birthday, string gender)
        {
            InitializeComponent();
            this.Text = surname + " " + name + " " + patronym;
            SurnameValue.Text = surname;
            NameValue.Text = name;
            PatronymValue.Text = patronym;
            BirthdayValue.Text = birthday;
            GenderValue.Text = gender;
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

        private void BryPol_Load(object sender, EventArgs e)
        {

        }
    }
}
