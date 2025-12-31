namespace Pharmacy_Management_System
{
    partial class MedecineForm
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
            this.btSEARCH = new System.Windows.Forms.Button();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddmed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.SuspendLayout();
            // 
            // btSEARCH
            // 
            this.btSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSEARCH.ForeColor = System.Drawing.Color.Navy;
            this.btSEARCH.Location = new System.Drawing.Point(751, 172);
            this.btSEARCH.Name = "btSEARCH";
            this.btSEARCH.Size = new System.Drawing.Size(84, 36);
            this.btSEARCH.TabIndex = 33;
            this.btSEARCH.Text = "Serach";
            this.btSEARCH.UseVisualStyleBackColor = true;
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(12, 308);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.ReadOnly = true;
            this.dgvMed.RowHeadersWidth = 51;
            this.dgvMed.RowTemplate.Height = 24;
            this.dgvMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed.Size = new System.Drawing.Size(822, 203);
            this.dgvMed.TabIndex = 32;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.Navy;
            this.btSave.Location = new System.Drawing.Point(750, 220);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 36);
            this.btSave.TabIndex = 31;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.Color.Navy;
            this.btEdit.Location = new System.Drawing.Point(750, 75);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 36);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.ForeColor = System.Drawing.Color.Navy;
            this.btDelete.Location = new System.Drawing.Point(750, 121);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(84, 36);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(170, 146);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(494, 22);
            this.txbName.TabIndex = 28;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(170, 222);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(494, 22);
            this.txbPrice.TabIndex = 26;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(170, 181);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(494, 22);
            this.txbQuantity.TabIndex = 25;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(60, 111);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(45, 20);
            this.lbType.TabIndex = 21;
            this.lbType.Text = "Type";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(60, 222);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(60, 183);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(71, 20);
            this.lbQuantity.TabIndex = 18;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(60, 146);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 20);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "Name";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Syrup",
            "Injection",
            "Ointment",
            "Cream",
            "Drops",
            "Inhaler"});
            this.cmbType.Location = new System.Drawing.Point(170, 109);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(494, 24);
            this.cmbType.TabIndex = 34;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(750, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 36);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddmed
            // 
            this.lblAddmed.AutoSize = true;
            this.lblAddmed.BackColor = System.Drawing.Color.Transparent;
            this.lblAddmed.Font = new System.Drawing.Font("Cambria", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddmed.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblAddmed.Location = new System.Drawing.Point(274, 9);
            this.lblAddmed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddmed.Name = "lblAddmed";
            this.lblAddmed.Size = new System.Drawing.Size(247, 43);
            this.lblAddmed.TabIndex = 57;
            this.lblAddmed.Text = "Add Medecine";
            // 
            // MedecineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.lblAddmed);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btSEARCH);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbName);
            this.Name = "MedecineForm";
            this.Text = "MedecineForm";
            this.Load += new System.EventHandler(this.MedecineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSEARCH;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddmed;
    }
}