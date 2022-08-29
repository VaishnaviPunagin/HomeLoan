using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Models
{
    public class DocumentsUpload
    {
        [Key]
        public int DocumentId { get; set; }

        public int CustomerId { get; set; }

        public string PanCard { get; set; }

        public string AadharCard{ get; set; }

        public string SalarySlip { get; set; }

        public string NocFromBuilder { get; set; }

        public string AgreementToSale { get; set; }
    }
}
