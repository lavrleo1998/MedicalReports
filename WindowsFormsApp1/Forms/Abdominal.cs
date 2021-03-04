using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Abdominal : Form
    {
        public Abdominal(string surname, string name, string patronym, string birthday, string gender)
        {
            InitializeComponent();
            this.Text = surname + " " + name + " " + patronym;
            SurnameValue.Text = surname;
            NameValue.Text = name;
            PatronymValue.Text = patronym;
            BirthdayValue.Text = birthday;
            GenderValue.Text = gender;
            Filling();
        }

        private void Filling()
        {
            Controller.FillIn(Liver, labLiver1, comLiver1);
            Controller.FillIn(Liver, labLiver2, comLiver2);
            Controller.FillIn(Liver, labLiver3, comLiver3);
            Controller.FillIn(Liver, labLiver4, comLiver4);
            Controller.FillIn(Liver, labLiver5, comLiver5);
            Controller.FillIn(Liver, labLiver6, comLiver6);
            Controller.FillIn(Liver, labLiver7, comLiver7);
            Controller.FillIn(Liver, labLiver8, comLiver8);
            Controller.FillIn(Liver, labLiver9, comLiver9);
            Controller.FillIn(Liver, labLiver10, comLiver10);
            Controller.FillIn(Liver, labLiver11, comLiver11);
            Controller.FillIn(Liver, labLiver12, comLiver12);
            Controller.FillIn(Liver, labLiver13, comLiver13);

            Controller.FillIn(Gallbladder, labGallbladder1, comGallbladder1);
            Controller.FillIn(Gallbladder, labGallbladder2, comGallbladder2);
            Controller.FillIn(Gallbladder, labGallbladder3, comGallbladder3);
            Controller.FillIn(Gallbladder, labGallbladder4, comGallbladder4);
            Controller.FillIn(Gallbladder, labGallbladder5, comGallbladder5);
            Controller.FillIn(Gallbladder, labGallbladder6, comGallbladder6);

            Controller.FillIn(Pancreas, labPancreas1, comPancreas1);
            Controller.FillIn(Pancreas, labPancreas2, comPancreas2);
            Controller.FillIn(Pancreas, labPancreas3, comPancreas3);
            Controller.FillIn(Pancreas, labPancreas4, comPancreas4);
            Controller.FillIn(Pancreas, labPancreas5, comPancreas5);
            Controller.FillIn(Pancreas, labPancreas6, comPancreas6);

            Controller.FillIn(Spleen, labSpleen1, comSpleen1);
            Controller.FillIn(Spleen, labSpleen2, comSpleen2);
            Controller.FillIn(Spleen, labSpleen3, comSpleen3);
            Controller.FillIn(Spleen, labSpleen4, comSpleen4);

            Controller.FillIn(LymphNode, labLymphNode1, comLymphNode1);
        }

        private void butLiver1_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver1.Text, labLiver1);
            Controller.FillIn(Liver, labLiver1, comLiver1);
        }

        private void butLiver2_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver2.Text, labLiver2);
            Controller.FillIn(Liver, labLiver2, comLiver2);
        }

        private void butLiver3_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver3.Text, labLiver3);
            Controller.FillIn(Liver, labLiver3, comLiver3);
        }

        private void butLiver4_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver4.Text, labLiver4);
            Controller.FillIn(Liver, labLiver4, comLiver4);
        }

        private void butLiver5_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver5.Text, labLiver5);
            Controller.FillIn(Liver, labLiver5, comLiver5);
        }

        private void butLiver6_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver6.Text, labLiver6);
            Controller.FillIn(Liver, labLiver6, comLiver6);
        }

        private void butLiver7_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver7.Text, labLiver7);
            Controller.FillIn(Liver, labLiver7, comLiver7);
        }

        private void butLiver8_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver8.Text, labLiver8);
            Controller.FillIn(Liver, labLiver8, comLiver8);
        }

        private void butLiver9_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver9.Text, labLiver9);
            Controller.FillIn(Liver, labLiver9, comLiver9);
        }

        private void butLiver10_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver10.Text, labLiver10);
            Controller.FillIn(Liver, labLiver10, comLiver10);
        }
        private void butLiver11_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver11.Text, labLiver11);
            Controller.FillIn(Liver, labLiver11, comLiver11);
        }
        private void butLiver12_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver12.Text, labLiver12);
            Controller.FillIn(Liver, labLiver12, comLiver12);
        }

        private void butLiver13_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Liver, comLiver13.Text, labLiver13);
            Controller.FillIn(Liver, labLiver13, comLiver13);
        }

        private void butGallbladder1_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder1.Text, labGallbladder1);
            Controller.FillIn(Gallbladder, labGallbladder1, comGallbladder1);
        }

        private void butGallbladder2_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder2.Text, labGallbladder2);
            Controller.FillIn(Gallbladder, labGallbladder2, comGallbladder2);
        }

        private void butGallbladder3_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder3.Text, labGallbladder3);
            Controller.FillIn(Gallbladder, labGallbladder3, comGallbladder3);
        }

        private void butGallbladder4_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder4.Text, labGallbladder4);
            Controller.FillIn(Gallbladder, labGallbladder4, comGallbladder4);
        }

        private void butGallbladder5_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder5.Text, labGallbladder5);
            Controller.FillIn(Gallbladder, labGallbladder5, comGallbladder5);
        }

        private void butGallbladder6_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Gallbladder, comGallbladder6.Text, labGallbladder6);
            Controller.FillIn(Gallbladder, labGallbladder6, comGallbladder6);
        }

        private void butPancreas1_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas1.Text, labPancreas1);
            Controller.FillIn(Pancreas, labPancreas1, comPancreas1);
        }

        private void butPancreas2_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas2.Text, labPancreas2);
            Controller.FillIn(Pancreas, labPancreas2, comPancreas2);
        }

        private void butPancreas3_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas3.Text, labPancreas3);
            Controller.FillIn(Pancreas, labPancreas3, comPancreas3);
        }

        private void butPancreas4_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas4.Text, labPancreas4);
            Controller.FillIn(Pancreas, labPancreas4, comPancreas4);
        }

        private void butPancreas5_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas5.Text, labPancreas5);
            Controller.FillIn(Pancreas, labPancreas5, comPancreas5);
        }

        private void butPancreas6_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Pancreas, comPancreas6.Text, labPancreas6);
            Controller.FillIn(Pancreas, labPancreas6, comPancreas6);
        }

        private void butSpleen1_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Spleen, comSpleen1.Text, labSpleen1);
            Controller.FillIn(Spleen, labSpleen1, comSpleen1);
        }

        private void butSpleen2_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Spleen, comSpleen2.Text, labSpleen2);
            Controller.FillIn(Spleen, labSpleen2, comSpleen2);
        }

        private void butSpleen3_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Spleen, comSpleen3.Text, labSpleen3);
            Controller.FillIn(Spleen, labSpleen3, comSpleen3);
        }

        private void butSpleen4_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(Spleen, comSpleen4.Text, labSpleen4);
            Controller.FillIn(Spleen, labSpleen4, comSpleen4);
        }

        private void butLymphNode1_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(LymphNode, comLymphNode1.Text, labLymphNode1);
            Controller.FillIn(LymphNode, labLymphNode1, comLymphNode1);
        }

        private void butAdditionally_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(labAdditionally, comAdditionally.Text, labAdditionally);
        }

        private void butConclusion_Click(object sender, EventArgs e)
        {
            Controller.NewTempl(labConclusion, comConclusion.Text, labConclusion);
        }
    }
}
