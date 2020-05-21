using System;

namespace FastApp_MVCCore.Models
{
    public class Endereco : Entity
    {

        public Guid ProfessorId { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        // RELACIONAMENTO
        public Professor Professor { get; set; }

    }
}
