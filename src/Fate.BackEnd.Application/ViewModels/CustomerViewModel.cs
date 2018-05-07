using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fate.BackEnd.Application.ViewModels
{
    public class CustomerViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public int? OccupationId { get; set; }

        public OccupationViewModel Occupation { get; set; }
    }
}
