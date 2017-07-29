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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }



        SQLiteConnection cnx = new SQLiteConnection("Data source=C:\\sistema\\nomina.s3db; Version=3;");

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    
            {
                e.Handled = true;          //codigo para saltar de un TexBox a otro//
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;            
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {     
            
            Operaciones op = new Operaciones();                                         
            op.ConsultasinResultado("INSERT INTO empleados(cedula, nombre, apellido, direccion, sexo, sueldo, fecha_nacimiento, fecha_ingreso, cod_cargo) VALUES('" + txt7.Text + "', '" + txt1.Text + "', '" + txt2.Text + "', '" + txt3.Text + "', '" + txt4.Text + "', '" + txt5.Text + "', '" + dateTimePicker1.Text + "','" + dateTimePicker3.Text + "', '" + txtCalgo.Text + "')");

            //*********************************************************************************************************//

            string I = dateTimePicker1.Text;

            DateTime X = Convert.ToDateTime(I);
            int edad = DateTime.Today.AddTicks(-X.Ticks).Year - 1;
            txtNaci.Text = Convert.ToString(edad);
            edad.ToString();


            string t = dateTimePicker3.Text;

            DateTime k = Convert.ToDateTime(t);
            int Antiguedad = DateTime.Today.AddTicks(-k.Ticks).Year - 1;
            textBox10.Text = Convert.ToString(Antiguedad);
            textBox10.ToString();

            //*********************************************************************************************************//
        }


        private void empleado_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Form formulario = new Calculadora();
            formulario.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Calculadora();    //Llamado al segundo Formulario//
            formulario.Show();
        }

        private void txt7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnBus_Click(object sender, EventArgs e)
        {

            Operaciones oper = new Operaciones();

            DataTable dt_empleado = oper.ConsultaconResultado(" SELECT  * FROM empleados where cod_empleado='" + txtID.Text + "' ");
            foreach (DataRow dr in dt_empleado.Rows)
            {

                string cod_empleado, nombre, apellido, cedula, sueldo,sexo,direccion,cod_calgo;
              

                cod_empleado = dr["cod_empleado"].ToString();
                nombre = dr["nombre"].ToString();
                apellido = dr["apellido"].ToString();
                cedula = dr["cedula"].ToString();
                sueldo = dr["sueldo"].ToString();
                sexo = dr["sexo"].ToString();
                direccion = dr["direccion"].ToString();
                cod_calgo = dr["cod_cargo"].ToString();



                // txtID = int.Parse(int codigoEmpleado);
                txt1.Text = nombre;
                txt2.Text = apellido;
                txt3.Text = direccion;
                txt4.Text = sexo;
                txt7.Text = cedula;
                txt5.Text = sueldo;
                txtCalgo.Text = cod_cargo;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";                //Borra solo numero por numero//
            txt5.Text = "";
            dateTimePicker1.Text = "";
            txt7.Text = "";
            txtCalgo.Text = "";
            txtNaci.Text = "";
            textBox10.Text = "";


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {         
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button2_Click_2(object sender, EventArgs e)
        {

            
        }
    }
}
