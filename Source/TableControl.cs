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

namespace BD_6.Forms
{
    public partial class TableControl : UserControl
    {
        private const int DGV_SCROLL_OFFSET = 5;

        public BindingSource TableBindingSource
        {
            get
            {
                return _tableBindingSource;
            }
            set
            {
                _tableBindingSource = value;
            }
        }
        public BindingList<T> DbTable;

        private BindingSource _tableBindingSource;
        private BindingList<T> _dbTable;
        private DbContext _dbContext;

        public TableControl()
        {
            InitializeComponent();
            _dbContext = (DbContext)_dbTable.GetType().GetField("_context").GetValue(_dbTable);
        }

        #region Навигация
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = this.dgvTable.SelectedRows[0].Index;
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
            int currentIndex = this.dgvTable.SelectedRows[0].Index;
            if (currentIndex < this.dgvTable.Rows.Count - 1)
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
            this.dgvTable.ClearSelection();
            this.dgvTable.Rows[index].Selected = true;
            this.dgvTable.FirstDisplayedScrollingRowIndex = Math.Max(0, index - DGV_SCROLL_OFFSET);
        }
        #endregion

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }

        }

        public virtual bool CheckData() { return true; }

        private void ValidateBinding()
        {
            this.Validate();
            _tableBindingSource.EndEdit();
            _dbContext.SaveChanges();
        }
    }
}
