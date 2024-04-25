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
        private DbService<Products> _db;

        public ProductsWindow()
        {
            InitializeComponent();
            cmbZnak.SelectedIndex = 0;
        }

        #region Инициализация и настройка
        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            _db = new DbService<Products>(this.productsBindingSource);
        }
        #endregion

        #region Изменение таблицы
        #region Удаление
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
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidData())
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
        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _db.SaveChanges();
        }

        #endregion

        #region Фильтрация
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

            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                int price = int.Parse(txtPrice.Text);
                switch (cmbZnak.SelectedItem)
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
        #endregion

        #region Вспомогательные
        private bool isValidData()
        {
            return txtName.Text != "" && int.TryParse(txtPrice.Text, out _);
        }
        #endregion
    }
}
