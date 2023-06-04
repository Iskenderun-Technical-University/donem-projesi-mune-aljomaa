
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbSearchCategory = new System.Windows.Forms.ComboBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buntxtProductPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductQuantily = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCtxtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogo.ImageRotate = 0F;
            this.btnLogo.ImageSize = new System.Drawing.Size(100, 100);
            this.btnLogo.Location = new System.Drawing.Point(12, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.Size = new System.Drawing.Size(116, 112);
            this.btnLogo.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(12, 735);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.Location = new System.Drawing.Point(7, 242);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(108, 34);
            this.btnSelling.TabIndex = 13;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.Location = new System.Drawing.Point(7, 202);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(108, 34);
            this.btnCategories.TabIndex = 14;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellers.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellers.Location = new System.Drawing.Point(7, 162);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(108, 34);
            this.btnSellers.TabIndex = 11;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = true;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(485, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 26);
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
            this.panel1.Controls.Add(this.buntxtProductPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductsDGV);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtProductQuantily);
            this.panel1.Controls.Add(this.txtCtxtProductName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(174, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 703);
            this.panel1.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(917, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 33);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.cbSearchCategoy_SelectionChangeCommittes);
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.BackColor = System.Drawing.Color.White;
            this.cbSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSearchCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSearchCategory.FormattingEnabled = true;
            this.cbSearchCategory.Location = new System.Drawing.Point(704, 27);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(198, 28);
            this.cbSearchCategory.TabIndex = 24;
            this.cbSearchCategory.Text = "Select Category";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.BackColor = System.Drawing.Color.White;
            this.cbSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(155, 308);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(264, 28);
            this.cbSelectCategory.TabIndex = 23;
            this.cbSelectCategory.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // buntxtProductPrice
            // 
            this.buntxtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buntxtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buntxtProductPrice.ForeColor = System.Drawing.Color.White;
            this.buntxtProductPrice.HintForeColor = System.Drawing.Color.Black;
            this.buntxtProductPrice.HintText = "";
            this.buntxtProductPrice.isPassword = false;
            this.buntxtProductPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.buntxtProductPrice.LineIdleColor = System.Drawing.Color.White;
            this.buntxtProductPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.buntxtProductPrice.LineThickness = 3;
            this.buntxtProductPrice.Location = new System.Drawing.Point(155, 237);
            this.buntxtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.buntxtProductPrice.Name = "buntxtProductPrice";
            this.buntxtProductPrice.Size = new System.Drawing.Size(264, 30);
            this.buntxtProductPrice.TabIndex = 20;
            this.buntxtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            // 
            // ProductsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDGV.GridColor = System.Drawing.Color.Chocolate;
            this.ProductsDGV.Location = new System.Drawing.Point(437, 63);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.RowHeadersWidth = 51;
            this.ProductsDGV.RowTemplate.Height = 24;
            this.ProductsDGV.Size = new System.Drawing.Size(660, 627);
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
            this.ProductsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProductsDGV.ThemeStyle.ReadOnly = false;
            this.ProductsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.ProductsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(292, 367);
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
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(186, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(73, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductQuantily
            // 
            this.txtProductQuantily.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuantily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductQuantily.ForeColor = System.Drawing.Color.White;
            this.txtProductQuantily.HintForeColor = System.Drawing.Color.Black;
            this.txtProductQuantily.HintText = "";
            this.txtProductQuantily.isPassword = false;
            this.txtProductQuantily.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductQuantily.LineIdleColor = System.Drawing.Color.White;
            this.txtProductQuantily.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductQuantily.LineThickness = 3;
            this.txtProductQuantily.Location = new System.Drawing.Point(155, 162);
            this.txtProductQuantily.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductQuantily.Name = "txtProductQuantily";
            this.txtProductQuantily.Size = new System.Drawing.Size(264, 30);
            this.txtProductQuantily.TabIndex = 13;
            this.txtProductQuantily.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCtxtProductName
            // 
            this.txtCtxtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCtxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCtxtProductName.ForeColor = System.Drawing.Color.White;
            this.txtCtxtProductName.HintForeColor = System.Drawing.Color.Black;
            this.txtCtxtProductName.HintText = "";
            this.txtCtxtProductName.isPassword = false;
            this.txtCtxtProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCtxtProductName.LineIdleColor = System.Drawing.Color.White;
            this.txtCtxtProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCtxtProductName.LineThickness = 3;
            this.txtCtxtProductName.Location = new System.Drawing.Point(155, 114);
            this.txtCtxtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCtxtProductName.Name = "txtCtxtProductName";
            this.txtCtxtProductName.Size = new System.Drawing.Size(264, 30);
            this.txtCtxtProductName.TabIndex = 12;
            this.txtCtxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductID.ForeColor = System.Drawing.Color.White;
            this.txtProductID.HintForeColor = System.Drawing.Color.Black;
            this.txtProductID.HintText = "";
            this.txtProductID.isPassword = false;
            this.txtProductID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductID.LineIdleColor = System.Drawing.Color.White;
            this.txtProductID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductID.LineThickness = 3;
            this.txtProductID.Location = new System.Drawing.Point(155, 76);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(264, 30);
            this.txtProductID.TabIndex = 9;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage products";
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductQuantily;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCtxtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buntxtProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbSearchCategory;
        private System.Windows.Forms.ComboBox cbSelectCategory;
    }
}