namespace BD_6
{
    partial class ProvidersWindow
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
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.btnPreviousEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 26);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(330, 26);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.Location = new System.Drawing.Point(751, 133);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(130, 28);
            this.btnNextEntry.TabIndex = 34;
            this.btnNextEntry.Text = "-->";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            this.btnNextEntry.Click += new System.EventHandler(this.btnNextEntry_Click);
            // 
            // btnPreviousEntry
            // 
            this.btnPreviousEntry.Location = new System.Drawing.Point(551, 133);
            this.btnPreviousEntry.Name = "btnPreviousEntry";
            this.btnPreviousEntry.Size = new System.Drawing.Size(130, 28);
            this.btnPreviousEntry.TabIndex = 32;
            this.btnPreviousEntry.Text = "<--";
            this.btnPreviousEntry.UseVisualStyleBackColor = true;
            this.btnPreviousEntry.Click += new System.EventHandler(this.btnPreviousEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 41;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 53);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 27);
            this.txtPhone.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Телефон";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(551, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 125);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 26);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProviders
            // 
            this.dgvProviders.AllowUserToAddRows = false;
            this.dgvProviders.AutoGenerateColumns = false;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.dgvProviders.DataSource = this.providerBindingSource;
            this.dgvProviders.Location = new System.Drawing.Point(13, 12);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.RowHeadersWidth = 51;
            this.dgvProviders.RowTemplate.Height = 24;
            this.dgvProviders.Size = new System.Drawing.Size(532, 404);
            this.dgvProviders.TabIndex = 45;
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            this.providerIDDataGridViewTextBoxColumn.DataPropertyName = "providerID";
            this.providerIDDataGridViewTextBoxColumn.HeaderText = "providerID";
            this.providerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            this.providerIDDataGridViewTextBoxColumn.Visible = false;
            this.providerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(BD_6.Provider);
            // 
            // ProvidersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 431);
            this.Controls.Add(this.dgvProviders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNextEntry);
            this.Controls.Add(this.btnPreviousEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProvidersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNextEntry;
        private System.Windows.Forms.Button btnPreviousEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource providerBindingSource;
    }
}