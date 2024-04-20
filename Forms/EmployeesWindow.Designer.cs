namespace BD_6
{
    partial class EmployeesWindow
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
            this.btnPreviousEntry = new System.Windows.Forms.Button();
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenDepartments = new System.Windows.Forms.Button();
            this.btnReference = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreviousEntry
            // 
            this.btnPreviousEntry.Enabled = false;
            this.btnPreviousEntry.Location = new System.Drawing.Point(717, 291);
            this.btnPreviousEntry.Name = "btnPreviousEntry";
            this.btnPreviousEntry.Size = new System.Drawing.Size(138, 29);
            this.btnPreviousEntry.TabIndex = 3;
            this.btnPreviousEntry.Text = "<--";
            this.btnPreviousEntry.UseVisualStyleBackColor = true;
            this.btnPreviousEntry.Click += new System.EventHandler(this.btnPreviousEntry_Click);
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.Location = new System.Drawing.Point(867, 291);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(129, 29);
            this.btnNextEntry.TabIndex = 5;
            this.btnNextEntry.Text = "-->";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            this.btnNextEntry.Click += new System.EventHandler(this.btnNextEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(719, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(282, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить выбранную запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenDepartments
            // 
            this.btnOpenDepartments.Location = new System.Drawing.Point(719, 47);
            this.btnOpenDepartments.Name = "btnOpenDepartments";
            this.btnOpenDepartments.Size = new System.Drawing.Size(277, 29);
            this.btnOpenDepartments.TabIndex = 16;
            this.btnOpenDepartments.Text = "Отделы";
            this.btnOpenDepartments.UseVisualStyleBackColor = true;
            this.btnOpenDepartments.Click += new System.EventHandler(this.btnOpenDepartments_Click);
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(719, 12);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(277, 29);
            this.btnReference.TabIndex = 17;
            this.btnReference.Text = "Справка";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.txtFullName,
            this.departmentIDDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.employeesBindingSource;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(701, 436);
            this.dgvEmployees.TabIndex = 18;
            this.dgvEmployees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellEndEdit);
            this.dgvEmployees.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_ColumnHeaderMouseClick);
            this.dgvEmployees.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmployees_DataError);
            this.dgvEmployees.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployees_UserDeletingRow);
            // 
            // clmnId
            // 
            this.clmnId.DataPropertyName = "employeeID";
            this.clmnId.HeaderText = "ID";
            this.clmnId.MinimumWidth = 6;
            this.clmnId.Name = "clmnId";
            this.clmnId.Visible = false;
            this.clmnId.Width = 50;
            // 
            // txtFullName
            // 
            this.txtFullName.DataPropertyName = "full_name";
            this.txtFullName.HeaderText = "ФИО";
            this.txtFullName.MinimumWidth = 6;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Width = 300;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID";
            this.departmentIDDataGridViewTextBoxColumn.DataSource = this.departmentBindingSource;
            this.departmentIDDataGridViewTextBoxColumn.DisplayMember = "name";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.departmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departmentIDDataGridViewTextBoxColumn.ValueMember = "departmentID";
            this.departmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(BD_6.Department);
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(BD_6.Employees);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ФИО";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 27);
            this.txtName.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 102);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 27);
            this.txtPhone.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Телефон";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataSource = this.departmentBindingSource1;
            this.cmbDepartment.DisplayMember = "name";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(73, 68);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(197, 28);
            this.cmbDepartment.TabIndex = 23;
            this.cmbDepartment.ValueMember = "departmentID";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(BD_6.Department);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Отдел";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(6, 149);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(123, 29);
            this.btnAddRecord.TabIndex = 25;
            this.btnAddRecord.Text = "Добавить";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddRecord);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Location = new System.Drawing.Point(719, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 184);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(148, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 29);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnReference);
            this.Controls.Add(this.btnOpenDepartments);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNextEntry);
            this.Controls.Add(this.btnPreviousEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.EmployeesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPreviousEntry;
        private System.Windows.Forms.Button btnNextEntry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpenDepartments;
        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFullName;
        private System.Windows.Forms.DataGridViewComboBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.Button btnSearch;
    }
}