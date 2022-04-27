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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            CustomizeDisign();
        }

        private Form activeForm = null;
        public void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(ChildForm);
            pnlChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        

        private void CustomizeDisign()
        {
            pnlNewInformations.Visible = false;
            pnlSystemManagment.Visible = false;
        }
        private void HidesubMenu()
        {
            if (pnlNewInformations.Visible == true)
                pnlNewInformations.Visible = false;
            if (pnlSystemManagment.Visible == true)
                pnlSystemManagment.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HidesubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnNewInformation_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlNewInformations);
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }


        private void btnCity_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnCustomerAddress_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnCustomerName_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnDeliveryTerm_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImportNewInformation());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnNoOfCortons_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnPacking_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnPeymentTerm_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnSystemManagment_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSystemManagment);
        }

        private void btnUserManagment_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnChangeCompany_Click(object sender, EventArgs e)
        {
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnCreateProforma_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCreateProforma());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditProforma_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEditProforma());
            //..
            //Code
            //..
            HidesubMenu();
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            pnlChildForm.Dock = DockStyle.Fill;
        }


        //private Form activeForm = null;
        //private void openChildForm(Form ChildForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = ChildForm;
        //    ChildForm.TopLevel = false;
        //    ChildForm.FormBorderStyle = FormBorderStyle.None;
        //    ChildForm.Dock = DockStyle.Fill;
        //    pnlChildForm.Controls.Add(ChildForm);
        //    pnlChildForm.Tag = ChildForm;
        //    ChildForm.BringToFront();
        //    ChildForm.Show();
        //}
    }
}
