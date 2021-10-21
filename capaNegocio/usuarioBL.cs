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
    public class usuarioBL
    {
        claseDatos dato = new claseDatos();


        public DataSet Listado()
        {
            return dato.Listado("SELECT CODIGO,NOMBRE,'*******' as CLAVE FROM USUARIOS");
        }

        public bool validarCodigo(string codigo)
        {
            DataSet obj = dato.Listado("SELECT * FROM USUARIOS WHERE CODIGO='" + codigo + "'");
            if (obj.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;

        }

        public DataSet buscar(string nombre)
        {
            return dato.Listado("SELECT CODIGO,NOMBRE,'*******' as CLAVE FROM USUARIOS WHERE NOMBRE LIKE '%" + nombre + "%' ");
        }

        public int guardar(UsuariosEntity usuario)
        {
            return dato.ejecutar("INSERT INTO USUARIOS(CODIGO,NOMBRE,CLAVE) VALUES('" + usuario.codigo + "','" + usuario.nombre + "','"+ usuario.clave+"' )");
        }

        public int modificar(UsuariosEntity usuario)
        {
            return dato.ejecutar("UPDATE USUARIOS SET NOMBRE='" + usuario.nombre + "', CLAVE='" + usuario.clave + "' WHERE CODIGO='" + usuario.codigo + "'");
        }

        public int eliminar(UsuariosEntity usuario)
        {
            return dato.ejecutar("DELETE FROM  USUARIOS  WHERE CODIGO='" + usuario.codigo + "'");
        }
    }
}
