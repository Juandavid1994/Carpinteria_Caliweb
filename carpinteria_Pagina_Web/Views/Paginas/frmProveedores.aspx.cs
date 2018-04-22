using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace carpinteria_Pagina_Web.Views.Paginas
{
    public partial class frmProveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (GridView gvRow in gvwDatos.Rows)
                if (((Label)gvRow.FindControl("lblCodigo")).Text.Equals(txtCodigo.Text)) throw new Exception("El codigo ya fue agregado");


            try
            {
                DataTable dtDatos = new DataTable();
                if (Session["proveedores"] == null)
                {
                    dtDatos.Columns.Add("Cedula_Nit");
                    dtDatos.Columns.Add("RazonSocial");
                    dtDatos.Columns.Add("Direccion");
                    dtDatos.Columns.Add("Telefono1");
                    dtDatos.Columns.Add("Telefono2");
                    dtDatos.Columns.Add("Celular");
                    dtDatos.Columns.Add("Correo");
                    dtDatos.Columns.Add("Producto");
                    ///dtDatos Acepta los cambios
                    dtDatos.AcceptChanges();
                }
                else 
                {
                    dtDatos = (DataTable)Session["proveedores"];
                    DataRow drRow = dtDatos.NewRow();
                    drRow["Cedula_Nit"] = txtCodigo.Text;
                    drRow["RazonSocial"] = RazónSocial.Text;
                    drRow["Direccion"] = Dirección.Text;
                    drRow["Telefono1"] = Teléfono1.Text;
                    drRow["Telefono2"] = Teléfono2.Text;
                    drRow["Celular"] = Celular.Text;
                    drRow["Correo"] = Correo.Text;
                    drRow["Producto"] = Producto.Text;

                    dtDatos.Rows.Add(drRow);
                    dtDatos.AcceptChanges();

                    gvwDatos.DataSource = dtDatos;
                    gvwDatos.DataBind();

                    Session["proveedores"] = dtDatos;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }



        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);
                if (e.CommandName == "Eliminar") ;
                {
                    DataTable dtDatos = (DataTable)Session["proveedores"];
                    dtDatos.Rows.RemoveAt(inIndice);

                    Session["proveedores"] = dtDatos;
                    gvwDatos.DataSource = dtDatos;
                    gvwDatos.DataBind();
                
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
                {

                    Session.Remove("proveedores");
                    gvwDatos.DataSource = null;
                    gvwDatos.DataBind();

                }
                catch (Exception ex)
            {
                Response.Write("<script language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void btnConfirmacion_Click(object sender, EventArgs e)
        {


        }
    }
}