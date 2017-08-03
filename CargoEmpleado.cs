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
    public partial class CargoEmpleado : Form
    {
        public CargoEmpleado()
        {
            InitializeComponent();
        }

       

      

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                //Insertar nuevos cargos en la base de datos//
                Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO cargo (cod_cargo, nombre_cargo) VALUES('" + txtCa.Text + "', '" + txtCarg.Text + "')");

                txtCa.Text = "";
                txtCarg.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cerrar formulario//
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Operaciones oper = new Operaciones();

            System.Data.DataTable dt = new System.Data.DataTable();


            DataTable dgvdatos = oper.ConsultaconResultado(" SELECT  * FROM cargo where cod_cargo='" + txtiDD.Text + "' ");
            foreach (DataRow dr in dgvdatos.Rows)
            {

                string A, B;

                try
                {
                    //Esto me permitira buscar en mi base de dato por ID//
                    A = dr["cod_cargo"].ToString();
                    txtCa.Text = A;

                    B = dr["nombre_cargo"].ToString();
                    txtCarg.Text = B;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtiDD.Text != null)
                {
                    //Borra registro de la base de dato de la tabla cabecera_nomina ene ste caso //
                    Operaciones op = new Operaciones();
                    op.ConsultasinResultado("DELETE from cargo WHERE cod_cargo = " + txtiDD.Text);
                    MessageBox.Show("Borrado");

                    //Limpio los TextBox automaticamente cuando borro//
                    txtCa.Text = "";
                    txtCarg.Text = "";
                    txtiDD.Text = "";

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
    }    
}
