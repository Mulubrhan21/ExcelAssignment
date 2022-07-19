using API2.model;
using System;

namespace API2.Repository
{
    public interface IRepository
    {
        Article Get(Guid id);
       Guid Create(Article article);
        bool Delete(Guid id);
        bool Update(Article articletoUpdate);
    }
}


