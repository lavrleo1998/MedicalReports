using Domain;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Controller
    {

        public static void FillIn(Label organName, Label param, ComboBox templ)
        {
            var protParmId = ParamContr.FindParamByName(organName, param);
            var texts = TemplContr.GiveMeTemplTexts(protParmId);
            templ.DataSource = texts;
            templ.DisplayMember = "Name";
            templ.ValueMember = "";
        }

        public static void NewTempl(Label organName, string text, Label label)
        {
            var protParmId = ParamContr.FindParamByName(organName, label);
            TemplContr.Add(text, protParmId);
        }


        public static List<Label> LabelList(string organName, int myLocationX, int myLocationY)
        {
            var paramList = ParamContr.GetParamsByOrgan(organName);
            var labelList = new List<Label>();
            foreach (var item in paramList)
            {
                labelList.Add(Controller.NewLabel(myLocationX, myLocationY+=25, item.Name));
            }
            return labelList;
        }

        public static List<ComboBox> ComboBoxList(string organName, int myLocationX, int myLocationY)
        {
            var comboBoxList = new List<ComboBox>();

            var paramList = ParamContr.GetParamsByOrgan(organName);
            
            foreach (var param in paramList)
            {
                var protParmId = ParamContr.FindParamByName2(organName, param.Name);
                var texts = TemplContr.GiveMeTemplTexts(protParmId);

                var newComboBox = Controller.NewComboBox(myLocationX, myLocationY += 25, param.Name);
                newComboBox.DataSource = texts;
                newComboBox.DisplayMember = "Name";
                newComboBox.ValueMember = "";

                comboBoxList.Add(newComboBox);
            }
            return comboBoxList;
        }



        public static Label NewLabel(int myLocationX, int myLocationY, string labText)
        {
            var newLabel = new Label();
            newLabel.Location = new Point(myLocationX, myLocationY);
            newLabel.Enabled = true;
            newLabel.Visible = true;
            newLabel.Name = $"{labText}LabName";
            newLabel.AutoSize = true;
            //newLabel.Size = new Size(75, 23);
            newLabel.Text = labText;
            return newLabel;
        }

        public static Button NewButton(int myLocationX, int myLocationY, string butText)
        {

            var newButton = new Button();
            newButton.Location = new Point(myLocationX + 10, myLocationY + 25);
            newButton.Enabled = true;
            newButton.Visible = true;
            newButton.Name = $"{butText}ButName";
            newButton.Size = new Size(75, 23);
            newButton.Text = butText;
            newButton.UseVisualStyleBackColor = true;
            return newButton;
        }

        public static ComboBox NewComboBox(int myLocationX, int myLocationY, string name)
        {

            var newComboBox = new ComboBox();
            newComboBox.Location = new Point(myLocationX + 10, myLocationY + 25);
            newComboBox.Enabled = true;
            newComboBox.Visible = true;
            newComboBox.Name = $"{name}ComboName";
            newComboBox.Size = new Size(75, 23);
            return newComboBox;
        }





    }
}
