using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class AsignarModificarUser : Form
    {
        public AsignarModificarUser()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWithEllipse,
           int nHeightEllipse

           );
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte, txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.DeleteReporte( txtId);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.modificarReporte(txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarReUser user = new AsignarReUser();
            user.ShowDialog();
        }

        private void AsignarModificarUser_Load(object sender, EventArgs e)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region2, true);
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
