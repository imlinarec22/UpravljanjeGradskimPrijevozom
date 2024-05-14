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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnGost_Click(object sender, EventArgs e)
        {
            FrmGost gost = new FrmGost();
            gost.Show();
        }

        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            FrmZaposlenik zaposlenik = new FrmZaposlenik();
            zaposlenik.Show();
        }
    }
}
