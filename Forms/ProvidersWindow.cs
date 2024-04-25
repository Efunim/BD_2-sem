using BD_6.Forms;
using BD_6.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6
{
    public partial class ProvidersWindow : Form
    {
        private const int DGV_SCROLL_OFFSET = 5;

        private DbService<Provider> _db;

        public ProvidersWindow()
        {
            InitializeComponent();
            _db = new DbService<Provider>(this.providerBindingSource);
        }

        private void DepartmentsWindow_Load(object sender, EventArgs e)
        {

        }

        #region Навигация
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvProviders.SelectedRows[0].Index;
            if (currentIndex > 0)
            {
                SelectRow(currentIndex - 1);
                btnNextEntry.Enabled = true;
            }
            else
            {
                btnPreviousEntry.Enabled = false;
            }
        }

        private void btnNextEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvProviders.SelectedRows[0].Index;
            if (currentIndex < dgvProviders.Rows.Count - 1)
            {
                SelectRow(currentIndex + 1);
            }
            else
            {
                btnNextEntry.Enabled = false;
            }

            btnPreviousEntry.Enabled = true;
        }

        private void SelectRow(int index)
        {
            dgvProviders.ClearSelection();
            dgvProviders.Rows[index].Selected = true;
            dgvProviders.FirstDisplayedScrollingRowIndex = Math.Max(0, index - DGV_SCROLL_OFFSET);
        }
        #endregion

        #region Изменение таблицы

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvDepartments_UserDeletingRow(null,
                new DataGridViewRowCancelEventArgs(dgvProviders.CurrentRow));
        }

        private void dgvDepartments_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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

            _db.Add(new Provider() 
            { 
                name = txtName.Text,
                phone_number = txtPhone.Text == "" ? txtPhone.Text : null,
            });
            this.Validate();
        }

        private bool isValidData()
        {
            return txtName.Text != "";
        }

        private void dgvDepartments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            DepartmentReportWindow report = new DepartmentReportWindow();
            report.ShowDialog();
        }

        private void DepartmentsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db.FilterData(CreateFilter());
            this.Validate();
        }

        private IQueryable<Provider> CreateFilter()
        {
            IQueryable<Provider> query = _db.Table.AsQueryable();

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                query = query.Where(x => x.name.Contains(txtName.Text));
            }

            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                query = query.Where(x => x.phone_number.Contains(txtPhone.Text));
            }

            return query;
        }
    }
}
