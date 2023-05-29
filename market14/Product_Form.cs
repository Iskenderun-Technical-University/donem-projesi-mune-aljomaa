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
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL BARAA PC\OneDrive\Masaüstü\donem - projesi - mune - aljomaa\market14\SMMSMD.mdf;Integrated Security=True");
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductsTbl values(" + txtProductID.Text + ",'" + txtCtxtProductName.Text + "'," + txtProductQuantily.Text + "," + buntxtProductPrice.Text + "," + cbSelectCategory.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added successfully");
                Con.Close);
                populate();
                txtProductID.Text = "";
                txtCtxtProductName.Text = "";
                txtProductQuantily.Text = "";
                buntxtProductPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Fillcategory()
        {//This Method will bind the combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            cbSearchCategory.ValueMember = "CatName";
            cbSearchCategory.DataSource = dt;
            cbSelectCategory.ValueMember = "CatName";
            cbSelectCategory.DataSource = dt;
            Con.Close(); }
        private void pogulate() {
            Con.Open();
            string query = "select * from ProductsTbI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close(); }
        private void Product_Form_Load(object sender, EventArgs e)
        {

            Fillcategory();
            populate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = ProductsDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtCtxtProductName.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtProductQuantily.Text = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
            buntxtProductPrice.Text = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
            cbSearchCategory.SelectedValue = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

    }
}
