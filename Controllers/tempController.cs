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
    public class tempController : ControllerBase
    {

        public tempController(LoanContext context)
        {
            _context = context;
        }

        public LoanContext _context { get; }



        public ActionResult Get()
        {
            var temp = _context.temp.ToList();
            return Ok(_context.temp.ToList());
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var t = _context.temp.FirstOrDefault(c => c.id == id);
            return Ok(t);
        }

        [HttpPost]
        public ActionResult Post([FromBody] tempor t)
        {
            if (t.whatever == null)
            {
                t.whatever = "Not Applied";
            }
            _context.temp.Add(t);
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = t });
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id)
        {



            return Ok();

            //var names = new List<string>();
            //var properties = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Static);
            //foreach (var item in properties)
            //{
            //    var attribute = (DisplayNameAttribute)item.GetCustomAttribute(typeof(DisplayNameAttribute), true);
            //    if (attribute != null)
            //    {
            //        names.Add(attribute.DisplayName);
            //    }
            //    else
            //    {
            //        names.Add(item.Name);
            //    }
            //}

            //var te = _context.temp.FirstOrDefault(c => c.id == id);
            //if (te == null)
            //    return BadRequest();
            //else
            //{
            //    // _context.Categories.Map(id, temp);
            //    //te.Update(t);
            //    _context.SaveChanges();
            //    return Ok(t);
            //}
        }




    }
}
