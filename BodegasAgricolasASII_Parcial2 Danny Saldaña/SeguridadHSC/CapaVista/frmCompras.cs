using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmCompras : Form
    {
        Controlador cn = new Controlador();
        public frmCompras()
        {
            InitializeComponent();
            CenterToScreen();
            textBox1.Text = DateTime.Today.ToString("dd/MM/yyyy");
            todoslosproductos();
            documentodecompra();
            carritodecompras();
            saldototal();

            string valor2 = "";
            string valor1 = textBox2.Text; //Documento de compra
            cn.agregarencabezado(tabla3, valor1, valor2);
        }

        //Mostrar los datos CAPA VISTA
        string tabla = "perfil";
        string tabla2 = "aplicacion";
        string tabla3 = "aplicacionperfil";
        
        public void documentodecompra()
        {

            DataTable dt = cn.llenarTblappaperf(tabla2);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox2.Text = dta;
            int dtb = Int32.Parse(textBox2.Text)+2;
            string dtc = dtb.ToString();
            textBox2.Text = dtc;
            

        }

        public void saldototal()
        {
            string condicion = textBox2.Text;
            DataTable dt = cn.saldototal(tabla2, condicion);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox4.Text = dta;
        }


        public void todoslosproductos()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.todoslosproductos(tabla2, condicion);
            dataGridView2.DataSource = dt;
        }

        public void carritodecompras()
        {
            string condicion = textBox2.Text;
            DataTable dt = cn.carritodecompras(tabla2, condicion);
            dataGridView1.DataSource = dt;
        }


        public void llenarnombre()
        {
            string condicion = textBox1.Text;
            DataTable dt = cn.llenarNombreappaperf(tabla, condicion);
            string dta = string.Join(Environment.NewLine, dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
            textBox2.Text = dta;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmConsulta_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString(); //Ayuda

            string valor1 = textBox2.Text; //Documento de compra
            string valor2 = textBox3.Text;
            cn.agregarproducto(tabla3, valor1, valor2);
            todoslosproductos();
            carritodecompras();
            saldototal();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string valor1 = textBox2.Text;
            string valor2 = textBox3.Text;
            cn.eliminarappaperf(tabla3, valor1, valor2);
            todoslosproductos();
            carritodecompras();
            saldototal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            cn.perfileliminartodoappaperf(tabla3, valor1);
            todoslosproductos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor1 = textBox1.Text;
            string valor2 = textBox3.Text;
            string condicion = textBox1.Text;
            cn.perfileliminartodoappaperf(tabla3, valor1);
            cn.perfilagregartodoappaperf(tabla3, valor1, valor2, tabla2);


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Llenar con Enter

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido

            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
        }


        //Utilizar flechas para moverse entre botones

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button3.Focus();//Mueve al siguiente boton
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button4.Focus();//Mueve al siguiente boton
            }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button2.Focus();//Mueve al siguiente boton
            }
        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button5.Focus();//Mueve al siguiente boton
            }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button6.Focus();//Mueve al siguiente boton
            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                button1.Focus();//Mueve al siguiente boton
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;//elimina el sonido
                textBox1.Focus();//Mueve al siguiente boton
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
