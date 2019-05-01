namespace MoneyXchange.Api.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MoneyXchange.Api.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MoneyXchange.Api.Models.MoneyXchangeApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoneyXchange.Api.Models.MoneyXchangeApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Exchanges.AddOrUpdate(
                new Exchange()
                {
                    Id = 1,
                    currency = "EUR",
                    factor = 0.89F
                });
        }
    }
}
