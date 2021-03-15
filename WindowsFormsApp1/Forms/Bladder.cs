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
        private int myLocationX = 10;
        private int myLocationY = 10;
        public Bladder(string surname, string name, string patronym, string birthday, string gender)
        {
            
            
            
            //var newButton = Controller.NewButton(100, 100, "SDBvljsdnl");
            //newButton.Click += new System.EventHandler(this.button_Click);
            //this.Controls.Add(newButton);
            //this.Controls.Add(Controller.NewLabel(100, 100, "SDBvljsdnl"));

            foreach (var item in Controller.LabelList("Печень", myLocationX, myLocationY))
            {
                this.Controls.Add(item);
            }
            foreach (var item in Controller.ComboBoxList("Печень", myLocationX, myLocationY))
            {
                this.Controls.Add(item);
            }

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
        private void button_Click(object sender, EventArgs e)
        {

        }

    }
}
