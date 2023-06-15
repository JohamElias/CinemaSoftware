using CinemaSoftLP2.ServiceWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSoftLP2
{
    public partial class frmGestionPeliculas : Form
    {
        private Estado _estado;
        private string _rutaFotoPortada;
        private ServiceWS.actor actor;
        private ServiceWSClient daoService=new ServiceWSClient();
        private BindingList<actor> actores = new BindingList<actor>();
        private ServiceWS.pelicula pelicula;
        public frmGestionPeliculas()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            cboGenero.ValueMember = "idGenero";
            cboGenero.DisplayMember = "Nombre";
            cboGenero.DataSource=daoService.ListarGeneros();
            dgvActores.AutoGenerateColumns = false;
            dgvActores.DataSource=actores;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {
            txtIDPelicula.Text = "";
            txtTitulo.Text = "";
            dtpFechaEstreno.Value = DateTime.Now;
            cboGenero.SelectedIndex = -1;
            dtpDuracion.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 01, 30, 00);
            cbSubtitulada.Checked = false;
            cbDoblada.Checked = false;
            txtSinopsis.Text = "";
            pbPortada.Image = null;
            _rutaFotoPortada = "";
            dgvActores.DataSource = null;
            txtIDActor.Text = "";
            txtNombreCompletoActor.Text = "";
        }
        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDPelicula.Enabled = false;
                    txtTitulo.Enabled = false;
                    dtpFechaEstreno.Enabled = false;
                    cboGenero.Enabled = false;
                    dtpDuracion.Enabled = false;
                    cbDoblada.Enabled = false;
                    cbSubtitulada.Enabled = false;
                    txtSinopsis.Enabled = false;
                    btnSubirPortada.Enabled = false;
                    txtIDActor.Enabled = false;
                    txtNombreCompletoActor.Enabled = false;
                    btnBuscarActor.Enabled = false;
                    btnAgregarActor.Enabled = false;
                    btnEliminarActor.Enabled = false;
                    dgvActores.Enabled = false;
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDPelicula.Enabled = true;
                    txtTitulo.Enabled = true;
                    dtpFechaEstreno.Enabled = true;
                    cboGenero.Enabled = true;
                    dtpDuracion.Enabled = true;
                    cbDoblada.Enabled = true;
                    cbSubtitulada.Enabled = true;
                    txtSinopsis.Enabled = true;
                    btnSubirPortada.Enabled = true;
                    txtIDActor.Enabled = true;
                    txtNombreCompletoActor.Enabled = true;
                    btnBuscarActor.Enabled = true;
                    btnAgregarActor.Enabled = true;
                    btnEliminarActor.Enabled = true;
                    dgvActores.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDPelicula.Enabled = false;
                    txtTitulo.Enabled = false;
                    dtpFechaEstreno.Enabled = false;
                    cboGenero.Enabled = false;
                    dtpDuracion.Enabled = false;
                    cbDoblada.Enabled = false;
                    cbSubtitulada.Enabled = false;
                    txtSinopsis.Enabled = false;
                    btnSubirPortada.Enabled = false;
                    txtIDActor.Enabled = false;
                    txtNombreCompletoActor.Enabled = false;
                    btnBuscarActor.Enabled = false;
                    btnAgregarActor.Enabled = false;
                    btnEliminarActor.Enabled = false;
                    dgvActores.Enabled = false;
                    break;
            }
        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaFotoPortada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscarActor_Click(object sender, EventArgs e)
        {
            frmBusquedaActores frmBusquedaActores = new frmBusquedaActores();
            if(frmBusquedaActores.ShowDialog() == DialogResult.OK)
            {
                actor = frmBusquedaActores.actorSeleccionado;
                txtIDActor.Text=actor.idActor.ToString();
                txtNombreCompletoActor.Text=actor.nombre+" "+actor.apellidoPaterno;
            }
        }

        private void btnAgregarActor_Click(object sender, EventArgs e)
        {
            if(actor!=null)
            {
                actores.Add(actor);
                dgvActores.DataSource=actores;
                actor = null;
                txtIDActor.Text = "";
                txtNombreCompletoActor.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pelicula=new ServiceWS.pelicula();

            pelicula.titulo = txtTitulo.Text;
            pelicula.fechaEstrenoSpecified = true;
            pelicula.fechaEstreno=dtpFechaEstreno.Value;
            pelicula.genero=new genero();
            pelicula.genero.idGenero = cboGenero.SelectedIndex;
            pelicula.duracion=dtpDuracion.Value.ToString("hh:mm");
            if (cbDoblada.Checked) pelicula.disponibleDoblada = true;
            else pelicula.disponibleDoblada=false;
            if (cbSubtitulada.Checked) pelicula.disponibleSubtitulada = true;
            else pelicula.disponibleSubtitulada = false;
            pelicula.sinopsis=txtSinopsis.Text;
            pelicula.actores = actores.ToArray();
            FileStream fs = new FileStream(_rutaFotoPortada,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            pelicula.portada = br.ReadBytes((int)fs.Length);
            fs.Close();
            int resultado=daoService.GuardarPelicula(pelicula);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha registrado con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDPelicula.Text = resultado.ToString();
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actores = new BindingList<actor>();
        }

        private void btnEliminarActor_Click(object sender, EventArgs e)
        {
            if(dgvActores.CurrentRow.DataBoundItem != null)
            {
                try { actores.Remove((actor)dgvActores.CurrentRow.DataBoundItem); }
                catch { }
            }
        }

        private void dgvActores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            actor actor = (actor)dgvActores.Rows[e.RowIndex].DataBoundItem;
            dgvActores.Rows[e.RowIndex].Cells[0].Value = actor.nombre+" "+actor.apellidoPaterno;
            dgvActores.Rows[e.RowIndex].Cells[1].Value = actor.nacionalidad;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPeliculas frmBusquedaPeliculas=new frmBusquedaPeliculas();
            if (frmBusquedaPeliculas.ShowDialog() == DialogResult.OK)
            {
                pelicula = frmBusquedaPeliculas.peliculaSeleccionada;
                txtIDPelicula.Text = pelicula.idPelicula.ToString();
                //actores = new BindingList<actor>(pelicula.actores);
                txtSinopsis.Text = pelicula.sinopsis.ToString();
                dtpDuracion.Value = DateTime.ParseExact(pelicula.duracion, "hh:mm", null);
                MemoryStream ms = new MemoryStream(pelicula.portada);
                pbPortada.Image = new Bitmap(ms);
                if (pelicula.disponibleDoblada) cbDoblada.Checked = true;
                if (pelicula.disponibleSubtitulada) cbSubtitulada.Checked = true;
                cboGenero.SelectedValue = pelicula.genero.idGenero;
            }
        }
    }
}
