using PrefinalProgramacionPunto3D.Datos;
using PrefinalProgramacionPunto3D.Entidades;

namespace PrefinalProgramacionPunto3D.Windows
{
    public partial class frmPuntos : Form
    {
        public frmPuntos()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPunto3DAe formularioPuntos = new frmPunto3DAe();
            formularioPuntos.Show();
        }
    }
    public partial class frmPuntos : Form
    {
        private RepositorioPuntos repo = new RepositorioPuntos();
        private List<Punto3D> lista = new List<Punto3D>();
        private int cantidad;

        private void frmPuntos_Load(object sender, EventArgs e)
        {
            cantidad = repo.GetCantidad();
            if (cantidad > 0)
            {
                lista = repo.GetPuntos();
                MostrarDatosEnGrilla();
            }
            MostrarCantidad();
        }

        private void MostrarCantidad()
        {
            txtCantidad.Text = cantidad.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var punto in lista)
            {
                var r = ConstruirFila();
                SetearFila(r, punto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Punto3D punto)
        {
            r.Cells[colX.Index].Value = punto.X;
            r.Cells[colY.Index].Value = punto.Y;
            r.Cells[colZ.Index].Value = punto.Z;
            r.Cells[colColor.Index].Value = punto.Color;
            r.Tag = punto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

  
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Punto3D nuevoPunto = new Punto3D(10, 20, 30, "Rojo");

            if (repo.AgregarPunto(nuevoPunto))
            {
                lista = repo.GetPuntos();
                MostrarDatosEnGrilla();
                cantidad = repo.GetCantidad();
                MostrarCantidad();
                MessageBox.Show("Punto agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El punto ya existe en el repositorio.");
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var rSeleccionada = dgvDatos.SelectedRows[0];
            Punto3D puntoSeleccionado = (Punto3D)rSeleccionada.Tag;

            DialogResult dr = MessageBox.Show($"¿Desea borrar el punto {puntoSeleccionado}?",
                                              "Confirmar", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;

            repo.Borrar(puntoSeleccionado);
            dgvDatos.Rows.Remove(rSeleccionada);
            cantidad = repo.GetCantidad();
            MostrarCantidad();
            MessageBox.Show($"Punto {puntoSeleccionado} borrado.");
        }
    }
}

