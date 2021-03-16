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
            akjdslkn();
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




        private void akjdslkn()
        {


            foreach (var organ in Controller.OrgansList(1))
            {
                var tuple = Controller.LabelList(organ.Name, myLocationX, myLocationY);

                foreach (var item in tuple.Item1)
                {
                    this.Controls.Add(item);

                }
                foreach (var item in Controller.ComboBoxList(organ.Name, myLocationX + 250, myLocationY))
                {
                    this.Controls.Add(item);
                }

                myLocationY = tuple.Item2 + 40;
            }

            
        }





        private void button_Click(object sender, EventArgs e)
        {

        }

    }
}
