using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace carpinteria_Pagina_Web.Views.Login
{
    public partial class inicio_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                if (Request.Cookies["Token"] != null)
                    txtUsuario.Text = Request.Cookies["Token"].Value;



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                web.Logica.clsUsuario obclsUsuario = new web.Logica.clsUsuario();
                DataSet dsConsulta = obclsUsuario.dsConsultar(txtUsuario.Text, txtPassword.Text);
                    
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {


                    if (CheckBox1.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(2);
                        this.Response.Cookies.Add(cookie);
                    }
                    else 
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        this.Response.Cookies.Add(cookie);
                    
                    }

                    Session["Login"] = txtUsuario.Text;
                    Response.Redirect("pagina.Inicio.aspx");
                }
                else
                    throw new Exception("Usuario o Contraseña incorrectos por favor vuelve a intertar");
                
            }
            catch (Exception ex) 
            {
                Response.Write("<script language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
                     



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}