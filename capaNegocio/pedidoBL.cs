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
   public class pedidoBL
    {
        claseDatos dato = new claseDatos();

        public DataSet ultimoPedido()
        {
            return dato.Listado("SELECT ISNULL(MAX(id), 0) AS id FROM Pedido");
        }

        public int guardar(PedidoEntity pedido)
        {
            return dato.ejecutar("INSERT INTO PEDIDO(rut_trabajador, id_cliente, codigo_usuario, estado, fecha) VALUES('" + pedido.rut_trabajador + "','" + pedido.id_cliente + "','" + pedido.codigo_usuario + "','creado','" + pedido.fecha + "' )");
        }

        public DataSet detallePedido(int id_pedido)
        {
            return dato.Listado("SELECT detalle_pedido.id, detalle_pedido.codigo_producto codigo, productos.nombre, detalle_pedido.cantidad, detalle_pedido.precio, detalle_pedido.cantidad * detalle_pedido.precio subtotal " +
                                "FROM Pedido INNER JOIN detalle_pedido ON Pedido.id = detalle_pedido.id_pedido INNER JOIN productos ON detalle_pedido.codigo_producto = productos.codigo  where pedido.id="+ id_pedido +"");
        }

        public int guardarDetalle(int id_pedido, int codigo_producto, int cantidad, int precio)
        {
            return dato.ejecutar("INSERT INTO detalle_pedido(id_pedido, codigo_producto, cantidad, precio) VALUES(" + id_pedido + "," + codigo_producto + "," + cantidad + "," + precio + " )");
        }

        public DataSet listarPedido(int numero)
        {
            return dato.Listado("sp_listar_pedido "+numero+"");
        }

        public int guardarVenta(VentaEntity venta)
        {
            return dato.ejecutar("INSERT INTO VENTA(id_pedido, estado, fecha, usuario, tipo_pago, numero, banco, titular, fecha_cheque, numero_cuenta) VALUES("+venta.id_pedido+ ", '"+venta.estado+ "', '" + venta.fecha + "', '" + venta.usuario+"', '"+venta.tipo_pago+"', " + venta.numero + ", '" + venta.banco+"', '"+venta.titular+"', '" + venta.fecha_cheque + "', '" + venta.numero_cuenta+"'); update pedido set estado='finalizado' where id="+ venta.id_pedido+"");
        }


    }
}
