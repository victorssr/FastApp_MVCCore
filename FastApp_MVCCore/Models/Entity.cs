using System;

namespace FastApp_MVCCore.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
