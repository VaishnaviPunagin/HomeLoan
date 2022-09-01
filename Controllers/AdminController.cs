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
    public class AdminController : ControllerBase
    {
        public AdminController(LoanContext context)
        {
           _context=context;
        }

        public LoanContext _context { get; }

        public ActionResult getAllAdmins()
        {
            return Ok(_context.Admins.ToList());
        }

        [Route("loginCheck")]
        [HttpPost]
        public ActionResult loginCheck(Admin user)
        {
            var temp = _context.Admins.FirstOrDefault(c => c.AdminId == user.AdminId && c.Password == user.Password);
            return Ok(temp);
        }

    }
}
