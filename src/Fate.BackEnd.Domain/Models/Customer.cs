using System;

namespace Fate.BackEnd.Domain.Models
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }

        public int? OccupationId { get; set; }
        public Occupation Occupation { get; set; }

        protected Customer() { }
    }
}
