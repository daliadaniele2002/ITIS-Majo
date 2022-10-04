using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TtypeComboBox.SelectedIndex = 0;
        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar < Keys.D0 || (Keys)e.KeyChar > Keys.D9)
            {
                e.Handled = true;
            }
        }
    }
}
