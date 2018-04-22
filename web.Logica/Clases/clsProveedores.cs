using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;



namespace web.Logica.Clases
{
     public class clsProveedores
    {

        string stConexion;
        
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        SqlDataAdapter sqlDataAdapter = null;
        SqlParameter sqlParameter = null;

        public clsProveedores()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.stGetConexion();

        }

        public string stInsertarProveedoresMasivos(GridView gvwDatos )  
        {
            try 
            {
                XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("proveedores"));

                XElement xl;

                foreach (GridViewRow gvRow in gvwDatos.Rows) 
                {
                    xl = new XElement("rows",
                                       new XElement("Cedula_Nit", ((Label)gvRow.FindControl("lblCodigo")).Text),
                                       new XElement("RazonSocial", gvRow.Cells[1].Text),
                                       new XElement("Direccion", gvRow.Cells[2].Text),
                                       new XElement("Telefono1", gvRow.Cells[3].Text),
                                       new XElement("Telefono2", gvRow.Cells[4].Text),
                                       new XElement("Celular", gvRow.Cells[5].Text),
                                       new XElement("Correo", gvRow.Cells[6].Text),
                                       new XElement("Producto", gvRow.Cells[7].Text)                                       
                                       );
                    xml.Element("proveedores").Add(xl);
                }

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                cmd = new SqlCommand("spInsertarProveedoresMasivos", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cXML", xml.ToString()));
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.Direction = ParameterDirection.Output;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                cmd.Parameters.Add(sqlParameter);

                cmd.ExecuteNonQuery();
                return sqlParameter.Value.ToString();

            }
            catch(Exception ex){ throw ex;}
        
        
        }


    }
}
