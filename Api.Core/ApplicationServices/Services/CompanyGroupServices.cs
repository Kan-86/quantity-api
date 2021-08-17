
using Api.Core.DomainServices;
using Api.Core.Entity.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Core.ApplicationServices.Services
{
    public class CompanyGroupServices : ICompanyGroupServices
    {
        readonly ICompanyGroupRepositories _icompanyGroupRepositories;
        public CompanyGroupServices(ICompanyGroupRepositories icompanyGroupRepositories)
        {
            _icompanyGroupRepositories = icompanyGroupRepositories;
        }
        public IEnumerable<CompanyGroup> ReadAllGroups(string name)
        {
            var groups = _icompanyGroupRepositories.ReadAllGroups(name);

            return groups;
        }
    }
}
