using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Category;
using JapBackend.Core.Requests.RecipeIngredient;
using JapBackend.Core.Requests.User;

namespace JapBackend.Core.Requests.Recipe
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public int PrepTimeMinutes { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public List<RecipeIngredientDto> RecipeIngredients { get; set; }
    }
}