﻿using HomeLoan.Models;
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
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == newI.CustomerId);
            temp.IncomeDetailsStatus = true;
            _context.SaveChanges();
            return Ok(temp);
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.IncomeDetails.FirstOrDefault(c => c.CustomerId == id);
            return Ok(temp);
        }
    }
}
