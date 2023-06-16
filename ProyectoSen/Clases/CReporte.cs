using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoSen.Clases
{
    internal class CReporte

    {
        public void mostrarReporte(DataGridView tablaReporte)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void modificarReporte(TextBox Id,TextBox Dni_T,TextBox Dni_C,TextBox marca)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Reporte set Dni_Tecnico ='" + Dni_T.Text + "',Dni_Cliente ='" + Dni_C.Text + "', Marca='" + marca.Text + "' where Id_Reporte= '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
    
        
        public void guardarTrabajo(TextBox Dni_C, ComboBox TipoE, TextBox Marca,TextBox descripcion,TextBox estado)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into Reporte (DNI_Cliente,Tipo_d_Equipo,Marca,Descripcion_Falla,Estado_de_Equipo)" + "values ('" + Dni_C.Text + "','" + TipoE.Text + "','" + Marca.Text + "','" + descripcion.Text + "','" + estado.Text + "');";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ERROR se guardo los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void guardarReporteC(ComboBox Dni_T, ComboBox Dni_C, TextBox Marca, TextBox estado)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into Reporte (DNI_Tecnico,DNI_Cliente,Marca,Estado_de_Equipo)" + "values ('" + Dni_T.Text + "','" + Dni_C.Text + "','" + Marca.Text + "','" + estado.Text + "');";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ERROR se guardo los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionTecnico(DataGridView tablaTecnico, TextBox Id, TextBox Dni_T, TextBox Dni_C, TextBox marca)
        {
            try
            {

                Id.Text = tablaTecnico.CurrentRow.Cells[0].Value.ToString();
                Dni_T.Text = tablaTecnico.CurrentRow.Cells[1].Value.ToString();
                Dni_C.Text = tablaTecnico.CurrentRow.Cells[2].Value.ToString();
                marca.Text = tablaTecnico.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        

        public void SelecionEquipo(DataGridView tablaTecnico, TextBox Marca)
        {
            try
            {

                Marca.Text = tablaTecnico.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        
        
        public void DeleteReporte(TextBox Id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from Reporte where ID_Reporte = '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void ResetTecnico()
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "TRUNCATE TABLE Reporte;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Reseto los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void BuscarReporte(DataGridView tablaReporte, ComboBox Dni_t)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte where DNI_Tecnico ='" + Dni_t.Text + "';";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No  pueba 1 los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void BuscarEstado(DataGridView tablaReporte ,ComboBox estado)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte where Estado_de_Equipo='" + estado.Text + "';";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionEstado(DataGridView tablaTecnico ,TextBox Id,ComboBox estado)
        {
            try
            {
                Id.Text = tablaTecnico.CurrentRow.Cells[0].Value.ToString();
                estado.Text = tablaTecnico.CurrentRow.Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void UpdateEstado(TextBox Id,ComboBox estado)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Reporte set Estado_de_Equipo ='" + estado.Text + "' where Id_Reporte= '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void BuscarCliente(DataGridView tablaReporte, TextBox Dni_c)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte where DNI_Cliente ='" + Dni_c.Text + "';";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No  pueba 1 los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void guardarEntrega(TextBox Id,ComboBox entrega)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Reporte set Entrega ='" + entrega.Text + "' where Id_Reporte= '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void pordefectoF(TextBox Id, TextBox entrega)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Reporte set Entrega ='" + entrega.Text + "' where Id_Reporte= '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void UpdateTecnico(TextBox Id, ComboBox tecnico)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Reporte set Nombre_Tecnico ='" + tecnico.Text + "' where Id_Reporte= '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
    }
}
