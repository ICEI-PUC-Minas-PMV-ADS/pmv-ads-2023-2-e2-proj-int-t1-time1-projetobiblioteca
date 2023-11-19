using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUCMinas_Projeto_Biblioteca.Models {

    [Table("Reservas")]
    public class Reserva {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o título!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o usuário!")]

        [Display(Name = "Identificação do Usuário")]

        public int UsuarioId { get; set; } // Pode ser o ID do usuário que está fazendo a reserva

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Data da Reserva")]

        public DateTime DataReserva { get; set; }

        [Display(Name = "Título do Livro")]

        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public Livros Livro { get; set; }
    }
}
