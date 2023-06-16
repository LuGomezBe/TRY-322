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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            
        }
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteModificar admin = new ClienteModificar();
            admin.ShowDialog();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            //this is for login load

            //btnRegistrarC.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnRegistrarC.Width, btnRegistrarC.Height,30,30));
            /*IntPtr region = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region, true);*/

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region2, true);


            /*IntPtr region3 = CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30);
            SetWindowRgn(button2.Handle, region3, true);*/


            IntPtr region4 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30);
            SetWindowRgn(panel4.Handle, region5, true);





            //   panel2.Location = new Point(
            // this.ClientSize.Width / 2 - panel2.Size.Width / 2,
            //  this.ClientSize.Width / 2 - panel2.Size.Width / 2

            //    );
            // panel2.Anchor = AnchorStyles.None;
            // panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,
            // panel2.Width, panel2.Height, 30, 30));
            /*IntPtr region4 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 30, 30);
            SetWindowRgn(btnReset.Handle, region5, true);

            IntPtr region6 = CreateRoundRectRgn(0, 0, dgvCliente.Width, dgvCliente.Height, 30, 30);
            SetWindowRgn(dgvCliente.Handle, region6, true);*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
             Clases.CCliente objetoCliente = new Clases.CCliente();
             objetoCliente.guardarCliente(txtNombre, txtApellido, txtDni, txtTelefono,cmbTipoE ,txtMarca,txtDescripcion,lblFecha,lblHora);
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            ClienteModificar user = new ClienteModificar();
            user.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
