using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Common;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Recipe;
using JapBackend.Core.Requests.RecipeIngredient;
using JapBackend.Database;
using JapBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace JapBackend.Services.Tests
{
    [TestFixture]
    public class RecipesServiceTests
    {
        private RecipesService _recipesService;
        private RecipeRepository _recipeRepository;
        private DbContextOptions<JapBackendDbContext> _options;
        private JapBackendDbContext _dbContext;
        private Mock<IMapper> mockMapper;
        private Mock<HttpContextAccessor> mockHttpCtx;
        private Mock<RecipeCostService> mockRecipeCostService;  

        [OneTimeSetUp]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<JapBackendDbContext>().UseInMemoryDatabase(databaseName: "TestDB").Options;
            _dbContext = new JapBackendDbContext(_options);
            mockMapper = new Mock<IMapper>();
            mockRecipeCostService = new Mock<RecipeCostService>();
            mockHttpCtx = new Mock<HttpContextAccessor>();
            _recipeRepository = new RecipeRepository(_dbContext, mockMapper.Object, mockHttpCtx.Object);
            _recipesService = new RecipesService(_recipeRepository, mockHttpCtx.Object, mockRecipeCostService.Object);

            _dbContext.Users.Add(
                new User
                {
                    Id = 0,
                }
            );
            _dbContext.Categories.Add(
                new Category
                {
                    Id = 0,
                    Name = "Sweets",
                }
            );
            _dbContext.Ingredients.AddRange(
                new Ingredient 
                {
                    Id = 0,
                    Name = "Sugar",
                    CreatedById = 0,
                    UnitPrice = 0.1,
                    UnitOfMeasure = UOM.teaspoon,
                },
                new Ingredient
                {
                    Id = 1,
                    Name = "Eggs",
                    UnitOfMeasure = UOM.piece,
                    UnitPrice = 0.3,
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "All-purpose flour",
                    UnitOfMeasure = UOM.gram,
                    UnitPrice = 0.01,
                },
                new Ingredient{
                    Id = 3,
                    Name = "Raisins",
                    UnitOfMeasure = UOM.gram,
                    UnitPrice = 0.1,
                }
            );
            _dbContext.SaveChanges();
        }

        [Test]
        public async Task InsertRecipe_Pass()
        {
            var req = new RecipeInsertRequest
            {
                Title = "Test recipe",
                Description = "Test recipe description",
                CategoryId = 0,
                UserId = 0,
                RecipeIngredients = new List<RecipeIngredientDto> {
                    new RecipeIngredientDto 
                    {
                        IngredientName = "Eggs",
                        IngredientId = 1,
                        Quantity = 3,
                        Price = 0.3,
                    },
                    new RecipeIngredientDto 
                    {
                        IngredientName = "Raisins",
                        IngredientId = 3,
                        Quantity = 20,
                        Price = 0.1,
                    },
                    new RecipeIngredientDto 
                    {
                        IngredientName = "All-purpose flour",
                        IngredientId = 2,
                        Quantity = 100,
                        Price = 0.01,
                    }
                }
            };

            await _recipesService.InsertRecipe(req);

            Recipe record = await _dbContext.Recipes.FirstOrDefaultAsync(x => x.Title == req.Title);

            Assert.That(record.RecipeIngredients, Is.Unique);
            Assert.That(record.RecipeIngredients.Count, Is.EqualTo(3));
            Assert.That(record.RecipeIngredients.First().IngredientId, Is.EqualTo(req.RecipeIngredients.First().IngredientId));
        }

        [Test]
        public async Task Test_NoIgredientsThrowsException()
        {
            var req = new RecipeInsertRequest
            {
                Title = "No ingredients",
                Description = "Test recipe without ingredients",
                CategoryId = 0,
                UserId = 0,
                RecipeIngredients = new List<RecipeIngredientDto> {}
            };

            Assert.Throws<Exception>(async () => await _recipesService.InsertRecipe(req));
        }


    }
}
