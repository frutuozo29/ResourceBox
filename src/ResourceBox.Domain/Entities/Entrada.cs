using System;
using System.Collections.Generic;

namespace ResourceBox.Domain.Entities
{
    public class Entrada
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public long ResponsavelId { get; set; }
        public virtual Responsavel Responsavel { get; set; }
        public virtual ICollection<RecursoEntrada> RecursosEntrada { get; set; }
    }
}
