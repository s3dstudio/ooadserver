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
    public class CHUCNANGController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public CHUCNANGController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<CHUCNANG> Get()
        {
            return _dataAccessProvider.GetCHUCNANGRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] CHUCNANG k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddCHUCNANGRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public CHUCNANG Details(string id)
        {
            return _dataAccessProvider.GetCHUCNANGSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] CHUCNANG k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateCHUCNANGRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetCHUCNANGSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteCHUCNANGRecord(id);
            return Ok();
        }
    }
}
