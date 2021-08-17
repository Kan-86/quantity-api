using Api.Core.DomainServices;
using Api.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Quantity.Infastructure.Data.SQLRepositories
{
    public class CompanyGroupRepositories : ICompanyGroupRepositories
    {
         readonly QuantityApiContext _ctx;

        public CompanyGroupRepositories(QuantityApiContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<CompanyGroup> ReadAllGroups(string name)
        {
            var ordered = _ctx.CompanyGroup.Where(r => r.Status.Contains("SUSPENDED") || r.Status.Contains("ACTIVE"));
            if (name == "Name")
            {
                return ordered.OrderBy(r => r.Name);
            }
            return ordered.OrderBy(r => r.accountCount);
        }

    }
}
