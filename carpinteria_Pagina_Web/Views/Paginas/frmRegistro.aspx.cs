using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carpinteria_Pagina_Web.Views
{
    public partial class frmRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (!IsPostBack)
         //   {
           //     if (Session["Login"] == null)
                  //  Response.Redirect("inicio.Sesion.aspx");


               // PrimerNombre.Text = Session["Login"].ToString();


          //  }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

         //   Session.Remove("Login");
          //  Session.RemoveAll();
            Response.Redirect("pagina.Inicio.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}