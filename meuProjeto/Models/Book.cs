using System.ComponentModel.DataAnnotations;

namespace meuProjeto.Models {
    public class Book
    {
        // [Required]
        public int Id { get; set; }

        [Required] // campo obrigatorio bb 
        public string Titulo { get; set; }

        [Required]
        public string Autor { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public int Year { get; set; }

        
    }
}