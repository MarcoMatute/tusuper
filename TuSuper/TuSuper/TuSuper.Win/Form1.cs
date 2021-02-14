﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProducutos();

            foreach (var producto in listadeProductos)
            {
                MessageBox.Show(producto.Descripcion);

            }
        }
    }
}