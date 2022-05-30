using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrindView
{
    public partial class Form2 : Form
    {
        public string value;
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets value of value.
        /// </summary>
        public void setValue()
        {
            this.value = textBoxCtrlE.Text;
        }
        public string getValue()
        {
            return value;
        }
        /// <summary>
        /// Occurs when Save button is clicked. Sets value of value with text box value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCtrlESave_Click(object sender, EventArgs e)
        {
            setValue();
        }
    }
}
