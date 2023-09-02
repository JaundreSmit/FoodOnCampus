using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOnCampus
{
    public partial class frmDriverMenu : Form
    {
        public frmDriverMenu()
        {
            InitializeComponent();
        }

        private void frmDriverMenu_Load(object sender, EventArgs e)
        {
            //Functionality Overview:

            //Drivers kan hier alles orders sien wat "Order Placed" status is en kies om een te accept.
            //Die order status word dan "Accepted"
            //Generate n google maps link wat die longitude en latitude kry van die order se Delivery Point en dit vir die driver gee om te gebruik
            //n Driver kan die order wat hy accept het ook complete merk, dan verander die status na "Completed"
        }
    }
}
