using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using animal_kingdom.Models;

namespace animal_kingdom.Data
{
    public class AnimalKingdomContext : DbContext
    {
        public AnimalKingdomContext (DbContextOptions<AnimalKingdomContext> options)
            : base(options)
        {
        }

    

        public DbSet<animal_kingdom.Models.Animal> Animal { get; set; } = default!;
    }
}
