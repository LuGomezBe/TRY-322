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
    public partial class ClienteUserModificar : Form
    {
        public ClienteUserModificar()
        {
            InitializeComponent();
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvCliente);
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.modificarCliente(txtId, txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.DeleteCliente(txtId);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente admin = new Cliente();
            admin.ShowDialog();
        }

        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionCliente(dgvCliente, txtId, txtNombre, txtApellido, txtDni, txtTelefono);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.ResetCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*IntPtr region = CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30);
            SetWindowRgn(button1.Handle, region, true);*/

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region3, true);
        }
    }
}
