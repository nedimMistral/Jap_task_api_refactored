using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;

namespace JapBackend.Core.Requests.Recipe
{
    public class RecipeSearchRequest : BaseSearch
    {
        public int? CategoryId { get; set; }
    }
}