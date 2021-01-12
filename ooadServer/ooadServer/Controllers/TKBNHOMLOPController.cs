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
    public class TKBNHOMLOPController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public TKBNHOMLOPController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<TKBNHOMLOP> Get()
        {
            return _dataAccessProvider.GetTKBNHOMLOPRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] TKBNHOMLOP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddTKBNHOMLOPRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public TKBNHOMLOP Details(string id)
        {
            return _dataAccessProvider.GetTKBNHOMLOPSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] TKBNHOMLOP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateTKBNHOMLOPRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetTKBNHOMLOPSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteTKBNHOMLOPRecord(id);
            return Ok();
        }
    }
}
