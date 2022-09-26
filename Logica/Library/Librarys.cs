using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class Librarys : Conexion
    {
        public Uploadimage uploadimage = new Uploadimage();
        public TextBoxEvent textBoxEvent = new TextBoxEvent();
        public DateTimePicker dateTimePickerEvent = new DateTimePicker();
    }
}
