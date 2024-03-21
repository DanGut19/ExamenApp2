using ExamenApp2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp2.Services
{
    internal class ProveedoresServices
    {
        private readonly SQLiteConnection _dbConnection;

        public ProveedoresServices()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Proveedores.db3");
            _dbConnection = new SQLiteConnection(dbPath);
            _dbConnection.CreateTable<Proveedores>();
        }

        public List<Proveedores> GetAll() 
        {
            return _dbConnection.Table<Proveedores>().ToList();
        }

        public int Insert(Proveedores proveedores) 
        {
            return _dbConnection.Insert(proveedores);
        }

        public int Update(Proveedores proveedores)
        {
            return _dbConnection.Update(proveedores);
        }

        public int Delete(Proveedores proveedores)
        {
            return _dbConnection.Delete(proveedores);
        }
    }
}
