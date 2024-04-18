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
    public partial class ProvidersWindow : Form
    {
        public ProvidersWindow()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void ProvidersWindow_Load(object sender, EventArgs e)
        {
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
            if (txtName.Text == "")
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
