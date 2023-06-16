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
    public partial class AsignarModificar : Form
    {
        public AsignarModificar()
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte, txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
            MessageBox.Show("Se elimino correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = string.Empty;
            txtTecnico.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtMarca.Text = string.Empty;
        }

        private void AsignarModificar_Load(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.modificarReporte(txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);

            IntPtr region = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30);
            SetWindowRgn(panel4.Handle, region3, true);


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarRe admin = new AsignarRe();
            admin.ShowDialog();
        }

        private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte, txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.modificarReporte(txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }
    }
}
