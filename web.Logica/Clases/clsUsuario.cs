using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace web.Logica
{
    public class clsUsuario
    {

        string stConexion;
        //string dsConsultar;
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        SqlDataAdapter sqlDataAdapter = null;
        SqlParameter sqlParameter = null;



        public clsUsuario()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.stGetConexion();

        }

        public DataSet dsConsultar(string stLogin, string stPassword)
        {
            try
            {
                DataSet dsConsulta = new DataSet();
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                cmd = new SqlCommand("spConsultarUsuarios", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@clogin", stLogin));
                cmd.Parameters.Add(new SqlParameter("@cPassword", stPassword));


                cmd.ExecuteNonQuery();

                sqlDataAdapter = new SqlDataAdapter(cmd);

                sqlDataAdapter.Fill(dsConsulta);
                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
        }


    }
}
