using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaMensual
{
    public partial class frmVisualizando : Form
    {
        public frmVisualizando(string nombre_reporte)
        {
            InitializeComponent();



            ReportDocument cryRpT = new ReportDocument();

            cryRpT.Load(nombre_reporte);
            crystalReportViewer1.ReportSource = cryRpT;
            crystalReportViewer1.Refresh();



        }

        private void frmVisualizando_Load(object sender, EventArgs e)
        {

        }
    }
}
