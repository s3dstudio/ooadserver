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
    public class HOCPHANController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public HOCPHANController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<HOCPHAN> Get()
        {
            return _dataAccessProvider.GetHOCPHANRecords();
        }
        [HttpGet("dkhp/get")]
        public IEnumerable<DKHP> GetDKHP()
        {
            DKHP_BUS dKHP_BUS = new DKHP_BUS(_dataAccessProvider);

            return dKHP_BUS.GetThongTinDKHP();
        }
        [HttpGet("dkhp/getdata/{idsv}")]
        public IEnumerable<DKHP> GetDKHPData(string idsv)
        {
            DKHP_BUS dKHP_BUS = new DKHP_BUS(_dataAccessProvider);

            return dKHP_BUS.GetDKHP(idsv);
        }
        [HttpPost("post")]
        public IActionResult Create([FromBody] HOCPHAN k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddHOCPHANRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public HOCPHAN Details(string id)
        {
            return _dataAccessProvider.GetHOCPHANSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] HOCPHAN k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateHOCPHANRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetHOCPHANSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteHOCPHANRecord(id);
            return Ok();
        }
    }
}
