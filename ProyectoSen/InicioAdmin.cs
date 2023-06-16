using MySqlConnector;
//using ProyectoSen.Clases;   *simplificar clases
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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
            btnBuscarR.Paint += btnBuscarR_Paint;    
        }
        //desde aqui
        //call the function dll
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
//hata aqui copiar


        private void btnRegistrarT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tecnico tecnico= new Tecnico();
            tecnico.ShowDialog();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipo equipo= new Equipo();
            equipo.ShowDialog();
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            //this is for login load
           
            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,
            panel1.Width, panel1.Height, 30, 30));
           // btnRegistrarC.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnRegistrarC.Width, btnRegistrarC.Height,30,30));


            IntPtr region = CreateRoundRectRgn(0, 0, btnCSesion.Width, btnCSesion.Height, 30, 30);
            SetWindowRgn(btnCSesion.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnRegistrarT.Width, btnRegistrarT.Height, 30, 30);
            SetWindowRgn(btnRegistrarT.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnRegistrarC.Width, btnRegistrarC.Height, 30, 30);
            SetWindowRgn(btnRegistrarC.Handle, region2, true);


            /*IntPtr region4 = CreateRoundRectRgn(0, 0, btnAsignar.Width, btnAsignar.Height, 30, 30);
            SetWindowRgn(btnAsignar.Handle, region4, true);*/
            

            IntPtr region5 = CreateRoundRectRgn(0, 0, btnTecnico.Width, btnTecnico.Height, 30, 30);
            SetWindowRgn(btnTecnico.Handle, region5, true);

            IntPtr region6 = CreateRoundRectRgn(0, 0, btnEquipo.Width, btnEquipo.Height, 30, 30);
            SetWindowRgn(btnEquipo.Handle, region6, true);

            IntPtr region7 = CreateRoundRectRgn(0, 0, btnCliente.Width, btnCliente.Height, 30, 30);
            SetWindowRgn(btnCliente.Handle, region7, true);

            /*IntPtr region8 = CreateRoundRectRgn(0, 0, btnBuscarR.Width, btnBuscarR.Height, 30, 30);
            SetWindowRgn(btnBuscarR.Handle, region8, true);

            IntPtr region9 = CreateRoundRectRgn(0, 0, btnBuscar.Width, btnBuscar.Height, 30, 30);
            SetWindowRgn(btnBuscar.Handle, region9, true);*/
            
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.LlenarComboBox(comboBox1);
            Clases.CTecnico objetoTecnicoo = new Clases.CTecnico();
            objetoTecnicoo.LlenarComboBox(cmbBuscarR);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login equipo = new Login();
                equipo.ShowDialog();
            }
            else
            {
                // Código para la acción negativa o cancelada
                // ...
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscar.Text == "TECNICO")
            {
                Clases.CTecnico objetoReporte = new Clases.CTecnico();
                objetoReporte.BuscarTecnico(dgvPrincipal, txtBuscar);

            }

            if (cmbBuscar.Text == "CLIENTE")
            {
                Clases.CCliente objetoReporte = new Clases.CCliente();
                objetoReporte.BuscarCliente(dgvPrincipal, txtBuscar);
            }
            else
            {
                cmbBuscar.Text = "Elija una opcion";
            }
        
    }


        private void btnTecnico_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvPrincipal);
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvPrincipal);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvPrincipal);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingrese DNI";
                txtBuscar.ForeColor = Color.LightSteelBlue;
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingrese DNI")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightSteelBlue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbEstadoE.Text == "PENDIENTE")
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


        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.BuscarReporte(dgvReporte, cmbBuscarR);
        }

        private void btnClienteB_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.BuscarCliente(dgvReporte, txtDni_C);
        }

        private void txtDni_C_Leave(object sender, EventArgs e)
        {
            if (txtDni_C.Text == "")
            {
                txtDni_C.Text = "Ingrese DNI Cliente";
                txtDni_C.ForeColor = Color.LightSteelBlue;
            }
        }

        private void txtDni_C_Enter(object sender, EventArgs e)
        {
            if (txtDni_C.Text == "Ingrese DNI Cliente")
            {
                txtDni_C.Text = "";
                txtDni_C.ForeColor = Color.Black;
            }
        }

        private void btnBuscarR_Paint(object sender, PaintEventArgs e)
        {
            /*Button button = (Button)sender;
            Graphics graphics = e.Graphics;

            int arrowSize = 8; // Tamaño de la flecha
            int x = (button.Width - arrowSize) / 3; // Posición x de la flecha
            int y = (button.Height - arrowSize) / 3; // Posición y de la flecha

            // Dibuja la flecha utilizando la clase Graphics
            using (Font font = new Font("Arial", 14, FontStyle.Bold)) // Fuente para el texto
            {
                using (SolidBrush brush = new SolidBrush(button.ForeColor)) // Pincel para el texto
                {
                    // Dibuja el texto del botón
                    graphics.DrawString("<--", font, brush, x, y);
                }
            }*/
        }

        private void btnBuscarR_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Elija una opcion";
                comboBox1.ForeColor = Color.LightSteelBlue;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Elija una opcion")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbEstado.Text == "FINALIZADO")
            {
                Clases.CReporte objetoReportee = new Clases.CReporte();
                objetoReportee.UpdateEstado(txtId,cmbEstado);
                objetoReportee.mostrarReporte(dgvReporte);
                objetoReportee.pordefectoF(txtId, txtDefectoE);
                objetoReportee.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                cmbEstado.Text = string.Empty;

                txtDefectoE.Text = string.Empty;
            }
            else
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.UpdateEstado(txtId, cmbEstado);
                objetoReporte.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                cmbEstado.Text = string.Empty;
            }
        }

        private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionEstado(dgvReporte, txtId, cmbEstado);
        }

        private void cmbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEntrega.SelectedIndex == 0)
            {
                if (cmbEstado.Text == "FINALIZADO")
                {
                    Clases.CReporte objetoReportee = new Clases.CReporte();
                    objetoReportee.pordefectoF(txtId, txtDefectoE);
                    objetoReportee.mostrarReporte(dgvReporte);
                    cmbEstado.Text = string.Empty;

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
            if (cmbEntrega.SelectedIndex == 1)
            {
                if (cmbEstado.Text == "FINALIZADO")
                {
                    Clases.CReporte objetoReportee = new Clases.CReporte();
                    objetoReportee.pordefectoF(txtId, txtDefectoE);
                    objetoReportee.mostrarReporte(dgvReporte);
                    cmbEstado.Text = string.Empty;

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

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAsigTecnico_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.UpdateTecnico(txtId,comboBox1);
            objetoReporte.mostrarReporte(dgvReporte);
            MessageBox.Show("Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Text = string.Empty;
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            if (cmbEstado.Text == "FINALIZADO")
            {
                Clases.CReporte objetoReportee = new Clases.CReporte();
                objetoReportee.UpdateEstado(txtId, cmbEstado);
                objetoReportee.mostrarReporte(dgvReporte);
                objetoReportee.pordefectoF(txtId, txtDefectoE);
                objetoReportee.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                cmbEstado.Text = string.Empty;

                txtDefectoE.Text = string.Empty;
            }
            else
            {
                Clases.CReporte objetoReporte = new Clases.CReporte();
                objetoReporte.UpdateEstado(txtId, cmbEstado);
                objetoReporte.mostrarReporte(dgvReporte);
                MessageBox.Show("Se actualizo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Text = string.Empty;
                cmbEstado.Text = string.Empty;
            }
        }

        private void cmbEstadoE_Leave(object sender, EventArgs e)
        {
            if (cmbEstadoE.Text == "")
            {
                cmbEstadoE.Text = "Ingrese Estado";
                cmbEstadoE.ForeColor = Color.LightSteelBlue;
            }
        }

        private void cmbEstadoE_Enter(object sender, EventArgs e)
        {
            if (cmbEstadoE.Text == "Ingrese Estado")
            {
                cmbEstadoE.Text = "";
                cmbEstadoE.ForeColor = Color.Black;
            }
        }

        private void cmbTec_Leave(object sender, EventArgs e)
        {
            if (cmbBuscarR.Text == "")
            {
                cmbBuscarR.Text = "Ingrese DNI Tecnico";
                cmbBuscarR.ForeColor = Color.LightSteelBlue;
            }
        }

        private void cmbTec_Enter(object sender, EventArgs e)
        {
            if (cmbBuscarR.Text == "Ingrese DNI Tecnico")
            {
                cmbBuscarR.Text = "";
                cmbBuscarR.ForeColor = Color.Black;
            }
        }
    }
}
