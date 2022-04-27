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
    public partial class frmEditProforma : Form
    {
        public frmEditProforma()
        {
            InitializeComponent();
        }

        private void frmEditProforma_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 350);
        }

        private void btnEditExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
