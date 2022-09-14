using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;

namespace JapBackend.Core.Requests.Ingredient
{
    public class IngredientSearchRequest : BaseSearch
    {
        public string Term { get; set; }
    }
}