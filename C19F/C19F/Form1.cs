using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19F
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            Control prvek = (Button)sender;
            this.Text = string.Format("{0}", prvek.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            VypsatPrvky();
        }

        private void VypsatPrvky()
        {
            //Odpověď na otízku. Nějak takhle. Pomocí this.Controls ta obsahuje všechny konmtrolky na formuláři.
            //Tu můžem procházet třeba takhle krz foreach
            foreach (Control control in this.Controls)
            {
                //U textboxu musí být i to \r neptej se proč taky nevim
                txtMain.Text += control.Name + "\r\n";
            }
        }
    }
}
