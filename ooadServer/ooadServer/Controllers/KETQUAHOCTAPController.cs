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
    public class KETQUAHOCTAPController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KETQUAHOCTAPController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<KETQUAHOCTAP> Get()
        {
            return _dataAccessProvider.GetKETQUAHOCTAPRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] KETQUAHOCTAP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddKETQUAHOCTAPRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public KETQUAHOCTAP Details(string id)
        {
            return _dataAccessProvider.GetKETQUAHOCTAPSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] KETQUAHOCTAP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateKETQUAHOCTAPRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetKETQUAHOCTAPSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteKETQUAHOCTAPRecord(id);
            return Ok();
        }
    }
}
