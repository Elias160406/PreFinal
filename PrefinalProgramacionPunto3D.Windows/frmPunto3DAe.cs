using PrefinalProgramacionPunto3D.Datos;
using PrefinalProgramacionPunto3D.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrefinalProgramacionPunto3D.Windows
{
    public partial class frmPunto3DAe : Form
    {
        public frmPunto3DAe()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            
            int x, y, z;
            string color = txtColor.Text.Trim();

            
            if (!int.TryParse(txtX.Text, out x))
            {
                MessageBox.Show("La coordenada X debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("La coordenada Y debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtZ.Text, out z))
            {
                MessageBox.Show("La coordenada Z debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Punto3D nuevoPunto = new Punto3D(x, y, z, color);
            RepositorioPuntos repositorio = new RepositorioPuntos();

            
            if (repositorio.AgregarPunto(nuevoPunto))
            {
                MessageBox.Show($"Punto agregado: {nuevoPunto}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("El punto con esas coordenadas ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}


