using System;

namespace ResourceBox.Domain.Entities
{
    public class Entrada
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public virtual Responsavel Responsavel { get; set; }
    }
}
