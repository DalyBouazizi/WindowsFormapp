using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ClientADO
    {
        Connection cnx = new Connection();
        
        public int insert_client(Client c)
        {
            cnx.start_cnx();
            String req = "insert into client values(@nom,@prenom,@adr,@tel,@mail)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = req;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Connection = cnx;

            //cmd.Parameters.Add(new SqlParameter("@code_client",System.Data.SqlDbType.VarChar, c.Code_client));


            SqlParameter paramnom = new SqlParameter("@nom", System.Data.SqlDbType.VarChar);
            SqlParameter paramprenom = new SqlParameter("@prenom", System.Data.SqlDbType.VarChar);
            SqlParameter paramadr = new SqlParameter("@adr", System.Data.SqlDbType.VarChar);
            SqlParameter paramtel = new SqlParameter("@tel", System.Data.SqlDbType.Int);
            SqlParameter parammail = new SqlParameter("@mail", System.Data.SqlDbType.VarChar);

            paramnom.Value = c.Nom;
            paramprenom.Value = c.Prenom;
            paramadr.Value = c.Adr;
            paramtel.Value = c.Tel;
            parammail.Value = c.Mail;

            cmd.Parameters.Add(paramnom);
            cmd.Parameters.Add(paramprenom);
            cmd.Parameters.Add(paramadr);
            cmd.Parameters.Add(paramtel);
            cmd.Parameters.Add(parammail);


            return cmd.ExecuteNonQuery();
            
            
       
        }
    }
}
