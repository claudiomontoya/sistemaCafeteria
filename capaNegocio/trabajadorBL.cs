using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class trabajadorBL
    {
        claseDatos dato = new claseDatos();


        public DataSet cargaTrabajadores()
        {
            return dato.Listado("SELECT rut, nombre + ' ' + apellido AS nombre FROM trabajadores");
        }
    }
}
