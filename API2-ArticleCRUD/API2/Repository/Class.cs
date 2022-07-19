using API2.model;
using Microsoft.EntityFrameworkCore;
using System;

namespace API2.Repository
{
    public class ArticleRepository : IRepository
    {
        BookDbContext db;
        public ArticleRepository(BookDbContext db)
        {
            this.db = db;
        }

        public Guid Create(Article article)
        {
           var article1=db.Article.Add(article);
            db.SaveChangesAsync();
            return article1.Entity.Id;
        }

        public bool Delete(Guid id)
        {
            Article article = Get(id);
            if (article == null)
                return false;

            db.Article.Remove(article);
            db.SaveChanges();
            return true;
            
        }

        public Article Get(Guid id)
        {
            var article =db.Article.Find(id);

            if (article == null)
            {
                return null;
            }

            return article;
        }

        public bool Update(Article articletoUpdate)
        {
            db.Entry(articletoUpdate).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
