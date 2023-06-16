﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Equipo : Form
    {
        public Equipo()
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipoModificar admin = new EquipoModificar();
            admin.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.guardarEquipo(txtDni, cmbTipoE, txtMarca, txtDescripcion, lblFecha, lblHora);
            MessageBox.Show("Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDni.Text = string.Empty;
            cmbTipoE.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Equipo_Load(object sender, EventArgs e)
        {

            IntPtr region = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region, true);

            /*IntPtr region1 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region1, true);*/

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region3, true);

            /*IntPtr region4 = CreateRoundRectRgn(0, 0, SelectT.Width, SelectT.Height, 30, 30);
            SetWindowRgn(SelectT.Handle, region4, true);*/

            /*IntPtr region5 = CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 30, 30);
            SetWindowRgn(btnReset.Handle, region5, true);*/

            IntPtr region6 = CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30);
            SetWindowRgn(panel4.Handle, region6, true);

            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.LlenarDNIComboBox(cmbDni_C);

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.ResetEquipo();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }


        private void cmbMoA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMoA.SelectedIndex == 0)
            {
                cmbDni_C.Visible = false;
                txtDni.Visible = true;
            }
            if (cmbMoA.SelectedIndex == 1)
            {
                cmbDni_C.Visible = true;
                txtDni.Visible = false;
            }
        }
    }
}
