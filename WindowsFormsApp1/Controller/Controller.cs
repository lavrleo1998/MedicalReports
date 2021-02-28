using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Controller
    {

        public static void FillIn(ComboBox combobox, long paramId)
        {
            var texts = TemplContr.GiveMeTemplTexts(paramId);
            combobox.DataSource = texts;
            combobox.DisplayMember = "Name";
            combobox.ValueMember = "";
            combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            combobox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public static void newTempl(string text, long paramId)
        {
            TemplContr.Add(text, paramId);
        }

        public static void Fill(ListView listView, long paramId)
        {
            var texts = TemplContr.GiveMeTemplTexts(paramId);
            Binding binding = new Binding("text1234", texts, "gjhk");
            foreach (var item in texts)
            {
                listView.Items.Add(item);
            }
        }

        public static void FillTextBox(TextBox textBox, long paramID)
        {
            

        }

        public static void FillUpDown(DomainUpDown domainUpDown, long paramId)
        {
            var texts = TemplContr.GiveMeTemplTexts(paramId);
            foreach (var item in texts)
            {
                domainUpDown.Items.Add(item);
            }
        }






    }
}
