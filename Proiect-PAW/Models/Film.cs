using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models { 

    internal class Film : IFilm
    {
        public required int FilmId { get; set; }
        public required string Nume { get; set; }
        public required CategorieFilm Categorie { get; set; }
        public required int Pret { get; set; }
    }
}
