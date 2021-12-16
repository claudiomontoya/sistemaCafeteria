using capaEntidades;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class TR_venta : Form
    {
        public TR_venta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedidoBL pedido = new pedidoBL();
            DataSet data = pedido.listarPedido(int.Parse(txt_numero_pedido.Text));
            dataGridView1.DataSource = data.Tables[0];
            txt_celular.Text = data.Tables[1].Rows[0].ItemArray[1].ToString();
            txt_nombre_cliente.Text = data.Tables[1].Rows[0].ItemArray[2].ToString();
            txt_trabajador.Text = data.Tables[1].Rows[0].ItemArray[3].ToString();
            totales();
        }
        private void totales()
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                total += int.Parse(dataGridView1[6, i].Value.ToString());
            }

            txt_totales.Text = total.ToString();

        }

        private void TR_venta_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaEntity venta = new VentaEntity();
            pedidoBL pedido = new pedidoBL();
            venta.usuario = global.usuario;
            venta.id_pedido = int.Parse(txt_numero_pedido.Text);
            venta.estado = "finalizado";
            venta.fecha = DateTime.Now;
            venta.tipo_pago = comboBox1.Text.ToString();
            pedido.guardarVenta(venta);

        }
    }
}
