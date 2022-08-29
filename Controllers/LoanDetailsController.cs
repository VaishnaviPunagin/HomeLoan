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
    public class LoanDetailsController : ControllerBase
    {
        public LoanDetailsController(LoanContext context)
        {
            _context = context;
        }

        public LoanContext _context { get; }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.LoanDetails.ToList());
        }

        [HttpPost]
        public ActionResult Post(LoanDetail details)
        {
            _context.LoanDetails.Add(details);
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == details.CustomerId);
            temp.LoanDetailsStatus = true;
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = details });
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.LoanDetails.FirstOrDefault(l => l.CustomerId == id);
            return Ok(temp);
        }

    }
}
