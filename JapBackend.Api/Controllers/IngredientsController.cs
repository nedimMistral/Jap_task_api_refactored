using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Requests.Ingredient;
using Microsoft.AspNetCore.Mvc;

namespace JapBackend.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsService _ingredientsService;

        public IngredientsController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<IngredientDto>>> Get()
        {
            return Ok(await _ingredientsService.Get());
        }
    }
}