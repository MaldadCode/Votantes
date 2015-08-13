using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ForTesting
{
    class VisualFoxProConnection
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=vfpoledb;Data Source=db.dbf;Persist Security Info=False");
            command = connection.CreateCommand();
        }
        public VisualFoxProConnection()
        {
            ConnectTo();
        }

        //select un proyectos
        public string selectProyecto()
        {
            try
            {
                string p = "nada";
                command.CommandText = "SELECT * FROM padron";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    p = reader["NOMBRE"].ToString();
                }
                return p;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }//final un proyectos
    }
}
