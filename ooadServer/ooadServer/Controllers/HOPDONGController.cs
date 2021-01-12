using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ooadServer.DTO;
using ooadServer.DAL;
using System.Threading.Tasks;

namespace ooadServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HOPDONGController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public HOPDONGController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<HOPDONG> Get()
        {
            return _dataAccessProvider.GetHOPDONGRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] HOPDONG k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddHOPDONGRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public HOPDONG Details(string id)
        {
            return _dataAccessProvider.GetHOPDONGSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] HOPDONG k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateHOPDONGRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetHOPDONGSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteHOPDONGRecord(id);
            return Ok();
        }
    }
}
