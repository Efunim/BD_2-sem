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
        public static ApplicationContext Context = new ApplicationContext();
        public MainMenu()
        {
            InitializeComponent();
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
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
