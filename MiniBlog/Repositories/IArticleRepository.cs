using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniBlog.Model;

namespace MiniBlog.Repositories
{
    public interface IArticleRepository
    {
        public Task<Article> GetById(Guid id);
        public Task<Article> CreateArticle(Article article);
        public Task<List<Article>> GetAll();
    }
}
