using Fate.BackEnd.Application.Interfaces;
using Fate.BackEnd.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Fate.BackEnd.Services.REST.Controllers
{
    public class OccupationsController : ApiController
    {
        private readonly IOccupationAppService _occupationAppService;

        public OccupationsController(IOccupationAppService occupationAppService)
        {
            _occupationAppService = occupationAppService;
        }

        [HttpGet]
        public IEnumerable<OccupationViewModel> GetAll()
        {
            return _occupationAppService.GetAll();
        }

        [HttpGet]
        public OccupationViewModel GetById(int id)
        {
            return _occupationAppService.GetById(id);
        }

        // POST: api/Customers
        public void Post([FromBody]OccupationViewModel occupationViewModel)
        {
            _occupationAppService.Add(occupationViewModel);
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]OccupationViewModel occupationViewModel)
        {
            _occupationAppService.Update(occupationViewModel);
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
            _occupationAppService.Delete(id);
        }
    }
}
