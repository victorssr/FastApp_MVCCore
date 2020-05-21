using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastApp_MVCCore.Models
{
    public class Curso : Entity
    {
        public Guid ProfessorId { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(1000, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public decimal Valor { get; set; }

        [DisplayName("Duração")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Imagem { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        // RELACIONAMENTOS
        public Professor Professor { get; set; }

    }
}
