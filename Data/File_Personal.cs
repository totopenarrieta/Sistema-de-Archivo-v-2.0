using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class File_Personal
    {
        [PrimaryKey, Identity]
        public int Id { set; get; }
        public DateTime Fecha_Ing_Datos { set; get; }
        public string Usuario { set; get; }
        public string CI { set; get; }
        public string Codigo_Archivo { set; get; }
        public string Codigo_Antiguo { set; get; }
        public string Ap_Paterno { set; get; }
        public string Ap_Materno { set; get; }
        public string Nombres { set; get; }
        public string Numero_item { set; get; }
        public string Estado { set; get; }
        public DateTime Fecha_Nac { set; get; }
        public DateTime Fecha_Inc { set; get; }
        public string Cargo { set; get; }
        public string Administracion { set; get; }
        public string File_Url { set; get; }
        public string File_Contenido { set; get; }
        public string Ubicacion { set; get; }
        public byte[] Image { set; get; }
    }
}
