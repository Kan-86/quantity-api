using Api.Core.DomainServices;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infastructure.Data.SQLRepositories
{
    public class CompanyGroupRepositories : ICompanyGroupRepositories
    {
        public IEnumerable<CompanyGroupEntity> ReadAllGroups()
        {
            throw new NotImplementedException();
        }
    }
}
