using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;
using _1Main.Modelo;

namespace _1Main.Controlador
{
    public class VotantesDbController
    {
        #region Props and Fields
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
        #endregion

        public VotantesDbController(string dbObjectName = null)
        {
            DbObjectName = dbObjectName;
            ConnectTo(DbObjectPath);
        }

        private void ConnectTo(string dbObjectPath)
        {
            _connection = new OleDbConnection(string.Format(@"Provider=vfpoledb;Data Source={0};Persist Security Info=False", dbObjectPath));
            _command = _connection.CreateCommand();
        }

        public string MigrationDB()
        {
            try
            {
                string p = "No se encontro nada.";
                _command.CommandText = "SELECT * FROM padron";
                _command.CommandType = CommandType.Text;
                _connection.Open();

                OleDbDataReader reader = _command.ExecuteReader();
                var votantes = new List<Votante>();

                if (reader.Read()) //Ready For the Migration
                {
//                    for (int i = 0; i < reader.RecordsAffected; i++)
//                    {
//                        var votante = new Votante();
//                        votante.CodigoProvincia = reader.GetString(0);
//                        votante.Provincia = reader.GetString(1);
//                        votante.Circunscripcion = reader.GetFieldValue<decimal>(2);
//                        votante.CodigoMunicipio = reader.GetString(3);
//                        votante.Municipio = reader.GetString(4);
//                        votante.NombreCI = reader.GetString(5);
//                        votante.Centro = reader.GetString(6);
//                        votante.DireccionCentro = reader.GetString(7);
//                        votante.SectorCentro = reader.GetString(8);
//                        votante.Mesa = reader.GetString(9);
//                        votante.Cedula = reader.GetString(10);
//                        votante.Nombre = reader.GetString(11);
//                        votante.PrimerApellido = reader.GetString(12);
//                        votante.SegundoApellido = reader.GetString(13);
//                        votante.Sexo = reader.GetString(14);
//                        votante.Orden = reader.GetInt32(15);
//
//                        votantes.Add(votante);
//                        reader.Read();
//                    }
//
//                    p = string.Format("Votante 1: {0}\nVotante 2: {1}", votantes[0].Nombre, votantes[1].Nombre);
                }
                return p;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }
    }
}
