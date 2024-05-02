using BD_6.Forms.Reports;
using BD_6.Source;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD_6
{
    public partial class EmployeesWindow : Form
    {
        private DbService<Employees> _db;

        public EmployeesWindow()
        {
            InitializeComponent();
        }

        #region Инициализация и настройки
        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            _db = new DbService<Employees>(this.employeesBindingSource);
            this.departmentBindingSource.DataSource = (new DbService<Department>()).Table.Local.ToBindingList(); ;
            this.departmentBindingSource1.DataSource = this.departmentBindingSource.DataSource;

            cmbDepartment.SelectedIndex = -1;
            dgvEmployees.Rows[0].Selected = true;
        }

        private void SetDepartmentsDataSource()
        {
            this.departmentBindingSource.DataSource = (new DbService<Department>(departmentBindingSource)).Table.Local.ToBindingList();
            this.departmentBindingSource1.DataSource = (new DbService<Department>(departmentBindingSource1)).Table.Local.ToBindingList();
        }
        #endregion

        #region Сортировка и фильтрация
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db.FilterData(CreateFilter());
        }

        private IQueryable<Employees> CreateFilter()
        {
            IQueryable<Employees> query = _db.Table.AsQueryable();

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

        #region Изменение таблицы

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            int? depId = (int?)cmbDepartment.SelectedValue;

            if (!isValidData())
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

            _db.Add(newEmp);

            ClearAddingFields();
        }
                
        private void dgvEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmployees_UserDeletingRow(dgvEmployees
                , new DataGridViewRowCancelEventArgs(dgvEmployees.CurrentRow));
        }

        private void dgvEmployees_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !_db.Remove(e.Row.Index);
            this.Validate();
        }
        #endregion

        #endregion

        #region Другие окна
        private void btnOpenDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsWindow departmentsWindow = new DepartmentsWindow();
            departmentsWindow.ShowDialog(this);

            SetDepartmentsDataSource();

            cmbDepartment.SelectedIndex = -1;
            dgvEmployees.Rows[0].Selected = true;
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            ReferenceWindow referenceWindow = new ReferenceWindow();
            referenceWindow.EmpName = dgvEmployees["txtFullName", dgvEmployees.CurrentCell.RowIndex].Value.ToString();
            referenceWindow.ShowDialog(this);
        }
        #endregion

        #region Вспомогательные
        private bool isValidData()
        {
            return txtName.Text != null && cmbDepartment.SelectedIndex != -1;
        }

        private void ClearAddingFields()
        {
            txtName.Text = null;
            txtPhone.Text = null;
            cmbDepartment.SelectedIndex = -1;
        }
        #endregion
    }
}
