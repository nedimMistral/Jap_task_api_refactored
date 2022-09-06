using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Core.Entities.Base
{
    public class DeletableEntity : BaseEntity
    {
        public bool IsDeleted { get; set; }
    }
}