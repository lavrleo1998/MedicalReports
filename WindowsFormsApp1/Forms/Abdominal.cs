using ODF;
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

        private void butSave_Click(object sender, EventArgs e)
        {
            string TestText = "";
            
            var PT = new List<string>();
            var organ = Liver.Text;
            PT.Add($"{labLiver1.Text}: {comLiver1.Text}");
            PT.Add($"{labLiver2.Text}: {comLiver2.Text}");
            PT.Add($"{labLiver3.Text}: {comLiver3.Text}");
            PT.Add($"{labLiver5.Text}: {comLiver5.Text}");
            PT.Add($"{labLiver6.Text}: {comLiver6.Text}");
            Class1.SaveODF(organ, PT);

            TestText += $"{Surname.Text}: {SurnameValue.Text}\n";
            TestText += $"{NameL.Text}: {NameValue.Text}\n";
            TestText += $"{Patronym.Text}: {PatronymValue.Text}\n";
            TestText += $"{Birthday.Text}: {BirthdayValue.Text}\n";
            TestText += $"{Gender.Text}: {GenderValue.Text}\n";

            TestText += Liver.Text + "\n";
            TestText += $"{labLiver1.Text}: {comLiver1.Text}\n";
            TestText += $"{labLiver2.Text}: {comLiver2.Text}\n";
            TestText += $"{labLiver3.Text}: {comLiver3.Text}\n";
            //TestText += $"{labLiver4.Text}: {comLiver4.Text}\n";
            TestText += $"{labLiver5.Text}: {comLiver5.Text}\n";
            TestText += $"{labLiver6.Text}: {comLiver6.Text}\n";
            TestText += $"{labLiver7.Text}: {comLiver7.Text}\n";
            TestText += $"{labLiver8.Text}: {comLiver8.Text}\n";
            TestText += $"{labLiver9.Text}: {comLiver9.Text}\n";
            TestText += $"{labLiver10.Text}: {comLiver10.Text}\n";
            TestText += $"{labLiver11.Text}: {comLiver11.Text}\n";
            TestText += $"{labLiver12.Text}: {comLiver12.Text}\n";
            TestText += $"{labLiver13.Text}: {comLiver13.Text}\n";

            TestText += Gallbladder.Text + "\n";
            TestText += $"{labGallbladder1.Text}: {comGallbladder1.Text}\n";
            TestText += $"{labGallbladder2.Text}: {comGallbladder2.Text}\n";
            //TestText += $"{labGallbladder3.Text}: {comGallbladder3.Text}\n";
            TestText += $"{labGallbladder4.Text}: {comGallbladder4.Text}\n";
            TestText += $"{labGallbladder5.Text}: {comGallbladder5.Text}\n";
            TestText += $"{labGallbladder6.Text}: {comGallbladder6.Text}\n";

            TestText += Pancreas.Text + "\n";
            TestText += $"{labPancreas1.Text}: {comPancreas1.Text}\n";
            //TestText += $"{labPancreas2.Text}: {comPancreas2.Text}\n";
            TestText += $"{labPancreas3.Text}: {comPancreas3.Text}\n";
            TestText += $"{labPancreas4.Text}: {comPancreas4.Text}\n";
            TestText += $"{labPancreas5.Text}: {comPancreas5.Text}\n";
            TestText += $"{labPancreas6.Text}: {comPancreas6.Text}\n";

            TestText += Spleen.Text + "\n";
            TestText += $"{labSpleen1.Text}: {comSpleen1.Text}\n";
            TestText += $"{labSpleen2.Text}: {comSpleen2.Text}\n";
            TestText += $"{labSpleen3.Text}: {comSpleen3.Text}\n";
            TestText += $"{labSpleen4.Text}: {comSpleen4.Text}\n";

            TestText += LymphNode.Text + "\n";
            TestText += $"{labLymphNode1.Text}: {comLymphNode1.Text}\n";

            TestText += Additionally.Text + "\n";
            TestText += $"{labAdditionally.Text}: {comAdditionally.Text}\n";

            TestText += Conclusion.Text + "\n";
            TestText += $"{labConclusion.Text}: {comConclusion.Text}\n";

            WordSave.WriteFile(TestText);
            MessageBox.Show("Файл добавлен.");

        }
        private void Filling()
        {
            Controller.FillIn(Liver, labLiver1, comLiver1);
            Controller.FillIn(Liver, labLiver2, comLiver2);
            Controller.FillIn(Liver, labLiver3, comLiver3);
            //////////////////////////////////////////////
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
            //Controller.FillIn(Gallbladder, labGallbladder3, comGallbladder3);
            Controller.FillIn(Gallbladder, labGallbladder4, comGallbladder4);
            Controller.FillIn(Gallbladder, labGallbladder5, comGallbladder5);
            Controller.FillIn(Gallbladder, labGallbladder6, comGallbladder6);

            Controller.FillIn(Pancreas, labPancreas1, comPancreas1);
            ///////////////////////////////////////////////////////
            Controller.FillIn(Pancreas, labPancreas3, comPancreas3);
            Controller.FillIn(Pancreas, labPancreas4, comPancreas4);
            Controller.FillIn(Pancreas, labPancreas5, comPancreas5);
            Controller.FillIn(Pancreas, labPancreas6, comPancreas6);

            Controller.FillIn(Spleen, labSpleen1, comSpleen1);
            Controller.FillIn(Spleen, labSpleen2, comSpleen2);
            Controller.FillIn(Spleen, labSpleen3, comSpleen3);
            Controller.FillIn(Spleen, labSpleen4, comSpleen4);

            Controller.FillIn(LymphNode, labLymphNode1, comLymphNode1);

            Controller.FillIn(Additionally, labAdditionally, comAdditionally);
            Controller.FillIn(Conclusion, labConclusion, comConclusion);
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
