namespace BD_6.Forms.Reports
{
    partial class JournalReportWindow
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearStartDate = new System.Windows.Forms.Button();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            reportDataSource1.Name = "shopDataSet";
            reportDataSource1.Value = null;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "BD_6.Source.Reports.JournalReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(736, 420);
            this.reportViewer.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(7, 92);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(153, 27);
            this.dtpEnd.TabIndex = 22;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(7, 37);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(153, 27);
            this.dtpStart.TabIndex = 21;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = this.employeesBindingSource;
            this.cmbEmployee.DisplayMember = "full_name";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(7, 200);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(186, 28);
            this.cmbEmployee.TabIndex = 20;
            this.cmbEmployee.ValueMember = "employeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(BD_6.Employees);
            // 
            // cmbProvider
            // 
            this.cmbProvider.DataSource = this.providerBindingSource;
            this.cmbProvider.DisplayMember = "name";
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(7, 147);
            this.cmbProvider.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(186, 28);
            this.cmbProvider.TabIndex = 19;
            this.cmbProvider.ValueMember = "providerID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataSource = typeof(BD_6.Provider);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(7, 300);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(186, 28);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Готово";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата от";
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.Location = new System.Drawing.Point(166, 35);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(28, 26);
            this.btnClearStartDate.TabIndex = 23;
            this.btnClearStartDate.Text = "X";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            this.btnClearStartDate.Click += new System.EventHandler(this.btnClearStartDate_Click);
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Location = new System.Drawing.Point(166, 90);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(28, 26);
            this.btnClearEndDate.TabIndex = 24;
            this.btnClearEndDate.Text = "X";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.btnClearEndDate);
            this.groupBox1.Controls.Add(this.cmbProvider);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.btnClearStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(742, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 335);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DataSource = this.productsBindingSource;
            this.cmbProduct.DisplayMember = "name";
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(7, 253);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(186, 28);
            this.cmbProduct.TabIndex = 26;
            this.cmbProduct.ValueMember = "productID";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(BD_6.Products);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Товар";
            // 
            // JournalReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JournalReportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalReportWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JournalReportWindow_FormClosing);
            this.Load += new System.EventHandler(this.JournalReportWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.Button btnClearStartDate;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}