using System;

namespace ResourceBox.Application.ViewModel
{
    public class EntradaViewModel
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public long Responsavel_Id { get; set; }
        public virtual ResponsavelViewModel Responsavel { get; set; }
    }
}
