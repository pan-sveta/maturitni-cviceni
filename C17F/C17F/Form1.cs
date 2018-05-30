using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17F
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GenerujTlacitka();
        }

        private void GenerujTlacitka()
        {
            int cislovani = 1;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Button tlacitko = new Button();
                    tlacitko.Width = 50;
                    tlacitko.Height = 50;
                    tlacitko.Click += new EventHandler(One_Click);
                    tlacitko.Left = x * 50;
                    tlacitko.Top = y * 50;
                    tlacitko.Text = (cislovani).ToString();

                    this.Controls.Add(tlacitko);
                    cislovani++;
                }
            }
        }

        private void One_Click(object sender, EventArgs e)
        {
            Button kliknuteTlacitko = sender as Button;
            this.Text = kliknuteTlacitko.Text;
        }
    }
}
