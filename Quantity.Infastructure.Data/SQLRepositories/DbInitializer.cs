using Api.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity.Infastructure.Data.SQLRepositories
{
    public class DbInitializer
    {
        public DbInitializer()
        {

        }

        public static void SeedDb(QuantityApiContext ctx)
        {


            List<CompanyGroup> users = new List<CompanyGroup>
            {
                new CompanyGroup {
                    Id = "asdasd",
                    Name = "kris",
                    Status = "Active"
                },
                new CompanyGroup {
                    Name = "jacob",
                    Id = "sdadsad",
                    Status = "Active"
                }
            };


            ctx.CompanyGroup.AddRange(users);
            ctx.SaveChanges();
        }
    }
}
