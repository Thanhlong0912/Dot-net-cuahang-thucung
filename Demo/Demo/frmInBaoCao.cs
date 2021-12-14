using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Model;

namespace Demo
{
    public partial class frmInBaoCao : Form
    {
        public frmInBaoCao(DataTable dtHD)
        {
            InitializeComponent();
            rptBaoCao rpt = new rptBaoCao();
            rpt.SetDataSource(dtHD);  
            crystalReportViewer1.ReportSource=rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmInBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
