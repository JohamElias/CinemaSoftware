using CinemaSoftLP2.ServiceWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSoftLP2
{
    public partial class frmBusquedaPeliculas : Form
    {
        private pelicula _pelicula;
        private BindingList<pelicula> peliculas;
        public pelicula peliculaSeleccionada { get => _pelicula; set => _pelicula = value; }
        private ServiceWSClient daoService = new ServiceWSClient();
        public frmBusquedaPeliculas()
        {
            InitializeComponent();
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = peliculas;
            
        }

        private void dgvPeliculas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            pelicula pelicula = (pelicula)dgvPeliculas.Rows[e.RowIndex].DataBoundItem;
            dgvPeliculas.Rows[e.RowIndex].Cells[0].Value = pelicula.idPelicula;
            dgvPeliculas.Rows[e.RowIndex].Cells[1].Value = pelicula.titulo;
            dgvPeliculas.Rows[e.RowIndex].Cells[2].Value = pelicula.duracion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource= daoService.ListarPeliculasPorTitulo(txtTitulo.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvPeliculas.CurrentRow.DataBoundItem!= null)
            {
                _pelicula = (pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
