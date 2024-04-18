using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BD_6.Forms.Reports
{
    public partial class JournalReportWindow : Form
    {
        public JournalReportWindow()
        {
            InitializeComponent();
            MainMenu.Context.Employees.Load();
            MainMenu.Context.Providers.Load();

            this.providerBindingSource.DataSource = MainMenu.Context.Providers.ToList();
            this.employeesBindingSource.DataSource = MainMenu.Context.Employees.ToList();
            
            cmbEmployee.SelectedIndex = -1;
            cmbProvider.SelectedIndex = -1;

            dtpStart.CustomFormat = " ";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = " ";
            dtpEnd.Format = DateTimePickerFormat.Custom;
        }

        private void JournalReportWindow_Load(object sender, EventArgs e)
        {
            InitializeDataSource();

            this.reportViewer1.RefreshReport();
        }

        private void InitializeDataSource()
        {
            DataView dv = CreateView(null);

            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "shopDataSet";
            reportDataSource1.Value = dv;
            
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
        }

        private DataView CreateView(IQueryable<Journal> filter)
        {
            DataView dataView = new DataView();
            List<Journal> journals = filter == null 
                ? MainMenu.Context.Journals.ToList()
                : filter.ToList();

            DataTable dt = MainMenu.ToDataTable(journals);
            dt.Columns["productID"].DataType = typeof(string);
            dt.Columns["employeeID"].DataType = typeof(string);
            dt.Columns["providerID"].DataType = typeof(string);

            dataView.Table = dt;

            for (int i = 0; i < dataView.Table.Rows.Count; i++)
            {
                int employee = Convert.ToInt32(dataView.Table.Rows[i]["employeeID"]);
                int product = Convert.ToInt32(dataView.Table.Rows[i]["productID"]);
                int provider = Convert.ToInt32(dataView.Table.Rows[i]["providerID"]);
                dataView.Table.Rows[i]["employeeID"] = MainMenu.Context.Employees
                                                  .Where(e => e.employeeID == employee)
                                                  .Select(e => e.full_name)
                                                  .FirstOrDefault();

                dataView.Table.Rows[i]["productID"] = MainMenu.Context.Products
                                                  .Where(p => p.productID == product)
                                                  .Select(p => p.name)
                                                  .FirstOrDefault();

                dataView.Table.Rows[i]["providerID"] = MainMenu.Context.Providers
                                                  .Where(p => p.providerID == provider)
                                                  .Select(p => p.name)
                                                  .FirstOrDefault();
            }

            return dataView;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string dateStart = dtpStart.Format != DateTimePickerFormat.Custom
                               ? dtpStart.Value.ToShortDateString()
                               : null;
            string dateEnd = dtpEnd.Format != DateTimePickerFormat.Custom
                               ? dtpEnd.Value.ToShortDateString()
                               : null;

            int? employeeID = cmbEmployee.SelectedValue as int?;
            int? providerID = cmbProvider.SelectedValue as int?;

            var filter = CreateFilter(dateStart, dateEnd, providerID, employeeID);
            reportViewer1.LocalReport.DataSources[0].Value = CreateView(filter as IQueryable<Journal>);
            reportViewer1.RefreshReport();
        }

        private IQueryable CreateFilter(string dateStart, string dateEnd, int? provider, int? employee)
        {
            IQueryable<Journal> query = MainMenu.Context.Journals.AsQueryable();

            if (!string.IsNullOrEmpty(dateStart))
            {
                DateTime startDate = DateTime.Parse(dateStart);
                query = query.Where(j => j.purchase_date >= startDate);
            }

            if (!string.IsNullOrEmpty(dateEnd))
            {
                DateTime endDate = DateTime.Parse(dateEnd);
                query = query.Where(j => j.purchase_date <= endDate);
            }

            if (employee != null && employee != 0)
            {
                query = query.Where(j => j.employeeID == employee);
            }

            if (provider != null && provider != 0)
            {
                query = query.Where(j => j.providerID == provider);
            }

            return query;
        }

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
    }
}
