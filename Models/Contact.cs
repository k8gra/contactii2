using System.ComponentModel.DataAnnotations;

namespace contactii2.Models
{
    public class Contact
    {
        public int ContactID { get; set; } //pk
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Addresse { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        [Display(Name ="Code Postal")]
        public string CodePostal { get; set; }
        [Phone]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Date de creation")]
        public DateTime DateCreation { get; set; }

        [Display(Name = "Categorie")]
        public int CategorieID { get; set; } //fk
        public string Username { get; set; }

        public virtual Categorie? Categorie { get; set; }

    }
}
