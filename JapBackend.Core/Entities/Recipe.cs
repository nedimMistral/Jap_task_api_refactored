using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities.Base;

namespace JapBackend.Core.Entities
{
    public class Recipe : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PrepTimeMinutes { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}