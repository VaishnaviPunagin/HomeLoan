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
    public class IncomeDetailController : ControllerBase
    {
        public IncomeDetailController(LoanContext context)
        {
            _context = context;
        }

        public LoanContext _context { get; }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.IncomeDetails.ToList());
        }


        [HttpPost]
        public ActionResult Post(IncomeDetail newI)
        {
            _context.IncomeDetails.Add(newI);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = newI });
        }

    }
}
