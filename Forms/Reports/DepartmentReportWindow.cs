using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6.Forms
{
    public partial class DepartmentReportWindow : Form
    {
        public DepartmentReportWindow()
        {
            InitializeComponent();
        }

        private void DepartmentReportWindow_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "shopDataSet";
            reportDataSource.Value = MainMenu.Context.Departments.ToList();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}
