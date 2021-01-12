using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ooadServer.DTO;
using ooadServer.DAL;
using System.Threading.Tasks;
using ooadServer.BUS;
namespace ooadServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class USERController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public USERController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<USER> Get()
        {
            return _dataAccessProvider.GetUSERRecords();
        }
        [HttpPost("post")]
        public IActionResult Create([FromBody] USER k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddUSERRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getbyusername/{username}")]
        public USER Details(string username)
        {
            return _dataAccessProvider.GetUSERSingleRecord(username);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] USER k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateUSERRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetUSERSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteUSERRecord(id);
            return Ok();
        }
    }
}
