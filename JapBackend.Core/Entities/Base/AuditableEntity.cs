using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Core.Entities.Base
{
    public class AuditableEntity : DeletableEntity
    {
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public int ModifiedById { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}