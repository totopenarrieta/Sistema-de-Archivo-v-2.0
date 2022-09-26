//using Data;
//using Logica.Library;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Logica
//{
//    public class LPersonal2 : Librarys
//    {
//        private DataGridView _dataGridView2;
//        private NumericUpDown _numericUpDown;
//        //private Paginador2<File_Personal> _paginador;
//        public LPersonal2(object[] objectos)
//        {
//            _dataGridView2 = (DataGridView)objectos[0];
//            _numericUpDown = (NumericUpDown)objectos[1];
//            Restablecer();
//        }
//        private int _reg_por_pagina = 20, _num_pagina = 1;
//        public void SearchPersona(string campo)
//        {
//            List<File_Personal> query = new List<File_Personal>();
//            int inicio = (_num_pagina - 1) * _reg_por_pagina;
//            if (campo.Equals(""))
//            {
//                query = _File_Personal.ToList();
//            }
//            else
//            {
//                query = _File_Personal.Where(c => c.CI.StartsWith(campo) || c.Ap_Paterno.StartsWith(campo) || c.Ap_Materno.StartsWith(campo) || c.Nombres.StartsWith(campo)
//                    || c.Estado.StartsWith(campo) || c.Cargo.StartsWith(campo) || c.Administracion.StartsWith(campo)).ToList();
//            }
//            if (0 < query.Count)
//            {
//                _dataGridView2.DataSource = query.Select(c => new
//                {
//                    c.CI,
//                    c.Codigo_Archivo,
//                    c.Codigo_Antiguo,
//                    c.Ap_Paterno,
//                    c.Ap_Materno,
//                    c.Nombres,
//                    c.Numero_item,
//                    c.Estado,
//                    c.Fecha_Nac,
//                    c.Fecha_Inc,
//                    c.Cargo,
//                    c.Administracion,
//                    c.File_Url,
//                    c.File_Contenido,
//                    c.Ubicacion,
//                    c.Image
//                }).Skip(inicio).Take(_reg_por_pagina).ToList();
//                _dataGridView2.Columns[1].Visible = false;
//                _dataGridView2.Columns[2].Visible = false;
//                _dataGridView2.Columns[8].Visible = false;
//                _dataGridView2.Columns[9].Visible = false;
//                _dataGridView2.Columns[10].Visible = false;
//                _dataGridView2.Columns[12].Visible = false;
//                _dataGridView2.Columns[13].Visible = false;
//                _dataGridView2.Columns[15].Visible = false;
//                _dataGridView2.Columns[3].DefaultCellStyle.BackColor = Color.AliceBlue;
//                _dataGridView2.Columns[5].DefaultCellStyle.BackColor = Color.AliceBlue;
//                _dataGridView2.Columns[7].DefaultCellStyle.BackColor = Color.AliceBlue;
//                _dataGridView2.Columns[14].DefaultCellStyle.BackColor = Color.AliceBlue;
//            }
//            else
//            {
//                _dataGridView2.DataSource = query.Select(c => new
//                {
//                    c.CI,
//                    c.Codigo_Archivo,
//                    c.Codigo_Antiguo,
//                    c.Ap_Paterno,
//                    c.Ap_Materno,
//                    c.Nombres,
//                    c.Numero_item,
//                    c.Estado,
//                    c.Fecha_Nac,
//                    c.Fecha_Inc,
//                    c.Cargo,
//                    c.Administracion,
//                    c.File_Url,
//                    c.File_Contenido,
//                    c.Ubicacion,
//                    c.Image
//                }).ToList();
//            }
//        }

//        public void GetPersona()
//        {
//            throw new NotImplementedException();
//        }

//        //private int _idFile_Personal = 0;
//        private List<File_Personal> listFile_Personal;
//        public void Paginador2(string metodo)
//        {
//            switch (metodo)
//            {
//                case "Primero":
//                    //_num_pagina = _paginador.primero();
//                    break;
//                case "Anterior":
//                    //_num_pagina = _paginador.anterior();
//                    break;
//                case "Siguiente":
//                    //_num_pagina = _paginador.siguiente();
//                    break;
//                case "Ultimo":
//                    //_num_pagina = _paginador.ultimo();
//                    break;
//            }
//            SearchPersona("");
//        }
//        public void Registro_Paginas()
//        {
//            _num_pagina = 1;
//            _reg_por_pagina = (int)_numericUpDown.Value;
//            var list = _File_Personal.ToList();
//            if (0 < list.Count)
//            {
//                //_paginador = new Paginador2<File_Personal>(listFile_Personal, _reg_por_pagina);
//                SearchPersona("");
//            }
//        }
//        public void Restablecer()
//        {
//            _num_pagina = 1;
//            //_idFile_Personal = 0;
//            listFile_Personal = _File_Personal.ToList();
//            if (0 < listFile_Personal.Count)
//            {
//                //_paginador = new Paginador2<File_Personal>(listFile_Personal, _reg_por_pagina);
//            }
//            SearchPersona("");
//        }
//    }
//}