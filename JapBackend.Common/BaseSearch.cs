using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Common
{
    public class BaseSearch
    {
        public BaseSearch()
        {
            //Includes = new List<string>();
        }

        public int? PageSize { get; set; }
        public int? Page { get; set; }
        public bool? RetrieveAll { get; set; }
        public bool? IncludeCount { get; set; }
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
        public string? Includes { get; set; }
    }

     public enum SortOrder
    {
        ASC,
        DESC
    }
}