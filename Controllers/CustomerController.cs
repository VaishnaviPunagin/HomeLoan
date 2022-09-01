using HomeLoan.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeLoan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController(LoanContext context)
        {
            _context = context;
        }

        public LoanContext _context { get; }


        //gets a list of all customers 
        public ActionResult Get()
        {
            var temp = _context.Customers.ToList();
            return Ok(_context.Customers.ToList());
        }

        //returns one customer's data based on given id
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            return Ok(temp);
        }

        //creates and adds new customer data
        [HttpPost]
        public ActionResult Post(Customer newC)
        {
            if (newC.ApplicationStatus == null || newC.CustomerAccountStatus == null)
            {
                newC.ApplicationStatus = "Not Applied";
                newC.CustomerAccountStatus = true;
            }
            _context.Customers.Add(newC);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = newC });
        }


        //updates data fields from edit profile 
        [HttpPut("{id}")]
        public ActionResult Put(int id, Customer modifiedC)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (temp == null)
                return BadRequest();
            else
            {
                temp.FirstName = modifiedC.FirstName;
                temp.MiddleName = modifiedC.MiddleName;
                temp.LastName = modifiedC.LastName;
                //temp.Password = modifiedC.Password;
                temp.PhoneNumber = modifiedC.PhoneNumber;
                _context.SaveChanges();
                return Ok(temp);
            }
        }

        ////
        //[Route("incomeUpdate/{id}")]
        //[HttpPut]
        //public ActionResult Put(int id)
        //{
        //    var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        //    if (temp == null)
        //        return BadRequest();
        //    else
        //        temp.IncomeDetailsStatus = true;
        //    return Ok(temp);
        //}
           


        //login Check for customers! 
        //returns an object, user data if valid, an empty object if invalid credentials.
        [Route("loginCheck")]
        [HttpPost]
        public ActionResult LoginCheck(UserLogin details)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.EmailId == details.EmailId && c.Password == details.Password);
            return Ok(temp);
        }

        //get a list of customers with ApplicationStatus="Submitted for Approval"
        [Route("submittedForVerification")]
        [HttpGet]
        public ActionResult GetSubmittedForVerification()
        {
            var temp = _context.Customers.Where(c => c.ApplicationStatus == "Submitted for Verification");
            return Ok(temp);

        }

        //get a list of customers with ApplicationStatus="Approved"
        [Route("approved")]
        [HttpGet]
        public ActionResult GetApproved()
        {
            var temp = _context.Customers.Where(c => c.ApplicationStatus == "Approved");
            return Ok(temp);

        }

        //get a list of customers with ApplicationStatus="Approved"
        [Route("rejected")]
        [HttpGet]
        public ActionResult GetRejected()
        {
            var temp = _context.Customers.Where(c => c.ApplicationStatus == "Rejected");
            return Ok(temp);

        }
    }
}
