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
    public partial class frmBusquedaActores : Form
    {
        private ServiceWS.actor _actorSeleccionado;
        public ServiceWS.actor actorSeleccionado { get => _actorSeleccionado; set => _actorSeleccionado = value; }

        private ServiceWSClient _serviceWSClient= new ServiceWSClient();
        public frmBusquedaActores()
        {
            InitializeComponent();
            dgvActores.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvActores.DataSource = _serviceWSClient.ListarActoresPorNombre(txtNombre.Text);
        }

        private void dgvActores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServiceWS.actor actor = (ServiceWS.actor)dgvActores.Rows[e.RowIndex].DataBoundItem;
            dgvActores.Rows[e.RowIndex].Cells[0].Value = actor.idActor;
            dgvActores.Rows[e.RowIndex].Cells[1].Value = actor.nombre + " " + actor.apellidoPaterno;
            dgvActores.Rows[e.RowIndex].Cells[2].Value = actor.nacionalidad;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvActores.CurrentRow.DataBoundItem != null)
            {
                actorSeleccionado = (ServiceWS.actor)dgvActores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
