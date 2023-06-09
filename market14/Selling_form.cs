﻿using System;
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
    public partial class Selling_Form : Form
    {
        public Selling_Form()
        {
            InitializeComponent();
        }
        int Grdtotal = 0, n = 0;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AL BARAA PC\OneDrive\Masaüstü\donem-projesi-mune-aljomaa\market14\SMMSMD.mdf;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from BillsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Selling_Form_Load(object sender, EventArgs e)
        {
           /* populate();
            populatebills();
            FillCategory();
            lblSellerName.Text = Login.Sellername;*/
        }

        private void btnAddProct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrdersDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtProductName.Text;
                newRow.Cells[2].Value = txtProductQuantity.Text;
                newRow.Cells[3].Value = txtProductPrice.Text;
                newRow.Cells[4].Value = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                OrdersDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                lblAmount.Text = "" + Grdtotal;
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            txtProductQuantity.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            lblDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        private void FillCategory()
        {
            //This Method will bind the Combobox with the Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoriesTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //cbSearchCategory.ValueMember = "CatName";
            //cbSearchCategory.DataSource = dt;
            cbSelectCategory.ValueMember = "CatName";
            cbSelectCategory.DataSource = dt;
            Con.Close();
        }
        private void PrintDocument_Printpage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Pacify SuperMaeket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));

            e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(180, 70));

            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));

            e.Graphics.DrawString("Bill Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));

            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));

            e.Graphics.DrawString("Pacify Technology", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(238, 230));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtBillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillsTbl values(" + txtBillID.Text + ",'" + lblSellerName.Text + "','" + lblDate.Text + "'," + lblAmount.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_Form sell = new Selling_Form();
            sell.Show();
            this.Hide();
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            Category_Form Cat = new Category_Form();
            Cat.Show();
            this.Hide();
        }
        private void btnSellers_Click(object sender, EventArgs e)
        {
            Seller_Form sell = new Seller_Form();
            sell.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

