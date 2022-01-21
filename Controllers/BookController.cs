using DAW2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public static List<Book> books = new List<Book>
            {
                new Book { Id=1, Name="Book1", Description="New book1" },
                new Book { Id=2, Name="Book2", Description="New book2" },
                new Book { Id=3, Name="Book3", Description="New book3" },
            };

        [HttpGet("getBooks")]
        public List<Book> Get()
        {
            return books;
        }

        [HttpGet("getStudentById")]
        public Book GetBookById(int Id)
        {
            return books.FirstOrDefault(s => s.Id.Equals(Id));
        }

        //create

        [HttpPost("FromForm")]
        public IActionResult Add(Book book)
        {
            books.Add(book);
            return Ok(books);
        }
        
        [HttpPut("Update")]
        public IActionResult Update(Book book)
        {
            var bookIndex = books.FindIndex((Book _book)=> _book.Id.Equals(book.Id));
            books[bookIndex] = book;
            return Ok(books);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(Book book)
        {
            var bookIndex = books.FindIndex((Book _book) => _book.Id.Equals(book.Id));
            books[bookIndex] = book;
            books.Remove(books[bookIndex]);
            return Ok(books);
        }

    }
}
