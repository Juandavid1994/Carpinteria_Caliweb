﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carpinteria_Pagina_Web.Interfaces
{
    public partial class pagina_Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                    Response.Redirect("inicio.Sesion.aspx");


            }
        }
    }
}