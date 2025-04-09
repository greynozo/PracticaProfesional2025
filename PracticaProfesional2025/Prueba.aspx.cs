using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace PracticaProfesional2025
{
    public partial class Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = "Gonzalo";

                int edad = 0;
                int v = 10;

                edad = Int32.Parse(txtIngresoEdad.Text);

                //bool res = Int32.TryParse(txtIngresoEdad.Text, out v);

                txtEdad.Text = edad.ToString();

                if (edad >= 18)
                    lblMayor.Text = "ES MAYOR Y LA EDAD ES: " + edad.ToString();
                else
                {
                    lblMayor.Text = String.Format("ES MENOR, LA EDAD ES {0} Y SU NOMBRE ES {1}", edad, txtNombre.Text);
                    lblMayor.Text = "ES MENOR, LA EDAD ES " + edad.ToString() + " Y SU NOMBRE ES " + txtNombre.Text;
                    lblMayor.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            /*Borro el dato del textbox
            esto es un
            comentario*/

            //Borro el dato del texbox
            txtNombre.Text = String.Empty;
            txtNombre.Text = "";
            txtEdad.Text = "";
        }
    }
}