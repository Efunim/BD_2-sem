using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace BD_6.Forms.Reports
{
    public partial class JournalReportWindow : Form
    {
        private ApplicationContext _context = new ApplicationContext();

        public JournalReportWindow()
        {
            InitializeComponent();
            _context.Employees.Load();
            _context.Providers.Load();
            _context.Products.Load();

            this.providerBindingSource.DataSource = _context.Providers.Local.ToBindingList();
            this.employeesBindingSource.DataSource = _context.Employees.Local.ToBindingList();
            this.productsBindingSource.DataSource = _context.Products.Local.ToBindingList();
            
            cmbEmployee.SelectedIndex = -1;
            cmbProvider.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;

            dtpStart.CustomFormat = " ";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = " ";
            dtpEnd.Format = DateTimePickerFormat.Custom;
        }

        private void JournalReportWindow_Load(object sender, EventArgs e)
        {
            InitializeDataSource();

            this.reportViewer.RefreshReport();
        }

        private void InitializeDataSource()
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "shopDataSet";
            reportDataSource1.Value = GetFormattedTable(_context.Journals);

            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var filter = CreateFilter();
            reportViewer.LocalReport.DataSources[0].Value = GetFormattedTable(filter).ToList();
            reportViewer.RefreshReport();
        }

        private IEnumerable<dynamic> GetFormattedTable(IQueryable<Journal> list)
        {
            return list.Select(j => new
            {
                employeeID = j.employees.full_name,
                productID = j.products.name,
                providerID = j.provider.name,
                j.purchase_date,
                j.count,
                j.current_price
            });
        }

        private IQueryable<Journal> CreateFilter()
        {
            IQueryable<Journal> query = _context.Journals.AsQueryable();

            if (dtpStart.Format != DateTimePickerFormat.Custom)
            {
                query = query.Where(j => j.purchase_date >= dtpStart.Value);
            }

            if (dtpEnd.Format != DateTimePickerFormat.Custom)
            {
                query = query.Where(j => j.purchase_date <= dtpEnd.Value);
            }

            if (cmbEmployee.SelectedValue != null)
            {
                query = query.Where(j => j.employeeID == (int)cmbEmployee.SelectedValue);
            }

            if (cmbProvider.SelectedValue != null)
            {
                query = query.Where(j => j.providerID == (int)cmbProvider.SelectedValue);
            }

            if(cmbProduct.SelectedValue != null)
            {
                query = query.Where(j => j.productID == (int)cmbProduct.SelectedValue);
            }

            return query;
        }

        #region DateTimePickers

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.Format = DateTimePickerFormat.Short;
        }

        private void btnClearStartDate_Click(object sender, EventArgs e)
        {
            ClearDate(dtpStart);
        }

        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            ClearDate(dtpEnd);
        }

        private void ClearDate(DateTimePicker datePicker)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
        }

        #endregion

        private void JournalReportWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }
    }
}
