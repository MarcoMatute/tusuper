using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuSuper.BL;

namespace TuSuper.Win
{
    public partial class Form2 : Form
    {
        ReportedeVentasporProductoBL _reporteVentasPorProdcutoBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentasPorProdcutoBL = new ReportedeVentasporProductoBL();
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
        private void RefrescarDatos()
        {
            var listadeVentasPorProductos = _reporteVentasPorProdcutoBL.ObtenerVentasPorProdcuto();
            listadeVentasPorProdcutoBindingSource.DataSource = listadeVentasPorProductos;
            listadeVentasPorProdcutoBindingSource.ResetBindings(false);           

        }
    }
}
