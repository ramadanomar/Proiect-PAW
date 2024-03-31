using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
    internal class Inchiriere : IInchiriere
    {
        public required int InchiriereId { get; set; }
        public required int FilmId { get; set; }
        public required int ClientId { get; set; }
        public required DateTime DataInchiriere { get; set; }
        public required DateTime DataReturnare { get; set; }
    }
}
