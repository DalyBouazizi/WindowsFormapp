using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public  class Connection
    {
        public static SqlConnection cnx= new SqlConnection("Data Source=DALY-S-PC\\VE_SERVER; Initial Catalog=magasin; Integrated Security=True; Encrypt=False");



        public void start_cnx()
        {
            if(cnx.State == System.Data.ConnectionState.Closed)
            {
               
              cnx.Open();
            
            }
          

        }
        public static implicit operator SqlConnection(Connection v)
        {
            return cnx;
        }

    }
}
