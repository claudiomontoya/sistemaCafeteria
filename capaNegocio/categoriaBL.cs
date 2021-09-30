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

        public DataSet buscar(string nombre)
        {
            return dato.Listado("SELECT * FROM CATEGORIAS WHERE NOMBRE LIKE '%"+ nombre +"%' ");
        }

        public int guardar(CategoriasEntity categoria)
        {
            return dato.ejecutar("INSERT INTO CATEGORIAS(CODIGO,NOMBRE) VALUES("+ categoria.codigo+",'"+ categoria.nombre +"' )");          
        }

        public int modificar(CategoriasEntity categoria)
        {
            return dato.ejecutar("UPDATE CATEGORIAS SET NOMBRE='"+ categoria.nombre +"' WHERE CODIGO="+ categoria.codigo+"");
        }

        public int eliminar(CategoriasEntity categoria)
        {
            return dato.ejecutar("DELETE FROM  CATEGORIAS  WHERE CODIGO=" + categoria.codigo + "");
        }
    }
}
