using System.Collections.Generic;

namespace FastApp_MVCCore.Models
{
    public class Professor : Entity
    {

        public string Nome { get; set; }
        public TipoProfessor TipoProfessor { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }

        // RELACIONAMENTO
        public Endereco Endereco { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }

    }
}
