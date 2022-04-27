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
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class frmLogin : Form
    {
        //SqlConnection con = new SqlConnection();
        //SqlCommand com = new SqlCommand();
        public frmLogin()
        {
            InitializeComponent();
            //con.ConnectionString = @"Data Source=(local);Initial Catalog=ProformaBoloor;Integrated Security=True";
            cmbCompanyName.Items.Add("Bolour Shisheh Taban");
            cmbCompanyName.Items.Add("Bolour Kaveh");
            cmbCompanyName.Items.Add("Tose-e Bolour");
            cmbCompanyName.Items.Add("Shisheh Mazrof Yazd");
            cmbCompanyName.Items.Add("Iran Tool");
            cmbCompanyName.Items.Add("Shisheh Jam");
        }


        public Employee SelectedCompany
        {
            get
            {
                return (Employee)cmbCompanyName.SelectedItem;
            }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login Form ";
            this.BackColor = Color.GhostWhite;
            this.Size = new Size(350, 300);
            this.Location = new Point(750, 350);
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();

            //con.Open();
            //com.Connection = con;
            //com.CommandText = "Select * from AUTH";
            //SqlDataReader dr = com.ExecuteReader();
            //if(dr.Read())
            //{
            //    if (txtUserName.Text.Equals (dr["UserName"].ToString()) && txtPassword.Text.Equals(dr["Password"].ToString()))
            //    {
            //        MessageBox.Show("Login Successfully", "Congrates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Either your username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //con.Close();
        }
    }
}
