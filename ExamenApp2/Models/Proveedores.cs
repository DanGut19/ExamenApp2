using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp2.Models
{
    public class Proveedores
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Empresa { get; set; }
        public string Producto { get; set; }


    }
}
