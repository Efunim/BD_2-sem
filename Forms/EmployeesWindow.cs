using BD_6.Forms.Reports;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BD_6
{
    public partial class EmployeesWindow : Form
    {
        private const int DGV_SCROLL_OFFSET = 5;

        private ApplicationContext _context = new ApplicationContext();
        private bool _isAscending = true;

        public EmployeesWindow()
        {
            InitializeComponent();
        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            this.departmentBindingSource.DataSource = _context.Departments.ToList();
            this.departmentBindingSource1.DataSource = _context.Departments.ToList();

            cmbDepartment.SelectedIndex = -1;
            dgvEmployees.Rows[0].Selected = true;
        }

        private void dgvEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        #region Сортировка и фильтрация
        private void dgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filteredData = CreateFilter().ToList();
            this.employeesBindingSource.DataSource = filteredData;
        }

        private IQueryable<Employees> CreateFilter()
        {
            IQueryable<Employees> query = _context.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                query = query.Where(x => x.full_name.Contains(txtName.Text));
            }

            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                query = query.Where(x => x.phone_number.Contains(txtPhone.Text));
            }

            if (cmbDepartment.SelectedValue != null)
            {
                query = query.Where(x => x.departmentID == (int)cmbDepartment.SelectedValue);
            }

            return query;
        }
        #endregion

        #region Навигация
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvEmployees.SelectedRows[0].Index;
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
            int currentIndex = dgvEmployees.SelectedRows[0].Index;
            if (currentIndex < dgvEmployees.Rows.Count - 1)
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
            dgvEmployees.ClearSelection();
            dgvEmployees.Rows[index].Selected = true;
            dgvEmployees.FirstDisplayedScrollingRowIndex = Math.Max(0, index - DGV_SCROLL_OFFSET);
        }
        #endregion

        #region Другие окна
        private void btnOpenDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsWindow departmentsWindow = new DepartmentsWindow();
            departmentsWindow.ShowDialog(this);
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            ReferenceWindow referenceWindow = new ReferenceWindow();
            referenceWindow.EmpName = dgvEmployees["txtFullName", dgvEmployees.CurrentCell.RowIndex].Value.ToString();
            referenceWindow.ShowDialog(this);
        }
        #endregion

        #region Изменение таблицы

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            int? depId = (int?)cmbDepartment.SelectedValue;

            if (name == "" || depId == null)
            {
                MessageBox.Show("Неккоретные данные!");
                return;
            }

            Employees newEmp = new Employees()
            {
                full_name = name,
                departmentID = depId.Value,
                phone_number = phone == "" ? null : phone
            };

            _context.Employees.Add(newEmp);
            _context.SaveChanges();

            UpdateDgv();
            SelectRow(dgvEmployees.Rows.Count - 1);
            ClearAddingFields();
        }

        private void ClearAddingFields()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            cmbDepartment.SelectedIndex = -1;
        }

        private void UpdateDgv()
        {
            this.employeesBindingSource.DataSource = _context.Employees.ToList();
            dgvEmployees.ResetBindings();
        }

        private void dgvEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new ApplicationContext())
            {
                int id = (int)dgvEmployees["clmnId", e.RowIndex].Value;
                var employee = context.Employees.Find(id);
                if (employee != null)
                {
                    var propertyName = dgvEmployees.Columns[e.ColumnIndex].DataPropertyName;
                    typeof(Employees).GetProperty(propertyName)?
                                     .SetValue(employee
                                     , dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                context.SaveChanges();
            }
        }

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmployees_UserDeletingRow(dgvEmployees
                , new DataGridViewRowCancelEventArgs(dgvEmployees.SelectedRows[0]));

            UpdateDgv();
            SelectRow(dgvEmployees.Rows.Count-1);
        }

        private void dgvEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Вы уверены, что хотите удалить данные? Этот процесс необратим"
                        , "Предупреждение!"
                        , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            int id = (int)dgvEmployees["clmnId", e.Row.Index].Value;
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();

        }
        #endregion

        #endregion

    }
}
