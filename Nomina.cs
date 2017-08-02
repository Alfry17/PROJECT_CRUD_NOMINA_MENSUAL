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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float sueldo;

                double opereacionisr,
                       operacionss, 
                       operacionesotros,
                       texisr, texss, texotros, 
                       totalope, suelneto;


                sueldo = Convert.ToInt32(txtsueldo.Text);


                opereacionisr = sueldo * 0.12;
                operacionss = sueldo * 0.04;
                operacionesotros = sueldo * 0.02;


                           txtisr.Text = opereacionisr.ToString();
                           txtdeducionss.Text = operacionss.ToString();
                           txtotros.Text = operacionesotros.ToString();


                           texisr = Convert.ToInt32(txtisr.Text);
                           texss = Convert.ToInt32(txtdeducionss.Text);
                           texotros = Convert.ToInt32(txtotros.Text);


                totalope = texisr + texss + texotros;
                txtdeducciontt.Text = totalope.ToString();
                suelneto = sueldo - totalope;
                txtsueldoneto.Text = suelneto.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void btnguarnomina_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
                op.ConsultasinResultado("INSERT INTO detalle_nomina (sueldo_bruto, isr, ss, otros, total_deducciones, sueldo_neto, cod_empleado, num_nomina) VALUES('" + txtsueldo.Text + "', '" + txtisr.Text + "', '" + txtdeducionss.Text + "', '" + txtotros.Text + "', '" + txtdeducciontt.Text + "', '" + txtsueldoneto.Text + "', '" + txtfechanomina.Text + "', '" + txtidempleadonomina.Text +"')");

            txtisr.Text = ("");
            txtfechanomina.Text = ("");
            txtdeducionss.Text = ("");
            txtdeducciontt.Text = ("");
            txtotros.Text = ("");
            txtsueldoneto.Text = ("");
            txtidempleadonomina.Text = ("");
            txtdetallesid.Text = ("");
            txtsueldo.Text = ("");

        }


    }
}
