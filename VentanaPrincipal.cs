using ClasesCap10.Ejercicio_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClasesCap10
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Ejercicio2button_Click(object sender, EventArgs e)
        {
            FormularioEstudiantes formu = new FormularioEstudiantes();
            formu.Show();
        }
    }
}
