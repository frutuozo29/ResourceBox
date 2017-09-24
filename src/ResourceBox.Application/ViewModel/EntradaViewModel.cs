using System;
using System.Collections.Generic;

namespace ResourceBox.Application.ViewModel
{
    public class EntradaViewModel
    {
        public EntradaViewModel()
        {
            RecursosEntrada = new List<RecursoEntradaViewModel>();
        }

        public long Id { get; set; }
        public DateTime Data { get; set; }
        public long ResponsavelId { get; set; }
        public string ResponsavelNome { get; set; }
        public virtual ICollection<RecursoEntradaViewModel> RecursosEntrada { get; set; }
    }
}
