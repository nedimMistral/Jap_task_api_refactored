using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Requests.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JapBackend.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categorySvc;

        public CategoriesController(ICategoriesService categorySvc)
        {
            _categorySvc = categorySvc;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> Get([FromQuery] int n)
        {
            return Ok(await _categorySvc.Get(n));
        }

    }
}