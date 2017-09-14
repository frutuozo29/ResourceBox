using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using System.Collections.Generic;
using System.Web.Http;

namespace ResourceBox.WebApi.Controllers
{
    [RoutePrefix("api/recurso")]
    public class RecursoController : ApiController
    {
        private readonly IRecursoAppService recursoAppService;

        public RecursoController(IRecursoAppService recursoAppService)            
        {
            this.recursoAppService = recursoAppService;
        }
        
        [HttpGet]
        public IEnumerable<RecursoViewModel> Get()
        {
            return recursoAppService.GetAll();
        }

        [HttpGet]
        public RecursoViewModel Get(long id)
        {
            return recursoAppService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]RecursoViewModel value)
        {
            if (ModelState.IsValid)
            {
                recursoAppService.Add(value);
            }
        }

        [HttpPut]
        public void Put(long id, [FromBody]RecursoViewModel value)
        {
            if (ModelState.IsValid)
            {
                recursoAppService.Update(value);
            }
        }

        public void Delete(long id)
        {            
            recursoAppService.Remove(id);
        }
    }
}
