using ODF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Word : Form
    {
        public Word()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new List<string>();
            d.Add("Параметр" + ": " +"Шаблон");
            d.Add("Параметр2" + ": " + "Шаблон");
            d.Add("Параметр3" + ": " + "Шаблон");
            d.Add("Параметр4" + ": " + "Шаблон");
            d.Add("Параметр5" + ": " + "Шаблон");
            d.Add("Параметр6" + ": " + "Шаблон");
            Class1.SaveODF("Орган",d);
        }
    }
}
