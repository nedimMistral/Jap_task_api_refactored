using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities.Base;
using JapBackend.Common;

namespace JapBackend.Core.Entities
{
    public class Ingredient : AuditableEntity
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double UnitQuantity { get; set; }
        public UOM UnitOfMeasure { get; set; }
    }
}