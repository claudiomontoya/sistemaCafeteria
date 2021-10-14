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
    public class proveedorBL
    {
        claseDatos dato = new claseDatos();


        public DataSet Listado()
        {
            return dato.Listado("SELECT * FROM PROVEEDORES");
        }

        public bool validarCodigo(int codigo)
        {
            DataSet obj = dato.Listado("SELECT * FROM PROVEEDORES WHERE CODIGO=" + codigo + "");
            if (obj.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;

        }

        public DataSet buscar(string nombre)
        {
            return dato.Listado("SELECT * FROM PROVEEDORES WHERE NOMBRE LIKE '%" + nombre + "%' OR TELEFONO LIKE '%"+nombre+"%' ");
        }

        public int guardar(ProveedoresEntity proveedor)
        {
            return dato.ejecutar("INSERT INTO PROVEEDORES(CODIGO,NOMBRE,TELEFONO) VALUES(" + proveedor.codigo + ",'" + proveedor.nombre + "','"+proveedor.telefono+"' )");
        }

        public int modificar(ProveedoresEntity proveedor)
        {
            return dato.ejecutar("UPDATE PROVEEDORES SET NOMBRE='" + proveedor.nombre + "',TELEFONO='"+proveedor.telefono+"' WHERE CODIGO=" + proveedor.codigo + "");
        }

        public int eliminar(ProveedoresEntity proveedor)
        {
            return dato.ejecutar("DELETE FROM  PROVEEDORES  WHERE CODIGO=" + proveedor.codigo + "");
        }
    }
}
