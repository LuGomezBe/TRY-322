﻿using System;
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
    public partial class ClienteUser : Form
    {
        public ClienteUser()
        {
            InitializeComponent();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.guardarCliente(txtNombre, txtApellido, txtDni, txtTelefono, cmbTipoE, txtMarca, txtDescripcion, lblFecha, lblHora);
            MessageBox.Show("Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.guardarTrabajo(txtDni, cmbTipoE, txtMarca, txtDescripcion, txtEstado);
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cmbTipoE.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteUser_Load(object sender, EventArgs e)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region, true);

            /*IntPtr region1 = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region1, true);*/

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30);
            SetWindowRgn(panel4.Handle, region3, true);





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioUsuario usuario = new InicioUsuario();
            usuario.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteUserModificar admin = new ClienteUserModificar();
            admin.ShowDialog();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
