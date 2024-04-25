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
    public partial class ProductsWindow : Form
    {
        private const int DGV_SCROLL_OFFSET = 5;

        private DbService<Products> _db;

        public ProductsWindow()
        {
            InitializeComponent();
            cmbZnak.SelectedIndex = 0;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            _db = new DbService<Products>(this.productsBindingSource);
        }

        private void btnPreviousEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnNextEntry_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvProducts_UserDeletingRow(null,
                new DataGridViewRowCancelEventArgs(dgvProducts.CurrentRow));
        }

        private void dgvProducts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !_db.Remove(e.Row.Index);
            this.Validate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!isValidData())
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }

            _db.Add(new Products
            {
                name = txtName.Text,
                price = int.Parse(txtPrice.Text)
            });
        }

        private bool isValidData()
        {
            return txtName.Text != "" && int.TryParse(txtPrice.Text, out _);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _db.FilterData(CreateFilter());
            this.Validate();
        }

        private IQueryable<Products> CreateFilter()
        {
            IQueryable<Products> query = _db.Table.AsQueryable();

            if (!string.IsNullOrEmpty(txtName.Text))
            {
                query = query.Where(x => x.name.Contains(txtName.Text));
            }

            if(!string.IsNullOrEmpty(txtPrice.Text))
            {
                int price = int.Parse(txtPrice.Text);
                switch(cmbZnak.SelectedItem)
                {
                    case "=":
                        query = query.Where(x => x.price == price);
                        break;
                    case ">=":
                        query = query.Where(x => x.price >= price);
                        break;
                    case "<=":
                        query = query.Where(x => x.price <= price);
                        break;
                }
            }

            return query;
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

    }
}
