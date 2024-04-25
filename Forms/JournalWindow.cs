using BD_6.Forms.Reports;
using BD_6.Source;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BD_6
{
    public partial class JournalWindow : Form
    {
        private DbService<Journal> _db;

        #region Инициализация и настройки
        public JournalWindow()
        {
            InitializeComponent();
            _db = new DbService<Journal>(this.journalBindingSource);

            this.employeesBindingSource.DataSource = (new DbService<Employees>(employeesBindingSource))
                .Table.Local.ToBindingList();
            this.providerBindingSource.DataSource = (new DbService<Provider>(providerBindingSource))
                .Table.Local.ToBindingList();
            this.productsBindingSource.DataSource = (new DbService<Products>(productsBindingSource))
                .Table.Local.ToBindingList();

            SetProductDataSource();
            SetProviderDataSource();
            SetEmployeeDataSource();

            cmbCountZnak.SelectedIndex = 0;
            cmbPriceZnak.SelectedIndex = 0;
            dtpStartDate.CustomFormat = " ";
            dtpEndDate.CustomFormat = " ";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Format = DateTimePickerFormat.Custom;

            dgvJournal.Columns["purchasedateDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void SetProviderDataSource()
        {
            this.providerBindingSource1.DataSource = (new DbService<Provider>(providerBindingSource))
    .Table.Local.ToBindingList();
            cmbProvider.SelectedIndex = -1;
        }
        private void SetProductDataSource()
        {
            this.productsBindingSource1.DataSource = (new DbService<Products>(productsBindingSource))
                .Table.Local.ToBindingList();
            cmbProduct.SelectedIndex = -1;
        }
        private void SetEmployeeDataSource()
        {
            this.employeesBindingSource1.DataSource = (new DbService<Employees>(employeesBindingSource))
                .Table.Local.ToBindingList();
            cmbEmployee.SelectedIndex = -1;
        }
        #endregion

        #region Изменение таблицы
        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvJournal_UserDeletingRow(null,
                new DataGridViewRowCancelEventArgs(dgvJournal.CurrentRow));
        }

        private void dgvJournal_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !_db.Remove(e.Row.Index);
            this.Validate();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidData())
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }

            _db.Add(new Journal()
            {
                employeeID = (int)cmbEmployee.SelectedValue,
                productID = (int)cmbProduct.SelectedValue,
                providerID = (int)cmbProvider.SelectedValue,
                purchase_date = dtpStartDate.Format == DateTimePickerFormat.Custom
                                ? (DateTime?)null
                                : dtpStartDate.Value,
                count = int.Parse(txtCount.Text),
                current_price = int.Parse(txtPrice.Text)
            });

            this.Validate();
        }

        private void dgvJournal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }
        #endregion

        #region DateTimePickers
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.Format = DateTimePickerFormat.Short;
        }

        private void btnClearDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
        }


        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            dtpEndDate.Format = DateTimePickerFormat.Custom;
        }
        #endregion

        #region Другие окна

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            int index = cmbEmployee.SelectedIndex;

            EmployeesWindow departmentsWindow = new EmployeesWindow();
            departmentsWindow.ShowDialog(this);

            cmbEmployee.SelectedIndex = index;
            SetEmployeeDataSource();
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            int index = cmbProvider.SelectedIndex;

            ProvidersWindow window = new ProvidersWindow();
            window.ShowDialog(this);

            cmbProvider.SelectedIndex = index;
            SetProviderDataSource();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            int index = cmbProduct.SelectedIndex;

            ProductsWindow window = new ProductsWindow();
            window.ShowDialog(this);

            cmbProduct.SelectedIndex = index;
            SetProductDataSource();
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            JournalReportWindow reportWindow = new JournalReportWindow();
            reportWindow.ShowDialog();
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db.FilterData(CreateFilter());
            this.Validate();
        }

        private IQueryable<Journal> CreateFilter()
        {
            IQueryable<Journal> query = _db.Table.AsQueryable();

            if (dtpStartDate.Format != DateTimePickerFormat.Custom)
            {
                query = query.Where(j => j.purchase_date >= dtpStartDate.Value);
            }

            if (dtpEndDate.Format != DateTimePickerFormat.Custom)
            {
                query = query.Where(j => j.purchase_date <= dtpEndDate.Value);
            }

            if (cmbEmployee.SelectedIndex > -1)
            {
                query = query.Where(j => j.employeeID == (int)cmbEmployee.SelectedValue);
            }

            if (cmbProvider.SelectedIndex > -1)
            {
                query = query.Where(j => j.providerID == (int)cmbProvider.SelectedValue);
            }

            if (cmbProduct.SelectedIndex > -1)
            {
                query = query.Where(j => j.productID == (int)cmbProduct.SelectedValue);
            }

            if (txtCount.Text != "")
            {
                int count = int.Parse(txtCount.Text);
                switch (cmbCountZnak.SelectedItem)
                {
                    case "=":
                        query = query.Where(x => x.count == count);
                        break;
                    case ">=":
                        query = query.Where(x => x.count >= count);
                        break;
                    case "<=":
                        query = query.Where(x => x.count <= count);
                        break;
                    case "<":
                        query = query.Where(x => x.count < count);
                        break;
                    case ">":
                        query = query.Where(x => x.count > count);
                        break;
                }
            }

            if (txtPrice.Text != "")
            {
                int price = int.Parse(txtPrice.Text);
                switch (cmbPriceZnak.SelectedItem)
                {
                    case "=":
                        query = query.Where(x => x.current_price == price);
                        break;
                    case ">=":
                        query = query.Where(x => x.current_price >= price);
                        break;
                    case "<=":
                        query = query.Where(x => x.current_price <= price);
                        break;
                    case "<":
                        query = query.Where(x => x.current_price < price);
                        break;
                    case ">":
                        query = query.Where(x => x.current_price > price);
                        break;
                }
            }

            return query;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                txtPrice.Text = "";
                return;
            }
            txtPrice.Text = ((Products)cmbProduct.SelectedItem).price.ToString();
        }

        private bool isValidData()
        {
            return cmbEmployee.SelectedIndex > -1
                && cmbProduct.SelectedIndex > -1
                && cmbProvider.SelectedIndex > -1
                && txtCount.Text != ""
                && txtPrice.Text != "";
        }

    }
}
