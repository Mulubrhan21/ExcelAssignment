using API2.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API2.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext dbContext;

        public BookRepository(BookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
           await  dbContext.AddAsync(book);
            dbContext.SaveChanges();
            return book;
        }

        public async Task<ActionResult<Book>> DeleteBook(int ISBN)
        {
            var book =await getBookByISBN(ISBN);
             dbContext.Remove(book);
             dbContext.SaveChanges();
            return book;
        }

        public async Task<ActionResult<Book>> getBookByISBN(int ISBN)
        {
            return await dbContext.Books.FindAsync(ISBN);
        }

        public async Task<IEnumerable<Book>> getBooks()
        {
           return await dbContext.Books.ToListAsync();

        }

        public async Task<ActionResult<Book>> UpdateBook( Book book)
        {
            //var booktoUpdate = await getBookByISBN(ISBN);

             dbContext.Entry(book).State=EntityState.Modified;
              dbContext.SaveChanges();
            return  book;
        }
    }
}
