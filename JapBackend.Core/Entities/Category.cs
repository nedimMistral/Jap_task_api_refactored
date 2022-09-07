using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities.Base;

namespace JapBackend.Core.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }
    }
}