using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace PracticaProfesional2025
{
    public partial class Default : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaPP2025"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            string idSession = Session["Usuario"].ToString();
            string val = string.Empty;
            string t = string.Empty;

            if (idSession == String.Empty)
                Response.Redirect("Login.aspx");
            else
            {
                val = Request.QueryString["val"];
                t = Request.QueryString["tipo"];
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //Servido I46
            //builder.DataSource = @"DESKTOP-URR4FQN\SQLEXPRESS";

            //Servidor Gonzalo
            //builder.DataSource = @"BANGHO";
            //builder.InitialCatalog = "PP2025";
            //builder.IntegratedSecurity = true;
            //builder.PersistSecurityInfo = true;


            //using(SqlConnection conexion = new SqlConnection(builder.ConnectionString))

            using (SqlConnection conexion = new SqlConnection(Cadena))
            {
                string script = String.Format("INSERT INTO USUARIO VALUES('{0}', '{1}', {2}, {3})",
                    txtUsuario.Text, txtContraseña.Text, txtEdad.Text, txtDNI.Text);

                //bool existe = ExiteUsuario(txtUsuario.Text);

                if (ExiteUsuario(txtUsuario.Text))
                {
                    lblMensaje.Text = "Usuario existente, no se puede crear";
                    lblMensaje.ForeColor = Color.Red;
                }
                else
                {
                    conexion.Open();

                    SqlCommand command = new SqlCommand(script, conexion);

                    //SqlDataReader reader = command.ExecuteReader();

                    int filas = command.ExecuteNonQuery();

                    if (filas > 0)
                        lblMensaje.Text = "Usuario generado correctamente";
                    else
                        lblMensaje.Text = "Usuario no se pudo generar";

                    conexion.Close();
                }


            }

            //SELECCION DE DATOS DE BASE DE DATOS
            //using (SqlConnection conexion = new SqlConnection(Cadena))
            //{
            //    string script = "SELECT * FROM USUARIO";

            //    conexion.Open();

            //    SqlCommand command = new SqlCommand(script, conexion);

            //    SqlDataReader reader = command.ExecuteReader();

            //    string id = String.Empty;
            //    string usuario = String.Empty;

            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            id = reader.GetInt32(0).ToString();
            //            usuario = reader.GetString(1);
            //        }
            //    }

            //    lblMensaje.Text = "ID de usuario: " + id.ToString() + " - Usuario: " + usuario.Trim();

            //    reader.Close();
            //    conexion.Close();
            //}

        }

        private static bool ExiteUsuario(string u)
        {
            using (SqlConnection conexion = new SqlConnection(Cadena))
            {
                string script = String.Format("SELECT ID FROM USUARIO WHERE USUARIO = '{0}'", u);

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
                    //El usuario existe. No se puede crear
                    return true;
                else
                    //El usuario no existe. Se puede crear
                    return false;
            }
        }

    }
}
