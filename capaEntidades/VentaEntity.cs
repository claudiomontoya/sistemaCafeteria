using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class VentaEntity
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
        public string usuario { get; set; }
        public string tipo_pago { get; set; }
        public int numero { get; set; }
        public string banco { get; set; }
        public string titular { get; set; }
        public DateTime fecha_cheque { get; set; }
        public string numero_cuenta { get; set; }

        public VentaEntity()
        {
            numero = 0;
            banco = "";
            titular = "";
            fecha_cheque = DateTime.Now;
            numero_cuenta = "";
        }
    }
}
