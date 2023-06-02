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
    public partial class Category_form : Form
    {
        public Category_form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\AL BARAA PC\OneDrive\Masaüstü\donem-projesi-mune-aljomaa\market14\SMMSMD.mdf';Integrated Security=True");

        private void txtpassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = CategoriesDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtCategoryNAME.Text = CategoriesDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtCategoryDescription.Text = CategoriesDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoriesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoriesDGV.DataSource = ds.Tables[0];
            Con.Close();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoriesTbl values(" + txtCategoryID.Text + ",'" + txtCategoryNAME.Text + "','" + txtCategoryDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                txtCategoryID.Text = "";
                txtCategoryNAME.Text = "";
                txtCategoryDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {


                if (txtCategoryID.Text == "" || txtCategoryNAME.Text == "" || txtCategoryDescription.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoriesTbl set CatName='" + txtCategoryNAME.Text + "',CatDesc='" + txtCategoryDescription.Text + "' where CatId=" + txtCategoryID.Text + "";
                   
                        SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been updated Successfully");
                    Con.Close();
                    populate();
                    txtCategoryID.Text = "";
                    txtCategoryNAME.Text = "";
                    txtCategoryDescription.Text = "";
                } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } } 

        private void Category_form_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCategoryID.Text == "")
                {
                    MessageBox.Show("Select Category Id to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoriesTbl where CatId=" + txtCategoryID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted successfully");
                    Con.Close();
                    populate();
                    txtCategoryID.Text = "";
                    txtCategoryNAME.Text = "";
                    txtCategoryDescription.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void btnSellers_Click(object sender, EventArgs e)
        {
            Seller_Form Sell = new Seller_Form();
            Sell.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product_Form prod = new Product_Form();
            prod.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_form sell = new Selling_form();
            sell.Show();
            this.Hide();
        }
    }
  
}
