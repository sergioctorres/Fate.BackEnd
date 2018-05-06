using AutoMapper;
using Fate.BackEnd.Application.Interfaces;
using Fate.BackEnd.Application.ViewModels;
using Fate.BackEnd.Domain.Interfaces;
using Fate.BackEnd.Domain.Models;
using System.Collections.Generic;

namespace Fate.BackEnd.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerViewModel Add(CustomerViewModel customerViewModel)
        {
            var customer = Mapper.Map<Customer>(customerViewModel);

            var customerRet = _customerRepository.Add(customer);

            return customerViewModel;
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public void Dispose()
        {
            _customerRepository.Dispose();
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<CustomerViewModel>>(_customerRepository.GetAll());
        }

        public CustomerViewModel GetById(int id)
        {
            return Mapper.Map<CustomerViewModel>(_customerRepository.GetById(id));
        }

        public CustomerViewModel Update(CustomerViewModel customerViewModel)
        {
            var customer = Mapper.Map<Customer>(customerViewModel);

            _customerRepository.Update(customer);

            return customerViewModel;
        }
    }
}
