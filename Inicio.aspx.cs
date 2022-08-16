using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_PF
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si existe una sesion con valor diferente a nulo se asigna el nombre a una variable que luego es mostrada junto a la bienvenida
            if (Session["usuariolog"] != null)
            {
                String usuariolog = Session["usuariolog"].ToString();
                lblBienvenida.Text = "Bienvenid@ " + usuariolog + " :D";
            }
            else
            {
                Response.Redirect("Login_PF.aspx");
            }
        }
        protected void BtnCerrar_Click(object sender, EventArgs e) //Y en este boton se cierra la sesion
        {
            Session.Remove("usuariolog");
            Response.Redirect("Login_PF.aspx");
        }
    }
}