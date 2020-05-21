using System;

namespace FastApp_MVCCore.Models
{
    public class Curso : Entity
    {
        public Guid ProfessorId { get; set; }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Duracao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }

        // RELACIONAMENTOS
        public Professor Professor { get; set; }

    }
}
