using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Models
{
    enum CategorieFilm
    {
        Comedie,
        Actiune,
        Drama,
        Horror,
        SF,
        Animatie,
        Documentar
    }

    internal interface IFilm
    {
        int FilmId { get; set; }
        string Nume { get; set; }
        CategorieFilm Categorie { get; set; }
        int Pret { get; set; }
    }
}
