using API2.model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API2.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> getBooks();
        public Task<ActionResult<Book>> getBookByISBN(int ISBN);
        public Task<ActionResult<Book>> CreateBook(Book book);
        public Task<ActionResult<Book>> UpdateBook(Book book);
        public Task<ActionResult<Book>> DeleteBook(int ISBN);


    }
}
