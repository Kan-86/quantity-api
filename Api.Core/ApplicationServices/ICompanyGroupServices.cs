
using Api.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.ApplicationServices
{
    public interface ICompanyGroupServices
    {
        IEnumerable<CompanyGroup> ReadAllGroups(string name);
    }
}
