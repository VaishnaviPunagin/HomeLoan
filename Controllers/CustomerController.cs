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



        public ActionResult Get()
        {
            var temp = _context.Customers.ToList();
            return Ok(_context.Customers.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            return Ok(temp);
        }

        [HttpPost]
        public ActionResult Post(Customer newC)
        {
            if (newC.ApplicationStatus == null)
            {
                newC.ApplicationStatus = "Not Applied";
            }
            _context.Customers.Add(newC);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = newC });
        }

        //HOW
        [HttpPut("{id}")]
        public ActionResult Put(int id, Customer modifiedC)
        {
            return Ok();
            //How?
            //var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            //if (temp == null)
            //    return BadRequest();
            //else
            //{
            //    // _context.Categories.Map(id, temp);
            //    //temp = modifiedC;
            //    _context.SaveChanges(); 
            //    return Ok(temp);
            //}
        }
    }
}
