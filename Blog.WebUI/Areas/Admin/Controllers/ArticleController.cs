using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService,ICategoryService categoryService,IMapper mapper)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var articles= await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories=await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories=categories});
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            await articleService.CreateArticleAsync(articleAddDto);
            return RedirectToAction("Index", "Article", new {Area="Admin"});
            //var categories = await categoryService.GetAllCategoriesNonDeleted();
            //return View(new ArticleAddDto { Categories = categories });
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var article = await articleService.GetArticleWithIdAsync(articleId);
            ArticleUpdateDto articleUpdateDto =new ArticleUpdateDto() 
            { 
                Categories=categories,
                Id=article.Id,
                Content=article.Content,
                Title=article.Title
            };
            return View(articleUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
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

            await articleService.UpdateArticleAsync(articleUpdateDto);
            return RedirectToAction("Index", "Article");
        }
    }
}
