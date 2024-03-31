using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
     public class Client : IClient
    {

        private static int _lastClientId = 0;


        public  int ClientId { get; set; }
        public  string Nume { get; set; }
        public  Sex Sex { get; set; }
        public  string Telefon { get; set; }

        // Constructori
        public Client()
        {
            this.ClientId = ++_lastClientId;
            this.Nume = "Anonim";
            this.Sex = Sex.Necunoscut;
            this.Telefon = "0000000000";
        }

        // Constructor cu nume, sex si telefon ca parametri
        public Client(string nume, Sex sex, string telefon)
        {
            ClientId = ++_lastClientId; // autoincrement
            Nume = nume;
            Sex = sex;
            Telefon = telefon;
        }

        // Nu cred ca o sa folosim asta ca sa ne asiguram ca id ul mereu va fi unic
        public Client(int clientId, string nume, Sex sex, string telefon)
        {
            this.ClientId = clientId;
            this.Nume = nume;
            this.Sex = sex;
            this.Telefon = telefon;
        }

    }
}
