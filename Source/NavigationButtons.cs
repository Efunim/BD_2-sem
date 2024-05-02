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
    public partial class NavigationButtons : UserControl
    {
        private DataGridView _dgvTable;
        private const int DGV_SCROLL_OFFSET = 5;

        public DataGridView DgvTable
        {
            get { return _dgvTable; }
            set 
            { 
                _dgvTable = value;
            }
        }

        public NavigationButtons()
        {
            InitializeComponent();
        }
        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
            int currentIndex = this._dgvTable.CurrentRow.Index;
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
            int currentIndex = this._dgvTable.SelectedRows[0].Index;
            if (currentIndex < this._dgvTable.Rows.Count - 1)
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
            _dgvTable.ClearSelection();
            _dgvTable.Rows[index].Selected = true;
            _dgvTable.FirstDisplayedScrollingRowIndex = Math.Max(0, index - DGV_SCROLL_OFFSET);
        }

    }
}
