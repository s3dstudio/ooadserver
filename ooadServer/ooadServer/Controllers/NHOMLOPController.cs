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
    public class NHOMLOPController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public NHOMLOPController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<NHOMLOP> Get()
        {
            return _dataAccessProvider.GetNHOMLOPRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] NHOMLOP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddNHOMLOPRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public NHOMLOP Details(string id)
        {
            return _dataAccessProvider.GetNHOMLOPSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] NHOMLOP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateNHOMLOPRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetNHOMLOPSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteNHOMLOPRecord(id);
            return Ok();
        }
    }
}
