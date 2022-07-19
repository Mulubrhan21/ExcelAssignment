using API2.model;
using API2.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API2.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        IRepository repository;
        public ArticleController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (article == null || article.Title == null)
            {
                return BadRequest();
            }
            Guid guid = repository.Create(article);
            return CreatedAtAction("Get", new { id = article.Id }, article);

        }
        [HttpGet("{id}")]
        public ActionResult<Article> Get(Guid id)
        {
            Article article = repository.Get(id);
            if (article == null)
            {
                return NotFound("Article not found");
            }
            return article;
        }

        [HttpDelete("{id}")]
        public ActionResult<Article> Delete(Guid id)
        {
            Article article = repository.Get(id);
            if (article == null)
            {
                return NotFound("Article not found");
            }
            if (repository.Delete(id))
                return article;
            else
                return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult Update(Guid id, Article articletoUpdate)
        {
            if (id != articletoUpdate.Id)
                return BadRequest();

            if (articletoUpdate == null)
            {
                return NotFound("Article not found");
            }
            if (articletoUpdate.Title == null || articletoUpdate.Title.Length == 0)
            {
                return BadRequest("Article Title not found");
            }
            if (repository.Update(articletoUpdate))
                return Ok();
            else
                return BadRequest();
        }

    }
}
