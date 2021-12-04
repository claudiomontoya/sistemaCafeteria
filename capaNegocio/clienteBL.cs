using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class clienteBL
    {
        claseDatos dato = new claseDatos();


        public DataSet listado()
        {
            return dato.Listado("SELECT TOP (200) celular, nombre, email, direccion, referencia FROM clientes");
        }
        public DataSet listado(string texto)
        {
            return dato.Listado("SELECT TOP (200) celular, nombre, email, direccion, referencia FROM clientes where nombre like '%"+ texto + "%' or celular like '%" + texto + "%'");
        }
    }
}
