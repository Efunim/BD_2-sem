using BD_6.Forms;
using BD_6.Source;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BD_6
{
    public partial class DepartmentsWindow : Form
    {
        private const int DGV_SCROLL_OFFSET = 5;

        private DbService<Department> _db;

        public DepartmentsWindow()
        {
            InitializeComponent();
            _db = new DbService<Department>(this.departmentBindingSource);
        }

        private void DepartmentsWindow_Load(object sender, EventArgs e)
        {

        }

        #region Изменение таблицы

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvDepartments_UserDeletingRow(null,
                new DataGridViewRowCancelEventArgs(dgvDepartments.CurrentRow));
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

            _db.Add(new Department() { name = txtName.Text });
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

        private IQueryable<Department> CreateFilter()
        {
            IQueryable<Department> query = _db.Table.AsQueryable();

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                query = query.Where(x => x.name.Contains(txtName.Text));
            }

            return query;
        }

    }
}
