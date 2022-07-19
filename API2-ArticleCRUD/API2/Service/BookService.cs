using API2.model;
using API2.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API2.Service
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            return await bookRepository.CreateBook(book);
        }

        public Task<ActionResult<Book>> DeleteBook(int ISBN)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActionResult<Book>> getBookByISBN(int ISBN)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Book>> getBooks()
        {
            return await bookRepository.getBooks();
        }

        public Task<ActionResult<Book>> UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}
