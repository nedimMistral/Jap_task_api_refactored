using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Core.Requests.Category
{
    public class CategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}