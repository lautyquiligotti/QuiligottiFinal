using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QuiligottiFinal
{
    public class Productos
    {
        string cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public Productos()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Quiligotti.accdb";

            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Productos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            // Estas lineas se escriben para decirle al programa cuál es la Primary Key.
            // 
            DataColumn[] vec = new DataColumn[1]; // Creo un vector de una posicion para almacenar una columna
            vec[0] = tabla.Columns["Id"]; // Cargo la columna en el vector
            tabla.PrimaryKey = vec; // Defino que la primary key de la tabla es la columna guardada en el vector
        }

        public DataTable GetData()
        {
            return tabla;
        }

        public void GrabarProductos(string id, string nombre, string fecha)
        {
            try
            {
                foreach (DataRow datos in tabla.Rows)
                {             
                    tabla.Rows.Add(id, nombre, fecha);
                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(tabla);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
