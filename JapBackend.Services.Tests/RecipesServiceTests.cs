using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Common;
using JapBackend.Core.Entities;
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
                    Name = "Raising",
                    UnitOfMeasure = UOM.gram,
                    UnitPrice = 0.1,
                }
            );
            _dbContext.SaveChanges();
        }
    }
}
