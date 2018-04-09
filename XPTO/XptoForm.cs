using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace XPTO
{
    public partial class XptoForm : Form
    {
        XptoClass xpto = new XptoClass();
        public XptoForm()
        {
            InitializeComponent();
        }
        private void btnGerarDV_Click(object sender, EventArgs e)
        {
            xpto.GerarDV();
        }
        private void btnVerificarMatriculas_Click(object sender, EventArgs e)
        {
            xpto.VerificarDV();
        }
    }
}
