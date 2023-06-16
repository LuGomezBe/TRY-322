using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class ActualizarEstadoE_Admin : Form
    {
        public ActualizarEstadoE_Admin()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            if (cmbEstadoE.Text == "NUEVO")
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.BuscarEstado(dgvReporte, cmbEstadoE);
            }
            if (cmbEstadoE.Text == "PROCESO")
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.BuscarEstado(dgvReporte, cmbEstadoE);
            }
            if (cmbEstadoE.Text == "FINALIZADO")
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.BuscarEstado(dgvReporte, cmbEstadoE);

            }
            else
            {
                cmbEstadoE.Text = "Elija una opcion";
            }
        }

        private void ActualizarEstadoE_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {

        }

        /*private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionEstado(dgvReporte, txtId,cmbEstado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtEstado.Text == "FINALIZADO")
            {
                Clases.CReporte objetoReportee = new Clases.CReporte();
                objetoReportee.UpdateEstado(txtId, cmbEstado);
                objetoReportee.mostrarReporte(dgvReporte);
                objetoReportee.pordefectoF(txtId, txtDefectoE);
                objetoReportee.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                txtEstado.Text = string.Empty;

                txtDefectoE.Text = string.Empty;
            }
            else
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.UpdateEstado(txtId, txtEstado);
                objetoReporte.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                txtEstado.Text = string.Empty;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void cmbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text == "FINALIZADO")
            {
                Clases.CReporte objetoReportee = new Clases.CReporte();
                objetoReportee.pordefectoF(txtId, txtDefectoE);
                objetoReportee.mostrarReporte(dgvReporte);
                txtEstado.Text = string.Empty;

                if (cmbEntrega.Text == "FALTA ENTREGAR")
                {
                    Clases.CReporte objetoReporte = new Clases.CReporte();
                    objetoReporte.guardarEntrega(txtId, cmbEntrega);
                    objetoReporte.mostrarReporte(dgvReporte);
                    cmbEntrega.Text = string.Empty;
                }
                if (cmbEntrega.Text == "ENTREGADO")
                {
                    Clases.CReporte objetoReporte = new Clases.CReporte();
                    objetoReporte.guardarEntrega(txtId, cmbEntrega);
                    objetoReporte.mostrarReporte(dgvReporte);
                    cmbEntrega.Text = string.Empty;                
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Solo se puede modificar si el trabajo esta finalizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
