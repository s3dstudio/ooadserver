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
    public class KHOAController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KHOAController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<KHOA> Get()
        {
            return _dataAccessProvider.GetKHOARecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] KHOA k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddKHOARecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public KHOA Details(string id)
        {
            return _dataAccessProvider.GetKHOASingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] KHOA k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateKHOARecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetKHOASingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteKHOARecord(id);
            return Ok();
        }
    }
}
