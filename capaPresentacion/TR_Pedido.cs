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
    public partial class TR_Pedido : Form
    {
        public TR_Pedido()
        {
            InitializeComponent();
        }

        private void TR_Pedido_Load(object sender, EventArgs e)
        {
            cargarTrabajadores();
        }

        private void cargarTrabajadores()
        {
            trabajadorBL trabajador = new trabajadorBL();
            cb_trabajadores.DataSource = trabajador.cargaTrabajadores().Tables[0];
            cb_trabajadores.ValueMember = "rut";
            cb_trabajadores.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_cliente obj = new BUS_cliente();
            obj.ShowDialog();
            if (obj.celular != "")
            {
                txt_celular.Text = obj.celular;
                txt_nombre.Text = obj.nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pedidoBL pedido = new pedidoBL();
            PedidoEntity pedidodata = new PedidoEntity();
            pedidodata.rut_trabajador = cb_trabajadores.SelectedValue.ToString();
            pedidodata.id_cliente = txt_celular.Text;
            pedidodata.codigo_usuario = global.usuario;
            pedidodata.fecha = DateTime.Now;

            pedido.guardar(pedidodata);
            txt_num_pedido.Text = buscarUltimoPedido();
            gr_detalle.Enabled = true;
            listarDetalle();
        }

        private void listarDetalle()
        {
            pedidoBL pedido = new pedidoBL();
            dataGridView1.DataSource = pedido.detallePedido(int.Parse(txt_num_pedido.Text)).Tables[0];
            totales();
        }

        private string buscarUltimoPedido()
        {
            pedidoBL pedido = new pedidoBL();
            return pedido.ultimoPedido().Tables[0].Rows[0].ItemArray[0].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BUS_producto obj = new BUS_producto();
            obj.ShowDialog();

            if (obj.codigo != "") {

                txt_pro_codigo.Text = obj.codigo;
                txt_pro_nombre.Text = obj.nombre;
                txt_pro_precio.Text = obj.precio;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pedidoBL pedido = new pedidoBL();
            pedido.guardarDetalle(int.Parse(txt_num_pedido.Text), int.Parse(txt_pro_codigo.Text), int.Parse(txt_pro_cantidad.Text), int.Parse(txt_pro_precio.Text));
            listarDetalle();
        }

        private void totales() {
            int total = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                total += int.Parse(dataGridView1[5, i].Value.ToString());
            }

            txt_total.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MT_producto obj = new MT_producto();
            obj.ShowDialog();
        }
    }
}
