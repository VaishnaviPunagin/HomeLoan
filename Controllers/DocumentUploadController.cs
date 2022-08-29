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
    public class DocumentUploadController : ControllerBase
    {

        public DocumentUploadController(LoanContext context)
        {
            _context = context;
        }

        public LoanContext _context { get; }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.DocumentsUploaded.ToList());
        }


        [HttpPost]
        public ActionResult Post(DocumentsUpload docs)
        {
            _context.DocumentsUploaded.Add(docs);
            var temp = _context.Customers.FirstOrDefault(c => c.CustomerId == docs.CustomerId);
            temp.DocumentUploadStatus = true;
            _context.SaveChanges();
            return CreatedAtAction("Get", new { id = docs });
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.DocumentsUploaded.FirstOrDefault(d => d.CustomerId == id);
            return Ok(temp);
        }


    }
}
