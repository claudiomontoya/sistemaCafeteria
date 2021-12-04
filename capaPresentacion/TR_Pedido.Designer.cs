namespace capaPresentacion
{
    partial class TR_Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_trabajadores = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_num_pedido = new System.Windows.Forms.TextBox();
            this.gr_detalle = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_pro_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pro_codigo = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_pro_precio = new System.Windows.Forms.TextBox();
            this.txt_pro_cantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gr_detalle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_trabajadores);
            this.groupBox1.Location = new System.Drawing.Point(22, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Trabajador";
            // 
            // cb_trabajadores
            // 
            this.cb_trabajadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trabajadores.FormattingEnabled = true;
            this.cb_trabajadores.Location = new System.Drawing.Point(74, 35);
            this.cb_trabajadores.Name = "cb_trabajadores";
            this.cb_trabajadores.Size = new System.Drawing.Size(570, 44);
            this.cb_trabajadores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_celular);
            this.groupBox2.Location = new System.Drawing.Point(22, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(24, 45);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(193, 41);
            this.txt_celular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celular";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(304, 45);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(413, 41);
            this.txt_nombre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(216, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(249, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 41);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "CREAR PEDIDO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_num_pedido
            // 
            this.txt_num_pedido.Enabled = false;
            this.txt_num_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_pedido.Location = new System.Drawing.Point(807, 31);
            this.txt_num_pedido.Name = "txt_num_pedido";
            this.txt_num_pedido.Size = new System.Drawing.Size(193, 83);
            this.txt_num_pedido.TabIndex = 5;
            // 
            // gr_detalle
            // 
            this.gr_detalle.Controls.Add(this.txt_total);
            this.gr_detalle.Controls.Add(this.button4);
            this.gr_detalle.Controls.Add(this.dataGridView1);
            this.gr_detalle.Controls.Add(this.groupBox4);
            this.gr_detalle.Enabled = false;
            this.gr_detalle.Location = new System.Drawing.Point(25, 263);
            this.gr_detalle.Name = "gr_detalle";
            this.gr_detalle.Size = new System.Drawing.Size(1025, 404);
            this.gr_detalle.TabIndex = 6;
            this.gr_detalle.TabStop = false;
            this.gr_detalle.Text = "Detalle Pedido";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_pro_cantidad);
            this.groupBox4.Controls.Add(this.txt_pro_precio);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.txt_pro_nombre);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_pro_codigo);
            this.groupBox4.Location = new System.Drawing.Point(21, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(983, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "productos";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(154, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 41);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_pro_nombre
            // 
            this.txt_pro_nombre.Enabled = false;
            this.txt_pro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_nombre.Location = new System.Drawing.Point(193, 45);
            this.txt_pro_nombre.Name = "txt_pro_nombre";
            this.txt_pro_nombre.Size = new System.Drawing.Size(308, 41);
            this.txt_pro_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "codigo";
            // 
            // txt_pro_codigo
            // 
            this.txt_pro_codigo.Enabled = false;
            this.txt_pro_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_codigo.Location = new System.Drawing.Point(24, 45);
            this.txt_pro_codigo.Name = "txt_pro_codigo";
            this.txt_pro_codigo.Size = new System.Drawing.Size(129, 41);
            this.txt_pro_codigo.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(833, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_pro_precio
            // 
            this.txt_pro_precio.Enabled = false;
            this.txt_pro_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_precio.Location = new System.Drawing.Point(507, 45);
            this.txt_pro_precio.Name = "txt_pro_precio";
            this.txt_pro_precio.Size = new System.Drawing.Size(130, 41);
            this.txt_pro_precio.TabIndex = 6;
            // 
            // txt_pro_cantidad
            // 
            this.txt_pro_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_cantidad.Location = new System.Drawing.Point(643, 45);
            this.txt_pro_cantidad.Name = "txt_pro_cantidad";
            this.txt_pro_cantidad.Size = new System.Drawing.Size(129, 41);
            this.txt_pro_cantidad.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 196);
            this.dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(814, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "FINALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(24, 349);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(184, 41);
            this.txt_total.TabIndex = 7;
            // 
            // TR_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 679);
            this.Controls.Add(this.gr_detalle);
            this.Controls.Add(this.txt_num_pedido);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TR_Pedido";
            this.Text = "PEDIDOS";
            this.Load += new System.EventHandler(this.TR_Pedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gr_detalle.ResumeLayout(false);
            this.gr_detalle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_trabajadores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_num_pedido;
        private System.Windows.Forms.GroupBox gr_detalle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_pro_cantidad;
        private System.Windows.Forms.TextBox txt_pro_precio;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_pro_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pro_codigo;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}