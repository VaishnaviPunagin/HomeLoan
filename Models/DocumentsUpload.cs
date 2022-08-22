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

        public bool PanStatus { get; set; }

        public bool AadharStatus { get; set; }

        public bool SalarySlipStatus { get; set; }

        public bool NocFromBuilderStatus { get; set; }

        public bool AgreementToSaleStatus { get; set; }
    }
}
