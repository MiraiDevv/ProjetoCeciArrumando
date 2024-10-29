using Microsoft.EntityFrameworkCore;
using meuProjeto.Models;

// servir para banco de dados bbr
namespace meuProjeto.Data {
    public class BookContext : DbContext //faz uma herança da classe DbContext
    // DbContext é uma classe do Entity Framework Core que permite a comunicação com o banco de dados.
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }// construtor

        // é como se fosse uma lista de livros, tem o metodo Add que adiciona um livro, o metodo Remove que remove um livro
        public DbSet<Book> Books { get; set; } // cria uma tabela chamada Books no banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured){ // optionsBuilder.IsConfigured é uma propriedade que verifica se o contexto já foi configurado
                var connectionString = "server=localhost;port=3306;database=sistema_livros;user=root;password=root";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
    }
}