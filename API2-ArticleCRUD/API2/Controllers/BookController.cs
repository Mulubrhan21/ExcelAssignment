using API2.model;
using API2.Repository;
using API2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository bookRepository;
        private readonly BookService bookService;

        public BookController(IBookRepository bookRepository , BookService bookService)
        {
            this.bookRepository = bookRepository;
            this.bookService = bookService;
        }

        [HttpGet("{ISBN}")]
        public async Task<ActionResult<Book>> getBook(int ISBN)
        {
            return await bookRepository.getBookByISBN(ISBN);
        }
        [HttpGet]
        public async Task<IEnumerable<Book>> getBooks()
        {
            return await bookService.getBooks();
        }

        [HttpPost]
        public async Task<ActionResult<Book>> RegisterBook([FromBody]Book book)
        {
           return await bookRepository.CreateBook(book);

           // var newBook= bookRepository.CreateBook(book);
           //return CreatedAtAction(nameof(getBooks), new { id = newBook.Id });
        }
        [HttpPut("{ISBN}")]
        public async Task<ActionResult<Book>> updateBook(int ISBN,[FromBody] Book book)
        {
            if (ISBN !=book.ISBN)     
                return BadRequest("Be selam new ?");

            //var bookUpdate = getBook(ISBN);
            //if (bookUpdate == null)
            //    return NotFound($"Book with this isbn {ISBN} not found");

            return await bookRepository.UpdateBook(book);
           
            // var newBook= bookRepository.CreateBook(book);
            //return CreatedAtAction(nameof(getBooks), new { id = newBook.Id });
        }

    }
}
