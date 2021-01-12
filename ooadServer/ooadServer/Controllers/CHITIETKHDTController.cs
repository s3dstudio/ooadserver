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
    public class CHITIETKHDTController : Controller
    {

        private readonly IDataAccessProvider _dataAccessProvider;
        public CHITIETKHDTController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<CHITIETKHDT> Get()
        {
            return _dataAccessProvider.GetCHITIETKHDTRecords();
        }
        [HttpGet("getct/{id}")]
        public IEnumerable<CHITIETKEHOACH> GetChiTietKH(string id)
        {
            CHITIETKHDT_BUS ct = new CHITIETKHDT_BUS(_dataAccessProvider);

            return ct.GetChiTietKHDT(id);
        }
        [HttpPost("post")]
        public IActionResult Create([FromBody] CHITIETKHDT k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddCHITIETKHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public CHITIETKHDT Details(string id)
        {
            return _dataAccessProvider.GetCHITIETKHDTSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] CHITIETKHDT k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateCHITIETKHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetCHITIETKHDTSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteCHITIETKHDTRecord(id);
            return Ok();
        }
    }
}
