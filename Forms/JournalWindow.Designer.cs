namespace BD_6
{
    partial class JournalWindow
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnProviders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPriceZnak = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearDate = new System.Windows.Forms.Button();
            this.cmbCountZnak = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.employeeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.providerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 28);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1110, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 28);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Товар";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DataSource = this.productsBindingSource1;
            this.cmbProduct.DisplayMember = "name";
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(71, 30);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(231, 28);
            this.cmbProduct.TabIndex = 25;
            this.cmbProduct.ValueMember = "productID";
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataSource = typeof(BD_6.Products);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(BD_6.Products);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Дата";
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataSource = typeof(BD_6.Journal);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = this.employeesBindingSource1;
            this.cmbEmployee.DisplayMember = "full_name";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(116, 254);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(186, 28);
            this.cmbEmployee.TabIndex = 31;
            this.cmbEmployee.ValueMember = "employeeID";
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataSource = typeof(BD_6.Employees);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(BD_6.Employees);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Сотрудник";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(118, 182);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(132, 27);
            this.txtCount.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Количество";
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(949, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(149, 28);
            this.btnProducts.TabIndex = 34;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnProviders
            // 
            this.btnProviders.Location = new System.Drawing.Point(949, 49);
            this.btnProviders.Name = "btnProviders";
            this.btnProviders.Size = new System.Drawing.Size(149, 28);
            this.btnProviders.TabIndex = 35;
            this.btnProviders.Text = "Поставщики";
            this.btnProviders.UseVisualStyleBackColor = true;
            this.btnProviders.Click += new System.EventHandler(this.btnProviders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(1110, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(149, 28);
            this.btnEmployees.TabIndex = 36;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1110, 49);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 28);
            this.btnReport.TabIndex = 37;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataSource = this.providerBindingSource1;
            this.cmbProvider.DisplayMember = "name";
            this.cmbProvider.Location = new System.Drawing.Point(116, 67);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(186, 28);
            this.cmbProvider.TabIndex = 38;
            this.cmbProvider.ValueMember = "providerID";
            // 
            // providerBindingSource1
            // 
            this.providerBindingSource1.DataSource = typeof(BD_6.Provider);
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(BD_6.Provider);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPriceZnak);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClearEndDate);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.btnClearDate);
            this.groupBox1.Controls.Add(this.cmbCountZnak);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProvider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Location = new System.Drawing.Point(949, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 336);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить запись";
            // 
            // cmbPriceZnak
            // 
            this.cmbPriceZnak.FormattingEnabled = true;
            this.cmbPriceZnak.Items.AddRange(new object[] {
            "=",
            "<=",
            ">=",
            "<",
            ">"});
            this.cmbPriceZnak.Location = new System.Drawing.Point(256, 214);
            this.cmbPriceZnak.Name = "cmbPriceZnak";
            this.cmbPriceZnak.Size = new System.Drawing.Size(48, 28);
            this.cmbPriceZnak.TabIndex = 49;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(64, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 27);
            this.txtPrice.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Цена";
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Location = new System.Drawing.Point(277, 140);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(25, 27);
            this.btnClearEndDate.TabIndex = 46;
            this.btnClearEndDate.Text = "X";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(143, 142);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(128, 27);
            this.dtpEndDate.TabIndex = 45;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Конец периода";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(60, 103);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(211, 27);
            this.dtpStartDate.TabIndex = 41;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnClearDate
            // 
            this.btnClearDate.Location = new System.Drawing.Point(277, 101);
            this.btnClearDate.Name = "btnClearDate";
            this.btnClearDate.Size = new System.Drawing.Size(25, 27);
            this.btnClearDate.TabIndex = 42;
            this.btnClearDate.Text = "X";
            this.btnClearDate.UseVisualStyleBackColor = true;
            this.btnClearDate.Click += new System.EventHandler(this.btnClearDate_Click);
            // 
            // cmbCountZnak
            // 
            this.cmbCountZnak.FormattingEnabled = true;
            this.cmbCountZnak.Items.AddRange(new object[] {
            "=",
            "<=",
            ">=",
            "<",
            ">"});
            this.cmbCountZnak.Location = new System.Drawing.Point(256, 181);
            this.cmbCountZnak.Name = "cmbCountZnak";
            this.cmbCountZnak.Size = new System.Drawing.Size(48, 28);
            this.cmbCountZnak.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 28);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AutoGenerateColumns = false;
            this.dgvJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeColumn,
            this.productColumn,
            this.providerColumn,
            this.purchasedateDataGridViewTextBoxColumn,
            this.clmCount,
            this.current_price,
            this.clmTotalItemPrice});
            this.dgvJournal.DataSource = this.journalBindingSource;
            this.dgvJournal.Location = new System.Drawing.Point(13, 12);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.RowHeadersWidth = 51;
            this.dgvJournal.RowTemplate.Height = 24;
            this.dgvJournal.Size = new System.Drawing.Size(930, 499);
            this.dgvJournal.TabIndex = 40;
            this.dgvJournal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournal_CellEndEdit);
            this.dgvJournal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJournal_CellFormatting);
            this.dgvJournal.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvJournal_UserDeletingRow);
            // 
            // employeeColumn
            // 
            this.employeeColumn.DataPropertyName = "employeeID";
            this.employeeColumn.DataSource = this.employeesBindingSource;
            this.employeeColumn.DisplayMember = "full_name";
            this.employeeColumn.HeaderText = "Сотрудник";
            this.employeeColumn.MinimumWidth = 6;
            this.employeeColumn.Name = "employeeColumn";
            this.employeeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeColumn.ValueMember = "employeeID";
            // 
            // productColumn
            // 
            this.productColumn.DataPropertyName = "productID";
            this.productColumn.DataSource = this.productsBindingSource;
            this.productColumn.DisplayMember = "name";
            this.productColumn.HeaderText = "Товар";
            this.productColumn.MinimumWidth = 6;
            this.productColumn.Name = "productColumn";
            this.productColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productColumn.ValueMember = "productID";
            // 
            // providerColumn
            // 
            this.providerColumn.DataPropertyName = "providerID";
            this.providerColumn.DataSource = this.providerBindingSource;
            this.providerColumn.DisplayMember = "name";
            this.providerColumn.HeaderText = "Поставщик";
            this.providerColumn.MinimumWidth = 6;
            this.providerColumn.Name = "providerColumn";
            this.providerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.providerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.providerColumn.ValueMember = "providerID";
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.purchasedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            // 
            // clmCount
            // 
            this.clmCount.DataPropertyName = "count";
            this.clmCount.HeaderText = "Количество";
            this.clmCount.MinimumWidth = 6;
            this.clmCount.Name = "clmCount";
            // 
            // current_price
            // 
            this.current_price.DataPropertyName = "current_price";
            this.current_price.HeaderText = "Цена за ед.";
            this.current_price.MinimumWidth = 6;
            this.current_price.Name = "current_price";
            // 
            // clmTotalItemPrice
            // 
            this.clmTotalItemPrice.HeaderText = "Общая цена";
            this.clmTotalItemPrice.MinimumWidth = 6;
            this.clmTotalItemPrice.Name = "clmTotalItemPrice";
            this.clmTotalItemPrice.ReadOnly = true;
            // 
            // JournalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 523);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnProviders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JournalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProviders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.BindingSource journalBindingSource;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox cmbCountZnak;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnClearDate;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource providerBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPriceZnak;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn providerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalItemPrice;
    }
}