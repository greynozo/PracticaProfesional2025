using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PracticaProfesional2025
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

           builder.DataSource = @"DESKTOP-URR4FQN\SQLEXPRESS";
           builder.InitialCatalog = "PP2025";
           builder.IntegratedSecurity = true;
           builder.PersistSecurityInfo = true;


            using(SqlConnection conexion = new SqlConnection(builder.ConnectionString))
            {
                string script = "SELECT * FROM USUARIO";

                conexion.Open();

                SqlCommand command = new SqlCommand(script, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetInt32(0).ToString();
                        string usuario = reader.GetString(1);
                    }
                }

                reader.Close();
                conexion.Close();
            }

        }
    }
}