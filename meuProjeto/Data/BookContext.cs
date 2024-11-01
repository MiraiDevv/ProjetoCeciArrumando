using Microsoft.EntityFrameworkCore;
using meuProjeto.Models;

namespace meuProjeto.Data {
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}