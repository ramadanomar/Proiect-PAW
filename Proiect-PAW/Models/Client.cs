using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
    internal class Client : IClient
    {
        public required int ClientId { get; set; }
        public required string Nume { get; set; }
        public required Sex Sex { get; set; }
        public required string Telefon { get; set; }
    }
}
