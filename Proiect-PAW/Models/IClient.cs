using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
    public enum Sex
    {
        Masculin,
        Feminin,
        Necunoscut
    }

    internal interface IClient
    {
        int ClientId { get; set; }
        string Nume { get; set; }
        Sex Sex { get; set; }
        string Telefon { get; set; }
    }
}
