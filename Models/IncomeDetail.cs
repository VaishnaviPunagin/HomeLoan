using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Models
{
    public class IncomeDetail
    {
        [Key]
        public int IncomeDetailsId { get; set; }

        public int CustomerId { get; set; }

        public string PropertyName { get; set; }

        public string PropertyLocation { get; set; }

        public string PinCode { get; set; }

        public decimal EstimatedAmount { get; set; }

        public string TypeOfEmployment { get; set; }

        public int RetirementAge { get; set; }

        public string OrganizationName { get; set; }

        public string EmployerName { get; set; }

    }
}
