
using Api.Core.Entity.Entities;
using System.Collections.Generic;

namespace Api.Core.DomainServices
{
    public interface ICompanyGroupRepositories
    {
        IEnumerable<CompanyGroup> ReadAllGroups(string name);
    }
}
