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
        public int ApplicationNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        //[Precision(18,2)]?
        public int AccountNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public int CustomerId { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal MaxLoanGrantable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal InterestRate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tenure { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoanAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
    }
}
