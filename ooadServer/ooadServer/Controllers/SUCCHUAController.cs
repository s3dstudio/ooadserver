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
    public class SUCCHUAController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public SUCCHUAController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<SUCCHUA> Get()
        {
            return _dataAccessProvider.GetSUCCHUARecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] SUCCHUA k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddSUCCHUARecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public SUCCHUA Details(string id)
        {
            return _dataAccessProvider.GetSUCCHUASingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] SUCCHUA k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateSUCCHUARecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetSUCCHUASingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteSUCCHUARecord(id);
            return Ok();
        }
    }
}
