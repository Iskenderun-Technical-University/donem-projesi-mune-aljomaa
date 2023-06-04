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
    public partial class Seller_Form : Form
    {
        public Seller_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL BARAA PC\OneDrive\Masaüstü\donem-projesi-mune-aljomaa\market14\SMMSMD.mdf;Integrated Security=True");
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtProductID_OnValueChanged(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellersTbl values(" + txtSellerID.Text + ",'" + txtSellerName.Text + "'," + txtSellerAge.Text + "," + txtSellerMobileNo.Text + "," + "," + txtSellerPossword.Text +  "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added successfully");
                Con.Close();
                populate();
                txtSellerID.Text = "";
                txtSellerName.Text = "";
                txtSellerAge.Text = "";
                txtSellerMobileNo.Text = "";
                txtSellerPossword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSellerID.Text == "" || txtSellerName.Text == "" || txtSellerAge.Text == "" || txtSellerMobileNo.Text == "" ||  txtSellerPossword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellersTbl set SellerName='" + txtSellerName.Text + "' , sellerAge =" + txtSellerAge.Text + ", sellerMobileNo=" + txtSellerMobileNo.Text + ", sellerPossword='" + txtSellerPossword.Text.ToString() + "'where ProdId=" + txtSellerID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerMobileNo.Text = "";
                    txtSellerPossword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSellerID.Text == "")
                {
                    MessageBox.Show("Select the Seller to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where prodld=" + txtSellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Seller deleted successfully");
                    Con.Close();
                    populate();
                    txtSellerID.Text = "";
                    txtSellerName.Text = "";
                    txtSellerAge.Text = "";
                    txtSellerMobileNo.Text = "";
                    txtSellerPossword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Seller_Form_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();
            sell.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product_Form prod = new Product_Form();
            prod.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Category_Form Cat = new Category_Form();
            Cat.Show();
            this.Hide();
        }
    }
}
