using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ooadServer.DTO;
using ooadServer.DAL;
using System.Threading.Tasks;
using ooadServer.BUS;

namespace ooadServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ROLEController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public ROLEController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<ROLE> Get()
        {
            return _dataAccessProvider.GetROLERecords();
        }
        [HttpGet("getct/{id}")]

        [HttpPost("post")]
        public IActionResult Create([FromBody] ROLE k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddROLERecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public ROLE Details(string id)
        {
            return _dataAccessProvider.GetROLESingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] ROLE k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateROLERecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetROLESingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteROLERecord(id);
            return Ok();
        }
    }
}
