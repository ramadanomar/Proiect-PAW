using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
    internal interface IInchiriere
    {
        int InchiriereId { get; set; }
        int FilmId { get; set; }
        int ClientId { get; set; }
        DateTime DataInchiriere { get; set; }
        DateTime DataReturnare { get; set; }
    }
}
