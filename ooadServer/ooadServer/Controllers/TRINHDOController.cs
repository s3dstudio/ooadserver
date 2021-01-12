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
    public class TRINHDOController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public TRINHDOController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<TRINHDO> Get()
        {
            return _dataAccessProvider.GetTRINHDORecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] TRINHDO k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddTRINHDORecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public TRINHDO Details(string id)
        {
            return _dataAccessProvider.GetTRINHDOSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] TRINHDO k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateTRINHDORecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetTRINHDOSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteTRINHDORecord(id);
            return Ok();
        }
    }
}
