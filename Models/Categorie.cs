using System.ComponentModel.DataAnnotations;

namespace contactii2.Models
{
    public class Categorie
    {
        public int CategorieID { get; set; } //pk
        [Display(Name ="Categorie")]
        public string CategorieName { get; set; }
    }
}