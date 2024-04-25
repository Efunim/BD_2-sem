using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            JournalWindow journalWindow = new JournalWindow();
            journalWindow.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesWindow employeesWindow = new EmployeesWindow();
            employeesWindow.ShowDialog();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsWindow departmentsWindow = new DepartmentsWindow();
            departmentsWindow.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsWindow productsWindow = new ProductsWindow();
            productsWindow.ShowDialog();
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            ProvidersWindow providersWindow = new ProvidersWindow();
            providersWindow.ShowDialog();
        }
    }
}
