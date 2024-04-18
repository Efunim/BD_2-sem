using BD_6.Forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6
{
    public partial class EmployeesWindow : Form
    {
        public EmployeesWindow()
        {
            InitializeComponent();
        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            MainMenu.Context.Departments.Load();
            MainMenu.Context.Employees.Load();

            var employeeList = MainMenu.Context.Employees.Local.ToList();

            this.employeesBindingSource.DataSource = employeeList;
            this.departmentBindingSource.DataSource = MainMenu.Context.Departments.Local.ToBindingList();

            cmbDepartment.SelectedIndex = -1;
        }

        #region Навигация
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            
        }
        private void btnNextEntry_Click(object sender, EventArgs e)
        {

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

        private void dgvEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var property = ((DataGridViewColumn)sender).DataPropertyName;
            
        }

        #region Изменение таблицы

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            int? depId = (int?)cmbDepartment.SelectedValue;

            if(name == "" || depId == null)
            {
                MessageBox.Show("Неккоретные данные!");
                return;
            }

            using (var context = new ApplicationContext())
            {
                Employees newEmp = new Employees()
                {
                    full_name = name,
                    departmentID = depId.Value,
                    phone_number = phone == "" ? null : phone
                };

                context.Employees.Add(newEmp);
                context.SaveChanges();
            }
        }

        private void dgvEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            using(var context = new ApplicationContext())
            {
                int id = (int)dgvEmployees["clmnId", e.RowIndex].Value;
                var employee = context.Employees.Find(id);
                if (employee != null)
                {
                    var propertyName = dgvEmployees.Columns[e.ColumnIndex].DataPropertyName;
                    typeof(Employees).GetProperty(propertyName)?
                                     .SetValue(employee
                                     ,dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                context.SaveChanges();
            }            
        }

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmployees.UserDeletingRow += dgvEmployees_UserDeletingRow;
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

            using (var context = new ApplicationContext())
            {
                int id = (int)dgvEmployees["clmnId", e.Row.Index].Value;
                var employee = context.Employees.Find(id);
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
        #endregion

        #endregion

    }
}
