using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasEscritorio
{
    public partial class NotasForm : Form
    {
        private List<Notas> Inventario = new List<Notas>();

        private BindingSource ConexionDatos = new BindingSource();

        public NotasForm()
        {
            InitializeComponent();
            ConexionDatos.DataSource = GuardadoDeArchivos.Obtener();
            this.dataGridView1.DataSource = ConexionDatos;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Notas nuevaNota = new Notas();
            nuevaNota.NombreDeEstudiante = txtNombre.Text;
            nuevaNota.Parcial1 = txtParcial1.Text;
            nuevaNota.Parcial2 = txtParcial2.Text;
            nuevaNota.Proyecto = txtProyecto.Text;
            nuevaNota.Talleres = txtTalleres.Text;
            nuevaNota.Participacion = txtParticipacion.Text;
            nuevaNota.Git = txtGit.Text;

            ConexionDatos.Add(nuevaNota);
            Inventario.Add(nuevaNota);

            GuardadoDeArchivos.Guardar(nuevaNota);


            txtNombre.Text = "";
            txtParcial1.Text = "";
            txtParcial2.Text = "";
            txtProyecto.Text = "";
            txtTalleres.Text = "";
            txtParticipacion.Text = "";
            txtGit.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
        
}
    
