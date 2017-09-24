using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ResourceBox.WebApi.Controllers
{
    [RoutePrefix("api/entrada")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EntradaController : ApiController
    {
        private readonly IEntradaAppService entradaAppService;

        public EntradaController(IEntradaAppService entradaAppService)
        {
            this.entradaAppService = entradaAppService;
        }

        public IEnumerable<EntradaViewModel> Get()
        {
            return entradaAppService.GetAll();
        }

        public EntradaViewModel Get(long id)
        {
            return entradaAppService.GetById(id);
        }

        public void Post(EntradaViewModel value)
        {
            if (ModelState.IsValid)
                entradaAppService.Add(value);
        }

        public void Put(long id, [FromBody]EntradaViewModel value)
        {
            if (ModelState.IsValid)
                entradaAppService.Update(value);
        }

        public void Delete(long id)
        {
            entradaAppService.Remove(id);
        }
    }
}
