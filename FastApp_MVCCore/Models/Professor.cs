using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastApp_MVCCore.Models
{
    public class Professor : Entity
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Nome { get; set; }
        public TipoProfessor TipoProfessor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Documento { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        // RELACIONAMENTO
        public Endereco Endereco { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }

    }
}
