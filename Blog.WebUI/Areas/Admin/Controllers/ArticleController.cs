using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IValidator<Article> validator)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = mapper.Map<Article>(articleAddDto);

            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await articleService.CreateArticleAsync(articleAddDto);
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
                
                
            }
            else
            {
                result.AddToModelState(this.ModelState);
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                return View(new ArticleAddDto { Categories = categories });
            }


        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var article = await articleService.GetArticleWithIdAsync(articleId);
            ArticleUpdateDto articleUpdateDto = new ArticleUpdateDto()
            {
                Categories = categories,
                Id = article.Id,
                Content = article.Content,
                Title = article.Title
            };
            return View(articleUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = mapper.Map<Article>(articleUpdateDto);

            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await articleService.UpdateArticleAsync(articleUpdateDto);
                
            }

            else
            {
                result.AddToModelState(this.ModelState);
            }
            //articleService.GetArticleWithIdAsync(articleUpdateDto.Id);
            //ArticleUpdateDto article =new ArticleUpdateDto() 
            //{ 
            //    Id=articleUpdateDto.Id,
            //    Title= articleUpdateDto.Title,
            //    Content=articleUpdateDto.Content,
            //    CategoryId=articleUpdateDto.CategoryId
            //};

            //var article=await articleService.GetArticleWithIdAsync(articleUpdateDto.Id);
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            articleUpdateDto.Categories = categories;

            
            return RedirectToAction("Index", "Article");
        }

        public async Task<IActionResult> Delete(Guid articleId)
        {

            await articleService.SafeDeleteArticleAsyncDelete(articleId);
            return RedirectToAction("Index", "Article");
        }
    }
}
