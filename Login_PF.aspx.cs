using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_PF
{
    public partial class Login_PF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Se programa el boton de ingreso, se establece la conexion y se llama el procedimiento almacenado
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            //Aquí se abre la conexión y se envían los parametros del formulario
            cmd.Connection.Open();
            cmd.Parameters.Add("@NombreU", SqlDbType.VarChar, 100).Value = tbUsuario.Text;
            cmd.Parameters.Add("@Contra", SqlDbType.VarChar, 500).Value = tbContraseña.Text;

            //Se crea un lector SQL y se crea la condicion para el inicio de sesion 
            SqlDataReader lec = cmd.ExecuteReader();
            if (lec.Read())
            {
                //Sesión 
                Session["usuariolog"] = tbUsuario.Text;
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                lblError.Text = "Error al ingresar el usuario o la contraseña";
            }
            cmd.Connection.Close();
        }
    }
}