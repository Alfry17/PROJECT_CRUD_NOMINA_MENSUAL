using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaMensual
{
    public partial class Cabecera_No : Form
    {
        public Cabecera_No()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar formulario//
            this.Close();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               


                //INSERT para agregar a la base de dato nuevos registro//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO cabecera_nomina (num_nomina, nombre_empresa, tipo_nomina, fecha_inicio, fecha_final) VALUES ('" + txtnum_nomina.Text + "', '" + txtnombre_Empresa.Text + "', '" + txttipo_nomina.Text + "', '" + dateTimePicker4.Text + "', '" + dateTimePicker5.Text + "')");
                MessageBox.Show("Se agrego correctamente");

                //Borra solo numero por numero//
                txtnum_nomina.Text = "";
                txtnombre_Empresa.Text = "";
                txttipo_nomina.Text = "";
                dateTimePicker4.Text = "";
                dateTimePicker5.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



            Operaciones oper = new Operaciones();
        
            System.Data.DataTable dt = new System.Data.DataTable();
          

            DataTable dgvdatos = oper.ConsultaconResultado(" SELECT  * FROM cabecera_nomina where num_nomina='" + txtid.Text + "' ");
            foreach (DataRow dr in dgvdatos.Rows)
            {
                  
                string num_nomina, nombre_empresa, 
                       tipo_nomina, fecha_inicio, 
                       fecha_final;

                try
                {
                    //Esto me permitira buscar en mi base de dato por ID//
                    num_nomina = dr["num_nomina"].ToString();
                    txtnum_nomina.Text = num_nomina;

                    nombre_empresa = dr["nombre_empresa"].ToString();
                    txtnombre_Empresa.Text = nombre_empresa;

                    tipo_nomina = dr["tipo_nomina"].ToString();
                    txttipo_nomina.Text = tipo_nomina;


                    fecha_inicio = dr["fecha_inicio"].ToString();
                    dateTimePicker4.Text = fecha_inicio;

                    fecha_final = dr["fecha_final"].ToString();
                    dateTimePicker5.Text = fecha_final;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != null)
                {
                    //Borra registro de la base de dato de la tabla cabecera_nomina ene ste caso //
                    Operaciones op = new Operaciones();
                    op.ConsultasinResultado("DELETE from cabecera_nomina WHERE num_nomina = " + txtid.Text);
                    MessageBox.Show("Borrado");

                    //Limpio los TextBox automaticamente cuando borro//


                    txtid.Text = "";
                    txtnum_nomina.Text = "";
                    txtnombre_Empresa.Text = "";
                    txttipo_nomina.Text = "";
                    dateTimePicker4.Text = "";
                    dateTimePicker5.Text = "";

                }
                else
                {
                    MessageBox.Show("Nose pudo Borrar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Actualiza los campos de la tabla Cargos//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("UPDATE cabecera_nomina SET num_nomina = '" + txtnum_nomina.Text + "', nombre_empresa = '" + txtnombre_Empresa.Text + "', tipo_nomina = '" + txttipo_nomina.Text + "', fecha_inicio = '" + dateTimePicker4.Text + "' , fecha_inicio = '" + dateTimePicker5.Text + "' ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
  }

