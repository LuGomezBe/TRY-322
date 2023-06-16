using MySqlConnector;
using ProyectoSen.Clases;
using System;
using System.Collections;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        //layout

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
        //layout





        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = txtUsuario.Text;
            contraseña = txtContra.Text;
            CConexion objetoConexion = new CConexion();
            
            string query = "SELECT Usuario, Contraseña FROM login WHERE Usuario = @usuario AND Contraseña = @contraseña";
            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            mySqlCommand.Parameters.AddWithValue("@usuario", usuario);
            mySqlCommand.Parameters.AddWithValue("@contraseña", contraseña);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if (String.Equals(usuario, "ADMIN@PERUSIS.COM", StringComparison.OrdinalIgnoreCase) && contraseña == "perusis2023")
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + " ADMIN " + usuario, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioAdmin admin = new InicioAdmin();
                    admin.ShowDialog();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioUsuario formularioP = new InicioUsuario();
                    formularioP.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("No existe ese usuario "+  usuario);
            }
            objetoConexion.cerrarConexion();
        }

        private void Login_Load(object sender, EventArgs e)

        {
            //this is for login load
            panel2.Location = new Point(
                this.ClientSize.Width /2 - panel2.Size.Width/2,
                this.ClientSize.Width /2 - panel2.Size.Width/2

                );
            panel2.Anchor = AnchorStyles.None;
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 
            panel2.Width, panel2.Height, 30, 30));

            IntPtr region = CreateRoundRectRgn(0, 0, btnIngresar.Width, btnIngresar.Height, 30, 30);
            SetWindowRgn(btnIngresar.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, txtUsuario.Width, txtUsuario.Height, 30, 30);
            SetWindowRgn(txtUsuario.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, txtContra.Width, txtContra.Height, 30, 30);
            SetWindowRgn(txtContra.Handle, region2, true);



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           //
            Application.Exit();
           
        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.LightSteelBlue;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if( txtContra.Text == "")
            {
                txtContra.Text = "Ingrese su contraseña";
                txtContra.ForeColor = Color.LightSteelBlue;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Ingrese su contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void ckbMuestra_CheckedChanged(object sender, EventArgs e)
        {
            if( ckbMuestra.Checked == true )
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar= true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
