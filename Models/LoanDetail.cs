using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Models
{
    public class LoanDetail
    {
        [Key]
        public int LoanId { get; set; }

        //[Precision(18,2)]?
        public int CustomerId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoanAmount{ get; set; }

        public int Tenure { get; set; }

        public string BankName { get; set; }

        public string IfscCode { get; set; }

        public string CifNumber { get; set; }

        public string AccountNumber { get; set; }
    }
}
