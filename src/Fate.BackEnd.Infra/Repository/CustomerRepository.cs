using Fate.BackEnd.Domain.Interfaces;
using Fate.BackEnd.Domain.Models;
using System;

namespace Fate.BackEnd.Infra.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public override Customer Add(Customer obj)
        {
            obj.Age = CalculateAge(obj.Birthday);
            return base.Add(obj);
        }

        public override Customer Update(Customer obj)
        {
            obj.Age = CalculateAge(obj.Birthday);
            return base.Update(obj);
        }

        public int CalculateAge(DateTime birthday)
        {
            var now = DateTime.Now;
            var age = now.Year - birthday.Year;

            if (birthday > now.AddYears(-age))
                age--;

            return age;
        }
    }
}
