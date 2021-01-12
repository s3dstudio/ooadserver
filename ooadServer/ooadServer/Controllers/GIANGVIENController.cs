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
    public class GIANGVIENController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public GIANGVIENController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<GIANGVIEN> Get()
        {
            return _dataAccessProvider.GetGIANGVIENRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] GIANGVIEN gv)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddGIANGVIENRecord(gv);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public GIANGVIEN Details(string id)
        {
            return _dataAccessProvider.GetGIANGVIENSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] GIANGVIEN gv)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateGIANGVIENRecord(gv);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetGIANGVIENSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteGIANGVIENRecord(id);
            return Ok();
        }
    }
}
