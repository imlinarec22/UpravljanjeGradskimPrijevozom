using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeGradskimPrijevozom
{
    public partial class FrmZaposlenik : Form
    {
        public FrmZaposlenik()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
