using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Requests.Recipe;
using Microsoft.AspNetCore.Mvc;

namespace JapBackend.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService _recipesService;

        public RecipesController(IRecipesService recipesService)
        {
            _recipesService = recipesService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RecipeInsertRequest request)
        {
            return Ok(await _recipesService.InsertRecipe(request));
        }
    }
}