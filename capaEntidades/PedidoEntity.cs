using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class PedidoEntity
    {
        //id, rut_trabajador, id_cliente, codigo_usuario, estado, fecha, fecha_modificacion
        public int id { get; set; }
        public string rut_trabajador { get; set; }
        public string id_cliente { get; set; }
        public string codigo_usuario { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_modificacion { get; set; }
    }
}
