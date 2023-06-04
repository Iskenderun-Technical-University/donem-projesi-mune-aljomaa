using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace market14
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Sellername = "";

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL BARAA PC\OneDrive\Masaüstü\donem-projesi-mune-aljomaa\market14\SMMSMD.mdf;Integrated Security=True");


        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {

                MessageBox.Show("please enter the Username and password");

            }
            else
            {

                if (cbSelectRole.SelectedIndex > -1)
                {

                    if (cbSelectRole.SelectedItem.ToString() == "Admin")
                    {

                        if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
                        {

                            Product_Form prod = new Product_Form();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("İf you are Admin,Enter the Correct username username and password");
                        }
                    }
                    else
                    {
                        //messageBox.Show ("you are in the seller section");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM SellersTbl WHERE sellerName ='" + txtUsername.Text + "' and sellerPassword='" + txtPassword.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = txtUsername.Text;
                            Selling_Form sell = new Selling_Form();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and Password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to login");

                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void cbSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
