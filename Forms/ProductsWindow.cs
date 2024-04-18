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
    public partial class ProductsWindow : Form
    {
        public ProductsWindow()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.products". При необходимости она может быть перемещена или удалена.

        }

        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnFirstEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnNextEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnLastEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text=="")
            {
                MessageBox.Show("Неверные данные!");
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
