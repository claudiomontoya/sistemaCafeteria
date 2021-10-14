using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class ProductosEntity
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cod_categoria { get; set; }
        public int cod_proveedor { get; set; }
    }
}
