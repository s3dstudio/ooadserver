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
    public class KHOAHOCController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KHOAHOCController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<KHOAHOC> Get()
        {
            return _dataAccessProvider.GetKHOAHOCRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] KHOAHOC k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddKHOAHOCRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public KHOAHOC Details(string id)
        {
            return _dataAccessProvider.GetKHOAHOCSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] KHOAHOC k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateKHOAHOCRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetKHOAHOCSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteKHOAHOCRecord(id);
            return Ok();
        }
    }
}
