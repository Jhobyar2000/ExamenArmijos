using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenArmijos.model
{
    public class metodos:ConexionBD
    {
        //Metodo de llenado de combo
        public void fillCombox(ComboBox mycombo)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable = new DataTable();
                Command.Connection = connectionBD;
                Command.CommandText = "getSexo";
                Command.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientds);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                clientsTable = clientds.Tables[0];
                try
                {

                    for (int i = 0; i < clientsTable.Rows.Count; i++)
                    {
                        DataRow rowClient = clientsTable.Rows[i];
                        mycombo.Items.Add(rowClient["descripcion"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" " + ex);
            }
        }


        public void registerClient(string id,string cedula, string nombre, string apellido, string genero, string fechanac)
        {
            try
            {
                int categoria = 1;
                int numero = Int32.Parse(id);
                Command.Connection = connectionBD;
                Command.CommandText = "registercliente";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@id", numero);
                Command.Parameters.AddWithValue("@cedula", cedula);
                Command.Parameters.AddWithValue("@nombre", nombre);
                Command.Parameters.AddWithValue("@apellido", apellido);
                Command.Parameters.AddWithValue("@genero", genero);
                Command.Parameters.AddWithValue("@fechanac", fechanac);
                Command.Parameters.AddWithValue("@cat", categoria);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
                MessageBox.Show("Se ha registrado cliente" + apellido +" "+ nombre);
            }
            catch (MySqlException ex)
            {
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
                MessageBox.Show("" + ex);
            }

        }

        //Lenar tabla
        public void getListClient(DataGridView tb_client)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable = new DataTable();
                Command.Connection = connectionBD;
                Command.CommandText = "getClients";
                Command.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientds);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                clientsTable = clientds.Tables[0];
                tb_client.Rows.Clear();
                try
                {
                    for (int i = 0; i < clientsTable.Rows.Count; i++)
                    {
                        DataRow rowClient = clientsTable.Rows[i];
                        DataGridViewRow row = (DataGridViewRow)tb_client.Rows[i].Clone();
                        row.Cells[0].Value = rowClient["idCliente"].ToString();
                        row.Cells[1].Value = rowClient["cedula"].ToString();
                        row.Cells[2].Value = rowClient["nombre"].ToString();
                        row.Cells[3].Value = rowClient["apellido"].ToString();
                        row.Cells[4].Value = rowClient["genero"].ToString();
                        row.Cells[5].Value = rowClient["descripcion"].ToString();
                        row.Cells[6].Value = rowClient["fechaNacimiento"].ToString();
                        row.Cells[7].Value = rowClient["categoria"].ToString();
                        tb_client.Rows.Add(row);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

    }
}
