using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Data.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.DTOs.Articles;
using AutoMapper;

namespace Blog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IMapper Mapper { get; }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("29C9DA8D-2679-4DE3-98E6-EA743DC1F305");
            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                UserId=userId
            };
            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }
        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles= await unitOfWork.GetRepository<Article>().GetAllAsync(x=>x.IsDeleted==false,x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

      

        public async Task<ArticleUpdateDto> GetArticleWithIdAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            var map = mapper.Map<ArticleUpdateDto>(article);
            return map;
        }
        public async Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article=await unitOfWork.GetRepository<Article>().GetAsync(x=>!x.IsDeleted&&x.Id==articleUpdateDto.Id);
            article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;
            
            
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();
        }
    }
}
