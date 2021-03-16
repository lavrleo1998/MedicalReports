using Domain;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Controller
    {
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly IOrganService OrganService = scope.GetRequiredService<IOrganService>();

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



        public static List<Organ> OrgansList(int examId)
        {
            var organList = OrganService.GetAllByExam(examId);
            return organList;
        }



        public static (List<Label>,int) LabelList(string organName, int myLocationX, int myLocationY)
        {
            var paramList = ParamContr.GetParamsByOrgan(organName);
            var labelList = new List<Label>();
            foreach (var item in paramList)
            {
                labelList.Add(Controller.NewLabel(myLocationX, myLocationY += 25, item.Name));
            }

            var result = (labelList, myLocationY);
            return result;
        }

        public static List<ComboBox> ComboBoxList(string organName, int myLocationX, int myLocationY)
        {
            var comboBoxList = new List<ComboBox>();

            var paramList = ParamContr.GetParamsByOrgan(organName);
            
            foreach (var param in paramList)
            {
                var protParmId = ParamContr.FindParamByName2(organName, param.Name);
                var texts = TemplContr.GiveMeTemplTexts(protParmId);

                var newComboBox = NewComboBox(myLocationX, myLocationY += 25, param.Name);
                newComboBox.DataSource = texts;
                newComboBox.DisplayMember = "Name";
                newComboBox.ValueMember = "";

                comboBoxList.Add(newComboBox);
            }
            return comboBoxList;
        }



        public static Label NewLabel(int myLocationX, int myLocationY, string labText)
        {
            var newLabel = new Label
            {
                Location = new Point(myLocationX, myLocationY),
                Enabled = true,
                Visible = true,
                Name = $"{labText}LabName",
                AutoSize = true,
                //newLabel.Size = new Size(75, 23);
                Text = labText
            };
            return newLabel;
        }

        public static Button NewButton(int myLocationX, int myLocationY, string butText)
        {

            var newButton = new Button
            {
                Location = new Point(myLocationX, myLocationY),
                Enabled = true,
                Visible = true,
                Name = $"{butText}ButName",
                Size = new Size(75, 23),
                Text = butText,
                UseVisualStyleBackColor = true
            };
            return newButton;
        }

        public static ComboBox NewComboBox(int myLocationX, int myLocationY, string name)
        {

            var newComboBox = new ComboBox
            {
                Location = new Point(myLocationX, myLocationY),
                Enabled = true,
                Visible = true,
                Name = $"{name}ComboName",
                Size = new Size(500, 23)
            };
            return newComboBox;
        }





    }
}
