using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Entity.Entities
{
    public class CompanyGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Accounts { get; set; }
        public string? accountCount { get; set; }
    }
    public class Accounts
    {
        public string Id { get; set; }
        public string CompanyGroupId { get; set; }
        public CompanyGroup CompanyGroup { get; set; }
    }
}
