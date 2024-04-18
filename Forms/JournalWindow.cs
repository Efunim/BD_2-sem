using BD_6.Forms.Reports;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6
{
    public partial class JournalWindow : Form
    {
        public JournalWindow()
        {
            InitializeComponent();
            MainMenu.Context.Employees.Load();
            MainMenu.Context.Products.Load();
            MainMenu.Context.Providers.Load();
            MainMenu.Context.Journals.Load();

            cmbProduct.DataSource = MainMenu.Context.Products.Local.ToList();
            cmbProvider.DataSource = MainMenu.Context.Providers.Local.ToList();
            cmbEmployee.DataSource = MainMenu.Context.Employees.Local.ToList();

            this.journalBindingSource.DataSource = MainMenu.Context.Journals.Local.ToBindingList();
        }

        private void tspbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Journal_Load(object sender, EventArgs e)
        {

        }

        private void journalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnFirstEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnNextEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnLastEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "" || txtCount.Text == "")
            {
                MessageBox.Show("Неверные данные!");
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            int index = cmbEmployee.SelectedIndex;

            EmployeesWindow departmentsWindow = new EmployeesWindow();
            departmentsWindow.ShowDialog(this);

            cmbEmployee.SelectedIndex = index;
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            int index = cmbProvider.SelectedIndex;

            ProvidersWindow window = new ProvidersWindow();
            window.ShowDialog(this);

            cmbProvider.SelectedIndex = index;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            int index = cmbProduct.SelectedIndex;

            ProductsWindow window = new ProductsWindow();
            window.ShowDialog(this);

            cmbProduct.SelectedIndex = index;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            JournalReportWindow reportWindow = new JournalReportWindow();
            reportWindow.ShowDialog();
        }
    }
}
