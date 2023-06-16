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
    public partial class EquipoModificar : Form
    {
        public EquipoModificar()
        {
            InitializeComponent();
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void dgvEquipo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.SelecionEquipo(dgvEquipo, txtId, txtDni ,cmbTipoE,txtMarca,txtDescripcion,lblFecha,lblHora);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.modificarEquipo(txtId, txtDni, cmbTipoE, txtMarca, txtDescripcion, lblFecha, lblHora);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.DeleteEquipo(txtId);
            objetoEquipo.mostrarEquipo(dgvEquipo);
            MessageBox.Show("Se elimino correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EquipoModificar_Load(object sender, EventArgs e)
        {

            IntPtr region = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region, true);


            IntPtr region1 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region1, true);


            IntPtr region3 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region3, true);

            IntPtr region4 = CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30);
            SetWindowRgn(panel4.Handle, region4, true);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
