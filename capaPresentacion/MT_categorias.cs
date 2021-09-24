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
    public partial class MT_categorias : Form
    {
        categoriaBL categoria = new categoriaBL();

        public MT_categorias()
        {
            InitializeComponent();
        }

        private void MT_categorias_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar() {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_codigo.Focus();
        }

        private void listar() {
            dataGridView1.DataSource = categoria.Listado().Tables[0];
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_nombre.Text == "")
            {
                MessageBox.Show("Complete todos los datos..!!","Error de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



            CategoriasEntity cat = new CategoriasEntity();
            cat.codigo = int.Parse(txt_codigo.Text);
            cat.nombre = txt_nombre.Text;
            categoria.guardar(cat);
            listar();
            limpiar();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
