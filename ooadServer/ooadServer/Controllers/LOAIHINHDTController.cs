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
    public class LOAIHINHDTController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public LOAIHINHDTController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<LOAIHINHDT> Get()
        {
            return _dataAccessProvider.GetLOAIHINHDTRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] LOAIHINHDT k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddLOAIHINHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public LOAIHINHDT Details(string id)
        {
            return _dataAccessProvider.GetLOAIHINHDTSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] LOAIHINHDT k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateLOAIHINHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetLOAIHINHDTSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteLOAIHINHDTRecord(id);
            return Ok();
        }
    }
}
