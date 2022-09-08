using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;

namespace JapBackend.Core.Requests.Category
{
    public class CategorySearchRequest : BaseSearch
    {
        public string Name { get; set; }
    }
}