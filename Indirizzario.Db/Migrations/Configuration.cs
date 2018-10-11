namespace Indirizzario.Db.Migrations
{
    using Indirizzario.Db.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Indirizzario.Db.Models.IndirizzarioDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Indirizzario.Db.Models.IndirizzarioDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.People.AddOrUpdate(x => x.Id,
            new Person() { Id=1, FirstName = "Adrian", LastName = "Unterfinger", Gender="Maschio" },
            new Person() { Id=2, FirstName = "Denis", LastName = "Raimond", Gender = "Maschio" }
            );

            context.Addresses.AddOrUpdate(x => x.Id,
            new Address() { Street="via Campagne", Postcode="6596", Town="Gordola", State="Ticino", Country="Svizzera", PersonId=1  },
            new Address() { Street = "Nucleo 8", Postcode = "6958", Town = "Bidogno", State = "Ticino", Country = "Svizzera", PersonId = 1 },
            new Address() { Street = "via Statale", Postcode = "65847", Town = "Milano", State = "Lombardia", Country = "Italia", PersonId = 2 }
            );

        }

    }
}
