using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NominaMensual
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form formulario = new Empleado();
            formulario.Show();          
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones ope = new Operaciones();



            if (comboBox1.Text.Length == 0)
            {

                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton1.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE cod_empleado = '" + comboBox1.Text.Trim() + "' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton2.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE nombre like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton3.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE apellido like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;
            }

            if (radioButton4.Checked == true)
            {
                DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE cedula like '%" + comboBox1.Text.Trim() + "%' ");
                dataGridView1.DataSource = dt;
                return;

            }


        }


        private void btnConex_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            
            String resultado=op.Conectar();
            MessageBox.Show(resultado);
            

            DataTable dt_empleado = op.ConsultaconResultado(" SELECT  * FROM empleados where id=1 ");
            foreach (DataRow dr in dt_empleado.Rows)
            {
                string nombre, apellidos;
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellidos"].ToString();
                comboBox1.Text = nombre + " " + apellidos;
            }


        }

       

        private void dataGridViewA_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            System.Data.DataTable res = new System.Data.DataTable();
            Operaciones op = new Operaciones();

            dataGridView1.DataSource = op.ConsultaconResultado(" SELECT *FROM empleados");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            Operaciones ope = new Operaciones();

              if (radioButton1.Checked == true)

               {
                    DataTable dt = ope.ConsultaconResultado(" SELECT  * FROM empleados WHERE nombre like '%" + comboBox1.Text.Trim() + "%' ");
                       dataGridView1.DataSource = dt;
                         return;
               }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string borrado;

            borrado = comboBox1.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            comboBox1.Text = borrado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Clear();    //Barra el todo del Combox de la calculadora//
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
         }

       
    }

 }
    

