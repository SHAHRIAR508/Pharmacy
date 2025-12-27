namespace Pharmacy_Management_System
{
    partial class add
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNamber = new System.Windows.Forms.Label();
            this.lblAddras = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(816, 99);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 47);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(816, 172);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 47);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(816, 246);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 47);
            this.btnClear.TabIndex = 57;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(816, 320);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(225, 47);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(816, 25);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(225, 47);
            this.btnLogout.TabIndex = 55;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.price,
            this.quantity,
            this.category});
            this.dgvProductList.Location = new System.Drawing.Point(77, 422);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(964, 251);
            this.dgvProductList.TabIndex = 54;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "id";
            this.productId.HeaderText = " ID";
            this.productId.MinimumWidth = 8;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 150;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = " Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "number";
            this.price.HeaderText = "Number";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "addras";
            this.quantity.HeaderText = "Addras";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 150;
            // 
            // category
            // 
            this.category.DataPropertyName = "titel";
            this.category.HeaderText = "Titel";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(267, 348);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(452, 27);
            this.txtSearch.TabIndex = 53;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(72, 358);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 20);
            this.lblSearch.TabIndex = 52;
            this.lblSearch.Text = "Search";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Manager",
            "Employ"});
            this.cmbCategory.Location = new System.Drawing.Point(267, 271);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(452, 28);
            this.cmbCategory.TabIndex = 51;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(72, 281);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(45, 20);
            this.lblTitel.TabIndex = 50;
            this.lblTitel.Text = "Titel";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(267, 86);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(452, 27);
            this.txtProductName.TabIndex = 49;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(267, 148);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(452, 27);
            this.txtPrice.TabIndex = 48;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(267, 209);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(452, 27);
            this.txtQuantity.TabIndex = 47;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(72, 96);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name";
            // 
            // lblNamber
            // 
            this.lblNamber.AutoSize = true;
            this.lblNamber.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamber.Location = new System.Drawing.Point(72, 158);
            this.lblNamber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamber.Name = "lblNamber";
            this.lblNamber.Size = new System.Drawing.Size(73, 20);
            this.lblNamber.TabIndex = 45;
            this.lblNamber.Text = "Number";
            // 
            // lblAddras
            // 
            this.lblAddras.AutoSize = true;
            this.lblAddras.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddras.Location = new System.Drawing.Point(72, 219);
            this.lblAddras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddras.Name = "lblAddras";
            this.lblAddras.Size = new System.Drawing.Size(65, 20);
            this.lblAddras.TabIndex = 44;
            this.lblAddras.Text = "Addras";
            this.lblAddras.UseMnemonic = false;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(267, 25);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(452, 27);
            this.txtProductID.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(72, 35);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "ID";
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 699);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNamber);
            this.Controls.Add(this.lblAddras);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblID);
            this.Name = "add";
            this.Text = "ADD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNamber;
        private System.Windows.Forms.Label lblAddras;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblID;
    }
}