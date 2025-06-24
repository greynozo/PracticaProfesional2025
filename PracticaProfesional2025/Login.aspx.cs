using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PracticaProfesional2025
{
    public partial class Login : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaPP2025"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(Cadena))
            {
                string script = String.Format("SELECT ID FROM USUARIO WHERE USUARIO = '{0}' AND PASS = '{1}'"
                    , txtUsuario.Text, txtPassword.Text);

                conexion.Open();

                SqlCommand command = new SqlCommand(script, conexion);

                SqlDataReader reader = command.ExecuteReader();

                string id = String.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0).ToString();
                    }
                }

                reader.Close();
                conexion.Close();

                if (id != String.Empty)
                    //Redirigir al formulario principal
                    Response.Redirect("Default.aspx");
                else
                    //Usuario y/o contraseña incorrectos
                    lblMensaje.Text = "Usuario y/o contraseña incorrectos";
            }
        }
    }
}