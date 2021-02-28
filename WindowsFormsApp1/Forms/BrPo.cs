using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Комплексное узи органов брюшной полости
    /// </summary>
    public partial class BrPo : Form
    {

        public BrPo()
        {
            InitializeComponent();
            Controller.newTempl("Еуче", 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Controller.newTempl("Еуче", 2);
        }
    }
}
