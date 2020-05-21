using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastApp_MVCCore.Models
{
    public class Endereco : Entity
    {

        public Guid ProfessorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(300, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Numero { get; set; }
        
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} deve ter entre {2} até {1} caracteres.")]
        public string Estado { get; set; }

        // RELACIONAMENTO
        public Professor Professor { get; set; }

    }
}
