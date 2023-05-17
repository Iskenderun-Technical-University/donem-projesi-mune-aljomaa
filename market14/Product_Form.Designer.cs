
namespace market14
{
    partial class Product_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLogo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCategoryNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogo.ImageRotate = 0F;
            this.btnLogo.ImageSize = new System.Drawing.Size(150, 150);
            this.btnLogo.Location = new System.Drawing.Point(-1, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.Size = new System.Drawing.Size(116, 112);
            this.btnLogo.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(12, 735);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.Location = new System.Drawing.Point(7, 242);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(108, 34);
            this.btnSelling.TabIndex = 13;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.Location = new System.Drawing.Point(7, 202);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(108, 34);
            this.btnCategories.TabIndex = 14;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnSellers
            // 
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellers.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellers.Location = new System.Drawing.Point(7, 162);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(108, 34);
            this.btnSellers.TabIndex = 11;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(1272, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(39, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(485, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Supermarket Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cbSearchCategory);
            this.panel1.Controls.Add(this.cbSelectCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductsDGV);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCategoryDescription);
            this.panel1.Controls.Add(this.txtCategoryNAME);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCategoryID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(174, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 703);
            this.panel1.TabIndex = 9;
            // 
            // ProductsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDGV.GridColor = System.Drawing.Color.Chocolate;
            this.ProductsDGV.Location = new System.Drawing.Point(444, 61);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.RowHeadersWidth = 51;
            this.ProductsDGV.RowTemplate.Height = 24;
            this.ProductsDGV.Size = new System.Drawing.Size(642, 627);
            this.ProductsDGV.TabIndex = 18;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.GridColor = System.Drawing.Color.Chocolate;
            this.ProductsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProductsDGV.ThemeStyle.ReadOnly = false;
            this.ProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.ProductsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(240, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(144, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(48, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryDescription.ForeColor = System.Drawing.Color.White;
            this.txtCategoryDescription.HintForeColor = System.Drawing.Color.Black;
            this.txtCategoryDescription.HintText = "";
            this.txtCategoryDescription.isPassword = false;
            this.txtCategoryDescription.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoryDescription.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryDescription.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoryDescription.LineThickness = 3;
            this.txtCategoryDescription.Location = new System.Drawing.Point(155, 162);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(264, 30);
            this.txtCategoryDescription.TabIndex = 13;
            this.txtCategoryDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCategoryNAME
            // 
            this.txtCategoryNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryNAME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryNAME.ForeColor = System.Drawing.Color.White;
            this.txtCategoryNAME.HintForeColor = System.Drawing.Color.Black;
            this.txtCategoryNAME.HintText = "";
            this.txtCategoryNAME.isPassword = false;
            this.txtCategoryNAME.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoryNAME.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryNAME.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoryNAME.LineThickness = 3;
            this.txtCategoryNAME.Location = new System.Drawing.Point(155, 114);
            this.txtCategoryNAME.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryNAME.Name = "txtCategoryNAME";
            this.txtCategoryNAME.Size = new System.Drawing.Size(264, 30);
            this.txtCategoryNAME.TabIndex = 12;
            this.txtCategoryNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryID.ForeColor = System.Drawing.Color.White;
            this.txtCategoryID.HintForeColor = System.Drawing.Color.Black;
            this.txtCategoryID.HintText = "";
            this.txtCategoryID.isPassword = false;
            this.txtCategoryID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoryID.LineIdleColor = System.Drawing.Color.White;
            this.txtCategoryID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoryID.LineThickness = 3;
            this.txtCategoryID.Location = new System.Drawing.Point(155, 76);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(264, 30);
            this.txtCategoryID.TabIndex = 9;
            this.txtCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage products";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(155, 227);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(264, 30);
            this.bunifuMaterialTextbox1.TabIndex = 20;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.BackColor = System.Drawing.Color.White;
            this.cbSelectCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(155, 308);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(264, 31);
            this.cbSelectCategory.TabIndex = 23;
            this.cbSelectCategory.Text = "Select Category";
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.BackColor = System.Drawing.Color.White;
            this.cbSearchCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSearchCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(713, 24);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(198, 31);
            this.cbSearchCategory.TabIndex = 24;
            this.cbSearchCategory.Text = "Select Category";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(917, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 33);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 791);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnSellers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSellers;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsDGV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryDescription;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.ComboBox cbSelectCategory;
    }
}