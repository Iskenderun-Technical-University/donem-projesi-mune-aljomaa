
namespace market14
{
    partial class Selling_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnLogo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCtxtProductName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProductQuantily = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BillsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buntxtProductPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.OrdersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddProct = new System.Windows.Forms.Button();
            this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1292, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(39, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseTransparentBackground = true;
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.Location = new System.Drawing.Point(12, 306);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(108, 34);
            this.btnSelling.TabIndex = 16;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategories.Location = new System.Drawing.Point(12, 250);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(108, 34);
            this.btnCategories.TabIndex = 17;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnSellers
            // 
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellers.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellers.Location = new System.Drawing.Point(12, 196);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(108, 34);
            this.btnSellers.TabIndex = 15;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = true;
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
            this.btnLogo.Location = new System.Drawing.Point(12, 22);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogo.Size = new System.Drawing.Size(108, 104);
            this.btnLogo.TabIndex = 18;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(20, 655);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 34);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(520, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supermarket Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(571, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selling Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = " Bill ID\r\n";
            // 
            // txtBillID
            // 
            this.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillID.ForeColor = System.Drawing.Color.White;
            this.txtBillID.HintForeColor = System.Drawing.Color.Black;
            this.txtBillID.HintText = "";
            this.txtBillID.isPassword = false;
            this.txtBillID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBillID.LineIdleColor = System.Drawing.Color.White;
            this.txtBillID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBillID.LineThickness = 3;
            this.txtBillID.Location = new System.Drawing.Point(115, 76);
            this.txtBillID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(264, 30);
            this.txtBillID.TabIndex = 9;
            this.txtBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantily";
            // 
            // txtCtxtProductName
            // 
            this.txtCtxtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCtxtProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCtxtProductName.ForeColor = System.Drawing.Color.White;
            this.txtCtxtProductName.HintForeColor = System.Drawing.Color.Black;
            this.txtCtxtProductName.HintText = "";
            this.txtCtxtProductName.isPassword = false;
            this.txtCtxtProductName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCtxtProductName.LineIdleColor = System.Drawing.Color.White;
            this.txtCtxtProductName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCtxtProductName.LineThickness = 3;
            this.txtCtxtProductName.Location = new System.Drawing.Point(115, 114);
            this.txtCtxtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCtxtProductName.Name = "txtCtxtProductName";
            this.txtCtxtProductName.Size = new System.Drawing.Size(264, 30);
            this.txtCtxtProductName.TabIndex = 12;
            this.txtCtxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductQuantily
            // 
            this.txtProductQuantily.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductQuantily.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductQuantily.ForeColor = System.Drawing.Color.White;
            this.txtProductQuantily.HintForeColor = System.Drawing.Color.Black;
            this.txtProductQuantily.HintText = "";
            this.txtProductQuantily.isPassword = false;
            this.txtProductQuantily.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductQuantily.LineIdleColor = System.Drawing.Color.White;
            this.txtProductQuantily.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductQuantily.LineThickness = 3;
            this.txtProductQuantily.Location = new System.Drawing.Point(115, 162);
            this.txtProductQuantily.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductQuantily.Name = "txtProductQuantily";
            this.txtProductQuantily.Size = new System.Drawing.Size(264, 30);
            this.txtProductQuantily.TabIndex = 13;
            this.txtProductQuantily.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(519, 707);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 39);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPrint.Location = new System.Drawing.Point(654, 707);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 39);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(789, 707);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.BillsDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillsDGV.GridColor = System.Drawing.Color.Chocolate;
            this.BillsDGV.Location = new System.Drawing.Point(399, 442);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowHeadersWidth = 51;
            this.BillsDGV.RowTemplate.Height = 24;
            this.BillsDGV.Size = new System.Drawing.Size(733, 241);
            this.BillsDGV.TabIndex = 18;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.GridColor = System.Drawing.Color.Chocolate;
            this.BillsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillsDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.BillsDGV.ThemeStyle.ReadOnly = false;
            this.BillsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.BillsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            // 
            // buntxtProductPrice
            // 
            this.buntxtProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buntxtProductPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buntxtProductPrice.ForeColor = System.Drawing.Color.White;
            this.buntxtProductPrice.HintForeColor = System.Drawing.Color.Black;
            this.buntxtProductPrice.HintText = "";
            this.buntxtProductPrice.isPassword = false;
            this.buntxtProductPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.buntxtProductPrice.LineIdleColor = System.Drawing.Color.White;
            this.buntxtProductPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.buntxtProductPrice.LineThickness = 3;
            this.buntxtProductPrice.Location = new System.Drawing.Point(115, 232);
            this.buntxtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.buntxtProductPrice.Name = "buntxtProductPrice";
            this.buntxtProductPrice.Size = new System.Drawing.Size(264, 30);
            this.buntxtProductPrice.TabIndex = 20;
            this.buntxtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.BackColor = System.Drawing.Color.White;
            this.cbSelectCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(20, 374);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(241, 31);
            this.cbSelectCategory.TabIndex = 23;
            this.cbSelectCategory.Text = "Select Category";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(273, 374);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 33);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OrdersDGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.OrdersDGV.ColumnHeadersHeight = 30;
            this.OrdersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quantily,
            this.Total});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.OrdersDGV.GridColor = System.Drawing.Color.Chocolate;
            this.OrdersDGV.Location = new System.Drawing.Point(399, 95);
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.RowHeadersVisible = false;
            this.OrdersDGV.RowHeadersWidth = 51;
            this.OrdersDGV.RowTemplate.Height = 24;
            this.OrdersDGV.Size = new System.Drawing.Size(733, 223);
            this.OrdersDGV.TabIndex = 26;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrdersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.GridColor = System.Drawing.Color.Chocolate;
            this.OrdersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrdersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrdersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrdersDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.OrdersDGV.ThemeStyle.ReadOnly = false;
            this.OrdersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrdersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrdersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrdersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.OrdersDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OrdersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrdersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "ProdID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantily
            // 
            this.Quantily.HeaderText = "Quantily";
            this.Quantily.MinimumWidth = 6;
            this.Quantily.Name = "Quantily";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblSellerName);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddProct);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.OrdersDGV);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cbSelectCategory);
            this.panel1.Controls.Add(this.buntxtProductPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtProductQuantily);
            this.panel1.Controls.Add(this.txtCtxtProductName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBillID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(150, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 778);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.BackColor = System.Drawing.Color.DarkOrange;
            this.lblSellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellerName.ForeColor = System.Drawing.Color.White;
            this.lblSellerName.Location = new System.Drawing.Point(3, 8);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(128, 23);
            this.lblSellerName.TabIndex = 33;
            this.lblSellerName.Text = "Seller Name\r\n";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DarkOrange;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1039, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 23);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Date\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkOrange;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(693, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sells List\r\n";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.DarkOrange;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(780, 330);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(37, 23);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = " Rs\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(650, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Amount Rs\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAddProct
            // 
            this.btnAddProct.BackColor = System.Drawing.Color.White;
            this.btnAddProct.FlatAppearance.BorderSize = 0;
            this.btnAddProct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProct.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProct.Location = new System.Drawing.Point(82, 292);
            this.btnAddProct.Name = "btnAddProct";
            this.btnAddProct.Size = new System.Drawing.Size(257, 50);
            this.btnAddProct.TabIndex = 28;
            this.btnAddProct.Text = "Add product";
            this.btnAddProct.UseVisualStyleBackColor = false;
            this.btnAddProct.Click += new System.EventHandler(this.btnAddProct_Click);
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.ProdDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.ProdDGV.GridColor = System.Drawing.Color.Chocolate;
            this.ProdDGV.Location = new System.Drawing.Point(20, 426);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.RowTemplate.Height = 24;
            this.ProdDGV.Size = new System.Drawing.Size(359, 312);
            this.ProdDGV.TabIndex = 27;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.Chocolate;
            this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProdDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProdDGV.ThemeStyle.ReadOnly = false;
            this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.ProdDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // Selling_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 823);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnSellers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Selling_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling_form";
            this.Load += new System.EventHandler(this.Selling_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSellers;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBillID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCtxtProductName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductQuantily;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView BillsDGV;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buntxtProductPrice;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersDGV;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddProct;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}