using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedihelpApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Membership { get; set; }
        public string ChosenPlan { get; set; }
    }
}