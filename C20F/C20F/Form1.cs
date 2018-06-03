using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20F
{
    public partial class Form1 : Form
    {
        //VELEDŮLEŽITÉ!!! Když pokládáte tento textbox, vlastnost modifiers je nutno nastavit na public!

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonec_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPredat_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
