using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("TOTO") { }
        public ITable<File_Personal> _File_Personal { get { return GetTable<File_Personal>(); } }
    }
}
