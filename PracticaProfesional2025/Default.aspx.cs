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
    public partial class Default : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaPP2025"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

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
                string script = "SELECT * FROM USUARIO";

                conexion.Open();

                SqlCommand command = new SqlCommand(script, conexion);

                SqlDataReader reader = command.ExecuteReader();

                string id = String.Empty;
                string usuario = String.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0).ToString();
                        usuario = reader.GetString(1);
                    }
                }

                lblMensaje.Text = "ID de usuario: " + id.ToString() + " - Usuario: " + usuario.Trim();

                reader.Close();
                conexion.Close();
            }

        }
    }
}