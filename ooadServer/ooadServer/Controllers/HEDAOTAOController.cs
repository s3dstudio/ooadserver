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
    public class HEDAOTAOController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public HEDAOTAOController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<HEDAOTAO> Get()
        {
            return _dataAccessProvider.GetHEDAOTAORecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] HEDAOTAO k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddHEDAOTAORecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public HEDAOTAO Details(string id)
        {
            return _dataAccessProvider.GetHEDAOTAOSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] HEDAOTAO k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateHEDAOTAORecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetHEDAOTAOSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteHEDAOTAORecord(id);
            return Ok();
        }
    }
}
