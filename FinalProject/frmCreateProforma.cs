using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmCreateProforma : Form
    {
        public frmCreateProforma()
        {
            InitializeComponent();
            cmbProforma1.Items.Add("BG");
            cmbProforma1.Items.Add("BK");
            cmbProforma1.Items.Add("BS");
            cmbProforma1.Items.Add("BT");
            cmbProforma1.Items.Add("MY");
            cmbProforma1.Items.Add("PT");
            cmbProforma1.Items.Add("TB");



            cmbProforma2.Items.Add("AK");
            cmbProforma2.Items.Add("AT");
            cmbProforma2.Items.Add("BM");
            cmbProforma2.Items.Add("MG");
            cmbProforma2.Items.Add("MR");
            cmbProforma2.Items.Add("MZ");
            cmbProforma2.Items.Add("NN");
            cmbProforma2.Items.Add("RZ");
            cmbProforma2.Items.Add("SF");
            cmbProforma2.Items.Add("SH");



            cmbLoadingDate.Items.Add("JANUARY");
            cmbLoadingDate.Items.Add("FEBRUARY");
            cmbLoadingDate.Items.Add("MARCH");
            cmbLoadingDate.Items.Add("APRIL");
            cmbLoadingDate.Items.Add("MAY");
            cmbLoadingDate.Items.Add("JUNE");
            cmbLoadingDate.Items.Add("JULY");
            cmbLoadingDate.Items.Add("AUGUST");
            cmbLoadingDate.Items.Add("SEPTEMBER");
            cmbLoadingDate.Items.Add("OCTOBER");
            cmbLoadingDate.Items.Add("NOVEMBER");
            cmbLoadingDate.Items.Add("DECEMBER");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
