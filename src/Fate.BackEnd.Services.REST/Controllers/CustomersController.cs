using Fate.BackEnd.Application.Interfaces;
using Fate.BackEnd.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Fate.BackEnd.Services.REST.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomersController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        public IEnumerable<CustomerViewModel> GetAll()
        {
            return _customerAppService.GetAll();
        }

        [HttpGet]
        public CustomerViewModel GetById(int id)
        {
            return _customerAppService.GetById(id);
        }

        // POST: api/Customers
        public void Post([FromBody]CustomerViewModel customerViewModel)
        {
            _customerAppService.Add(customerViewModel);
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]CustomerViewModel customerViewModel)
        {
            _customerAppService.Update(customerViewModel);
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
            _customerAppService.Delete(id);
        }
    }
}
