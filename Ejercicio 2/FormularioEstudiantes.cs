using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClasesCap10.Ejercicio_2
{
    public partial class FormularioEstudiantes : Form
    {
        public FormularioEstudiantes()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            EdadtextBox.Clear();
            TelefonotextBox.Clear();
            DirecciontextBox.Clear();
            PromediotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes_escuela estudiantes = new Estudiantes_escuela(NombretextBox.Text, Convert.ToInt32(EdadtextBox.Text), TelefonotextBox.Text, DirecciontextBox.Text, Convert.ToDouble(PromediotextBox.Text)); ;
        }
    }
}
