namespace ResourceBox.Domain.Entities
{
    public class RecursoEntrada
    {
        public long Id { get; set; }
        public long Qtde { get; set; }        
        public long RecursoId { get; set; }
        public virtual Recurso Recurso { get; set; }
        public virtual Entrada Entrada { get; set; }
    }
}
