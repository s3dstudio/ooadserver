using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ooadServer.DTO;
using ooadServer.DAL;
using ooadServer.BUS;

namespace ooadServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KHDTController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public KHDTController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet("get")]
        public IEnumerable<KHDT> Get()
        {
            return _dataAccessProvider.GetKHDTRecords();
        }

        [HttpGet("getfromyear/{year}")]
        public IEnumerable<KHDT> GetFromYear(string year)
        {
            KHDT_BUS khdt_bus = new KHDT_BUS(_dataAccessProvider);
            return khdt_bus.GetKHDTFromYear(Int32.Parse(year));
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] KHDT k)
        {
            if (ModelState.IsValid)
            {
                //Guid obj = Guid.NewGuid();
                
                //k.idkhdt = int.Parse(obj.ToString());
                _dataAccessProvider.AddKHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public KHDT Details(string id)
        {
            return _dataAccessProvider.GetKHDTSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] KHDT k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateKHDTRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        //[Route("api/CuaHang/delete/{id?}")]
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetKHDTSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteKHDTRecord(id);
            return Ok();
        }
    }
}
