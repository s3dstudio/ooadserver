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
    public class TKBSVController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public TKBSVController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<TKBSV> Get()
        {
            return _dataAccessProvider.GetTKBSVRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] TKBSV k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddTKBSVRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public TKBSV Details(string id)
        {
            return _dataAccessProvider.GetTKBSVSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] TKBSV k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateTKBSVRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetTKBSVSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteTKBSVRecord(id);
            return Ok();
        }
    }
}
