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
    public class DKHPDataController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public DKHPDataController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<DKHPData> Get()
        {
            return _dataAccessProvider.GetDKHP_DataRecords();
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] DKHPData k)
        {
            if (ModelState.IsValid)
            {
                List<DKHPData> dkhpdata = _dataAccessProvider.GetDKHP_DataRecords();
                if(dkhpdata.FirstOrDefault(t => t.idsv == k.idsv && t.idtkbnhomlop == k.idtkbnhomlop) == null)
                {
                    _dataAccessProvider.AddDKHP_DataRecord(k);
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public DKHPData Details(string id)
        {
            return _dataAccessProvider.GetDKHP_DataSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] DKHPData k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateDKHP_DataRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetDKHP_DataSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteDKHP_DataRecord(id);
            return Ok();
        }
    }
}
