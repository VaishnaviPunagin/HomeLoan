using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Models
{
    public class Customer
    {
		[Key]
        public int CustomerId { get; set; }

		//[Required(ErrorMessage ="Please enter FirstName")]
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		//[Required(ErrorMessage ="Please enter an Email Id")]
		//[DataType(DataType.EmailAddress, ErrorMessage ="Please enter a valid Email Id")]
		public string EmailId { get; set; }

		//[Required(ErrorMessage ="Please enter a password")]
		public string Password { get; set; }

		//[Required(ErrorMessage ="Please enter Phone Number")]
		//[DataType(DataType.PhoneNumber, ErrorMessage ="Please enter a valid phone number")]
		public string PhoneNumber { get; set; }

		//[Required(ErrorMessage = "Please enter date of birth")]
		[DataType(DataType.Date, ErrorMessage = "Please enter a valid date")]
		//add validation here for DoB to be before now -- Custom Validations
		public DateTime DateOfBirth { get; set; }

		public int Age { get; set; }

		//[Required(ErrorMessage = "Please enter your Nationality")]
		public string Nationality { get; set; }

		//[Required(ErrorMessage = "Please enter your Aadhar Number")]
		//add validation to check input to be 12 digits only.
		public string AadharNumber { get; set; }

		//[Required(ErrorMessage = "Please enter your PAN ")]
		//add validation to check input to be 10 digits only + letters and digits thing
		public string PanNumber { get; set; }

		public bool CustomerAccountStatus { get; set; }
		public bool IncomeDetailsStatus { get; set; }
		public bool DocumentUploadStatus { get; set; }
		public bool LoanDetailsStatus { get; set; }

		public string ApplicationStatus { get; set; }

	}
}
