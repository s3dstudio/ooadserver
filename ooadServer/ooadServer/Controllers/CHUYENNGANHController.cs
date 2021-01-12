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
    public class CHUYENNGANHController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public CHUYENNGANHController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<CHUYENNGANH> Get()
        {
            return _dataAccessProvider.GetCHUYENNGANHRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] CHUYENNGANH k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddCHUYENNGANHRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public CHUYENNGANH Details(string id)
        {
            return _dataAccessProvider.GetCHUYENNGANHSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] CHUYENNGANH k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateCHUYENNGANHRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetCHUYENNGANHSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteCHUYENNGANHRecord(id);
            return Ok();
        }
    }
}
