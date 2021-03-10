using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Bladder : Form
    {
        public Bladder(string surname, string name, string patronym, string birthday, string gender)
        {
            InitializeComponent();
            /*
            this.Text = surname + " " + name + " " + patronym;
            SurnameValue.Text = surname;
            NameValue.Text = name;
            PatronymValue.Text = patronym;
            BirthdayValue.Text = birthday;
            GenderValue.Text = gender;
           */

        }

        public void NewButton()
        {
            var newButton = new Button();
            newButton.Location = new Point(100, 100);
            newButton.Enabled = true;
            newButton.Visible = true;
            newButton.Name = "butsdfg1";
            newButton.Size = new Size(75, 23);
            newButton.TabIndex = 45;
            newButton.Text = "bugdfgdhn1";
            newButton.UseVisualStyleBackColor = true;
            this.Controls.Add(newButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewButton();
        }
    }
}
