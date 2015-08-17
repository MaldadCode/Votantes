using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace _1Main.Controlador
{
    public class VotantesDbController
    {
        private OleDbConnection _connection;
        private OleDbCommand _command;
        private string _dbObjectName; //The private field for the 'DbObjectName'
        private string _dbObjectPath; //The private field for the 'DbObjectPath'
        private string RootPathDb //This is the Path to the main Directory of the project (Can't be changed, doesn't have the 'set' accessor)
        {
            get
            {
                string rootPath =
                Directory.GetParent(
                    Directory.GetParent(
                        Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
                    ).ToString()
                ).ToString() + @"\Db";
                
                return rootPath;
            }
        }
        /*Thinking it well, i wanted to make this dynamically but for that we probably have to make the same with the 'Provider' and if the database has 'user' and 'pass' or
         not that's other things we have to look at but that will be later xD*/
        public string DbObjectName //This is just the name of the Db (It has a default, but can be changed through the instance of this class)
        {
            get { return _dbObjectName ?? (_dbObjectName = "padron.dbf"); }
            set { _dbObjectName = value; }
        }
        private string DbObjectPath //This is the Path and the Name of the Db concatenated (Can't be changed, doesn't have the 'set' accessor)
        {
            get
            {
                _dbObjectPath = string.Format(@"{0}\{1}", RootPathDb, DbObjectName);

                return _dbObjectPath;
            }
        }

        private void ConnectTo(string dbObjectPath)
        {
            _connection = new OleDbConnection(string.Format(@"Provider=vfpoledb;Data Source={0};Persist Security Info=False", dbObjectPath));
            _command = _connection.CreateCommand();
        }

        public VotantesDbController(string dbObjectName = null)
        {
            DbObjectName = dbObjectName;
            ConnectTo(DbObjectPath);
        }

        //select un proyectos
        public string SelectProyecto()
        {
            try
            {
                string p = "nada";
                _command.CommandText = "SELECT * FROM padron";
                _command.CommandType = CommandType.Text;
                _connection.Open();

                OleDbDataReader reader = _command.ExecuteReader();

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
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }//final un proyectos
    }
}
