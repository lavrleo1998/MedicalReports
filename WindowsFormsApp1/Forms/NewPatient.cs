using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gender.SelectedItem == null)
            {
                MessageBox.Show("Не указан пол!");
            }
            else
            {
                var patient = new Patient(
                textBoxSurname.Text,
                textBoxName.Text,
                textBoxPatronym.Text,
                birthday.Value.Date,
                gender.SelectedItem.ToString()
                );
                patient.Show();
            }            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSurname.Text = null;
            textBoxName.Text = null;
            textBoxPatronym.Text = null;
            birthday.Value = DateTime.Now;
            gender.SelectedItem = null;
        }
    }
}
