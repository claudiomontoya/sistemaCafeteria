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
    public class productoBL
    {
        claseDatos dato = new claseDatos();


        public DataSet Listado()
        {
            return dato.Listado("SELECT productos.codigo, productos.nombre, categorias.nombre AS categoria, proveedores.nombre AS proveedor, productos.precio" +
                                 " FROM  categorias INNER JOIN productos ON categorias.codigo = productos.cod_categoria INNER JOIN proveedores ON productos.cod_proveedor = proveedores.codigo");
        }

        public DataSet Listado(string texto)
        {
            return dato.Listado("SELECT productos.codigo, productos.nombre, categorias.nombre AS categoria, proveedores.nombre AS proveedor, productos.precio" +
                                 " FROM  categorias INNER JOIN productos ON categorias.codigo = productos.cod_categoria INNER JOIN proveedores ON productos.cod_proveedor = proveedores.codigo where productos.nombre like '%"+texto+"%'");
        }


        public int guardar(ProductosEntity producto)
        {
            return dato.ejecutar("INSERT INTO PRODUCTOS(CODIGO,NOMBRE,COD_CATEGORIA,COD_PROVEEDOR,PRECIO) VALUES(" + producto.codigo + ",'" + producto.nombre + "',"+producto.cod_categoria+","+producto.cod_proveedor+","+producto.precio+" )");
        }

        public bool validarCodigo(int codigo)
        {
            DataSet obj = dato.Listado("SELECT * FROM PRODUCTOS WHERE CODIGO=" + codigo + "");
            if (obj.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;

        }
    }
}
