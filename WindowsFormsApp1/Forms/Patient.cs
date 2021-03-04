using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Patient : Form
    {
        public Patient(string surname, string name, string patronym, DateTime birthday, string gender)
        {
            InitializeComponent();
            this.Text = surname + " " + name + " " + patronym;
            SurnameValue.Text = surname;
            NameValue.Text = name;
            PatronymValue.Text = patronym;
            BirthdayValue.Text = birthday.ToString();
            GenderValue.Text = gender;
            if (gender == "Мужской")
            {
                button6.Enabled = false;
            }
            if (gender == "Женский")
            {
                button5.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var abdominal = new AbdominalCavity(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            abdominal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kidneys = new Kidneys(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            kidneys.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bladder = new Bladder(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            bladder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var prostate = new Prostate(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            prostate.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var scrotum = new Scrotum(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            scrotum.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var milkGlands = new MilkGlands(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            milkGlands.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var thyroid = new Thyroid(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            thyroid.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var justUzi = new JustUzi(SurnameValue.Text, NameValue.Text, PatronymValue.Text, BirthdayValue.Text, GenderValue.Text);
            justUzi.Show();
        }
    }
}
