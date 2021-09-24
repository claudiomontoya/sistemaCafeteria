using capaDatos;
using capaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class categoriaBL
    {
        claseDatos dato = new claseDatos();


        public DataSet Listado() {
            return dato.Listado("SELECT * FROM CATEGORIAS");
        }

        public int guardar(CategoriasEntity categoria)
        {
            return dato.ejecutar("INSERT INTO CATEGORIAS(CODIGO,NOMBRE) VALUES("+ categoria.codigo+",'"+ categoria.nombre +"' )");          
        }
    }
}
