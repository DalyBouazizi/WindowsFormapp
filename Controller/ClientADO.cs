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


        // ---------------------------------------


        // Delete a client by ID
        public int delete_client(int id)
        {
            cnx.start_cnx();
            string req = "DELETE FROM client WHERE code_client = @id";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }

        // Load (fetch) a client by ID
        public Client get_client_by_id(int id)
        {
            cnx.start_cnx();
            string req = "SELECT * FROM client WHERE code_client = @id";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cmd.Parameters.AddWithValue("@id", id);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    Client client = new Client(
                        code_client: Convert.ToInt32(dr["code_client"]),
                        nom: dr["nom"].ToString(),
                        prenom: dr["prenom"].ToString(),
                        adr: dr["adr"].ToString(),
                        tel: Convert.ToInt32(dr["tel"]),
                        mail: dr["mail"].ToString()
                    );
                    return client;
                }
                else
                {
                    return null;
                }
            }
        }


        // Update client
        public int update_client(Client c)
        {
            cnx.start_cnx();
            string req = "UPDATE client SET nom = @nom, prenom = @prenom, adr = @adr, tel = @tel, mail = @mail WHERE code_client = @id";
            SqlCommand cmd = new SqlCommand(req, cnx);
            cmd.Parameters.AddWithValue("@nom", c.Nom);
            cmd.Parameters.AddWithValue("@prenom", c.Prenom);
            cmd.Parameters.AddWithValue("@adr", c.Adr);
            cmd.Parameters.AddWithValue("@tel", c.Tel);
            cmd.Parameters.AddWithValue("@mail", c.Mail);
            cmd.Parameters.AddWithValue("@id", c.Code_client);

            return cmd.ExecuteNonQuery();
        }

    }
}
