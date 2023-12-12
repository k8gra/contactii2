using Microsoft.EntityFrameworkCore;
using contactii2.Data;
using contactii2.Models;
using Microsoft.AspNetCore.Identity;

namespace projetfinal.Data
{
    public class SeedData2
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Contact.Any())
                {
                    return; //deja seeded
                }
                context.Contact.AddRange(
                    new Contact
                    {
                        Prenom="Alice",
                        Nom="Albert",
                        Addresse="123 rue Albert",
                        Ville="Moncton",
                        Province="NB",
                        CodePostal="E9M 9M1",
                        Telephone="11231231234",
                        Email="alice@gmail.com",
                        DateCreation=DateTime.Now,
                        CategorieID=4,
                        Username="ekg0391@umoncton.ca"

                    },
                    new Contact
                    {
                        Prenom = "Bob",
                        Nom = "Bobert",
                        Addresse = "123 rue Bob",
                        Ville = "Moncton",
                        Province = "NB",
                        CodePostal = "E9M 5P3",
                        Telephone = "11231231235",
                        Email = "bob@gmail.com",
                        DateCreation = DateTime.Now,
                        CategorieID = 4,
                        Username = "ekg0391@umoncton.ca"
                    },
                    new Contact
                    {
                        Prenom = "Charlie",
                        Nom = "Charlert",
                        Addresse = "123 rue Char",
                        Ville = "Moncton",
                        Province = "NB",
                        CodePostal = "E9M 5S9",
                        Telephone = "11231231236",
                        Email = "charlie@gmail.com",
                        DateCreation = DateTime.Now,
                        CategorieID = 4,
                        Username = "ekg0391@umoncton.ca"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
