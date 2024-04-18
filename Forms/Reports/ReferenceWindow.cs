using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD_6.Forms.Reports
{
    public partial class ReferenceWindow : Form
    {
        public string EmpName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _name;

        public ReferenceWindow()
        {
            InitializeComponent();
        }

        private void ReferenceWindow_Load(object sender, EventArgs e)
        {
            DataTable dummyData = new DataTable();
            dummyData.Columns.Add("DummyColumn");
            dummyData.Rows.Add("DummyValue");
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("shopDataSet", dummyData));

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("pFIO", _name, true);
            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
