using Microsoft.AspNetCore.Mvc;
using meuProjeto.Data;
using meuProjeto.Models;
using System.Linq;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace meuProjeto.Controllers{

    [ApiController]
    [Route("api/Book")] // rota do localhost:5001/api/Book
    public class BookController : Controller {

        private readonly BookContext _context; // cria um objeto do tipo BookContext

        public BookController(BookContext context) // construtor
        {
            _context = context;
        }

        // public IActionResult Index() // método que retorna a view Index
        // {
        //     var livros = _context.Books.ToList(); // cria uma lista de livros,
        //     // pega todos os livros criados no banco de dados e coloca na lista
        //     return View(livros); // retorna a view Index
            
        // }

        [HttpGet("GetBook")] // método que retorna todos os livros
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync(); // retorna todos os livros por meio
            // do metodo toListAsync que é um método assíncrono que retorna uma lista de livros
        }

        [HttpPost("CreateBook")]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);

        }

    }
}