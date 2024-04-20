using BD_6.Forms;
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

namespace BD_6
{
    public partial class DepartmentsWindow : Form
    {
        private const int DGV_SCROLL_OFFSET = 5;
        private ApplicationContext _context = new ApplicationContext();

        public DepartmentsWindow()
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void DepartmentsWindow_Load(object sender, EventArgs e)
        {
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Departments.Load();
            this.departmentBindingSource.DataSource = _context.Departments.Local.ToBindingList();
        }

        #region Навигация
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvDepartments.SelectedRows[0].Index;
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
            int currentIndex = dgvDepartments.SelectedRows[0].Index;
            if (currentIndex < dgvDepartments.Rows.Count - 1)
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
            dgvDepartments.ClearSelection();
            dgvDepartments.Rows[index].Selected = true;
            dgvDepartments.FirstDisplayedScrollingRowIndex = Math.Max(0, index - DGV_SCROLL_OFFSET);
        }
        #endregion

        #region Изменение таблицы

        #region Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvDepartments_UserDeletingRow(null,
                new DataGridViewRowCancelEventArgs(dgvDepartments.SelectedRows[0]));
        }

        private void dgvDepartments_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("Вы уверены, что хотите удалить данные? Этот процесс необратим"
            , "Предупреждение!"
            , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            this.departmentBindingSource.RemoveAt(e.Row.Index);
            ValidateBinding();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым!");
                return;
            }

            this.departmentBindingSource.DataSource = _context.Departments.Local.ToBindingList();
            _context.Departments.Add(new Department() { name = txtName.Text });
            ValidateBinding();
        }

        private void dgvDepartments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ValidateBinding();
        }

        private void ValidateBinding()
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            _context.SaveChanges();
        }

        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            DepartmentReportWindow report = new DepartmentReportWindow();
            report.ShowDialog();
        }

        private void DepartmentsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filteredData = _context.Departments.Local.ToBindingList()
                .Where(x => x.name.Contains(txtName.Text));

            this.departmentBindingSource.DataSource = filteredData.Count() > 0 ?
                filteredData : filteredData.ToArray();
        }

        private void btnNextEntry_Click_1(object sender, EventArgs e)
        {

        }
    }
}
