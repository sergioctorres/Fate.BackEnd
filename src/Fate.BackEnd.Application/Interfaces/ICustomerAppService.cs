﻿using Fate.BackEnd.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Fate.BackEnd.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        CustomerViewModel Add(CustomerViewModel customerViewModel);
        CustomerViewModel GetById(int id);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel Update(CustomerViewModel customerViewModel);
        void Delete(int id);
    }
}
