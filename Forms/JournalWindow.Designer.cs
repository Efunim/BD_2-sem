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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnProviders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPreviousEntry = new System.Windows.Forms.Button();
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 28);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(909, 483);
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
            this.cmbProduct.DataSource = this.productsBindingSource;
            this.cmbProduct.DisplayMember = "name";
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(71, 30);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(231, 28);
            this.cmbProduct.TabIndex = 25;
            this.cmbProduct.ValueMember = "productID";
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
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Дата";
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journalBindingSource, "purchase_date", true));
            this.txtDate.Location = new System.Drawing.Point(66, 104);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(236, 27);
            this.txtDate.TabIndex = 29;
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataSource = typeof(BD_6.Journal);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DisplayMember = "full_name";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(116, 180);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(186, 28);
            this.cmbEmployee.TabIndex = 31;
            this.cmbEmployee.ValueMember = "employeeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Сотрудник";
            // 
            // txtCount
            // 
            this.txtCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journalBindingSource, "count", true));
            this.txtCount.Location = new System.Drawing.Point(116, 141);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(186, 27);
            this.txtCount.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Количество";
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(748, 12);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(149, 28);
            this.btnProducts.TabIndex = 34;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnProviders
            // 
            this.btnProviders.Location = new System.Drawing.Point(748, 49);
            this.btnProviders.Name = "btnProviders";
            this.btnProviders.Size = new System.Drawing.Size(149, 28);
            this.btnProviders.TabIndex = 35;
            this.btnProviders.Text = "Поставщики";
            this.btnProviders.UseVisualStyleBackColor = true;
            this.btnProviders.Click += new System.EventHandler(this.btnProviders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(909, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(149, 28);
            this.btnEmployees.TabIndex = 36;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPreviousEntry
            // 
            this.btnPreviousEntry.Location = new System.Drawing.Point(748, 353);
            this.btnPreviousEntry.Name = "btnPreviousEntry";
            this.btnPreviousEntry.Size = new System.Drawing.Size(149, 28);
            this.btnPreviousEntry.TabIndex = 16;
            this.btnPreviousEntry.Text = "<--";
            this.btnPreviousEntry.UseVisualStyleBackColor = true;
            this.btnPreviousEntry.Click += new System.EventHandler(this.btnPreviousEntry_Click);
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.Location = new System.Drawing.Point(909, 353);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(149, 28);
            this.btnNextEntry.TabIndex = 18;
            this.btnNextEntry.Text = "-->";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            this.btnNextEntry.Click += new System.EventHandler(this.btnNextEntry_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(909, 49);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 28);
            this.btnReport.TabIndex = 37;
            this.btnReport.Text = "Отчёт";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataSource = this.providerBindingSource;
            this.cmbProvider.DisplayMember = "name";
            this.cmbProvider.Location = new System.Drawing.Point(116, 67);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(186, 28);
            this.cmbProvider.TabIndex = 38;
            this.cmbProvider.ValueMember = "providerID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(BD_6.Provider);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProvider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Location = new System.Drawing.Point(748, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 264);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить запись";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.providerIDDataGridViewTextBoxColumn,
            this.purchasedateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeesDataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.journalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 499);
            this.dataGridView1.TabIndex = 40;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "recordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "recordID";
            this.recordIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.Visible = false;
            this.recordIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            this.providerIDDataGridViewTextBoxColumn.DataPropertyName = "providerID";
            this.providerIDDataGridViewTextBoxColumn.HeaderText = "providerID";
            this.providerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            this.providerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            this.purchasedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeesDataGridViewTextBoxColumn
            // 
            this.employeesDataGridViewTextBoxColumn.DataPropertyName = "employees";
            this.employeesDataGridViewTextBoxColumn.HeaderText = "employees";
            this.employeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeesDataGridViewTextBoxColumn.Name = "employeesDataGridViewTextBoxColumn";
            this.employeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "products";
            this.productsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "provider";
            this.providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            this.providerDataGridViewTextBoxColumn.Width = 125;
            // 
            // JournalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnProviders);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNextEntry);
            this.Controls.Add(this.btnPreviousEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JournalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProviders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPreviousEntry;
        private System.Windows.Forms.Button btnNextEntry;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.BindingSource journalBindingSource;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
    }
}