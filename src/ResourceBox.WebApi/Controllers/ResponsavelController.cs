using ResourceBox.Application.Interfaces;
using ResourceBox.Application.ViewModel;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ResourceBox.WebApi.Controllers
{
    [RoutePrefix("api/responsavel")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ResponsavelController : ApiController
    {
        private IResponsavelAppService responsavelAppService;

        public ResponsavelController(IResponsavelAppService responsavelAppService)
        {
            this.responsavelAppService = responsavelAppService;
        }

        [HttpGet]
        public IEnumerable<ResponsavelViewModel> Get()
        {
            return responsavelAppService.GetAll();
        }

        [HttpGet]
        public ResponsavelViewModel Get(long id)
        {
            return responsavelAppService.GetById(id);
        }

        [HttpPost]
        public void Post(ResponsavelViewModel value)
        {
            if (ModelState.IsValid)
                responsavelAppService.Add(value);
        }

        [HttpPut]
        public void Put(long id, [FromBody]ResponsavelViewModel value)
        {
            if (ModelState.IsValid)
                responsavelAppService.Update(value);
        }

        [HttpDelete]
        public void Delete(long id)
        {
            responsavelAppService.Remove(id);
        }
    }
}
