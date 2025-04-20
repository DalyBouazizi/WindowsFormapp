using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        int code_client;
        String nom;
        String prenom;
        String adr;
        int tel;
        String mail;

        public  Client(int code_client, string nom, string prenom, string adr, int tel, string mail)
        {
            this.code_client = code_client;
            this.nom = nom;
            this.prenom = prenom;
            this.adr = adr;
            this.tel = tel;
            this.mail = mail;
        }

        public int Code_client { get => code_client; set => code_client = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adr { get => adr; set => adr = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
