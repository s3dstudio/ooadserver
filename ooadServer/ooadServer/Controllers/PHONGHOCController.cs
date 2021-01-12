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
    public class PHONGHOCController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public PHONGHOCController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<PHONGHOC> Get()
        {
            return _dataAccessProvider.GetPHONGHOCRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] PHONGHOC k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddPHONGHOCRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public PHONGHOC Details(string id)
        {
            return _dataAccessProvider.GetPHONGHOCSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] PHONGHOC k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdatePHONGHOCRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetPHONGHOCSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeletePHONGHOCRecord(id);
            return Ok();
        }
    }
}
