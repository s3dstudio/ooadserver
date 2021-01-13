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
    public class KETQUAHOCTAPController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KETQUAHOCTAPController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get")]
        public IEnumerable<KETQUAHOCTAP> Get()
        {
            return _dataAccessProvider.GetKETQUAHOCTAPRecords();
        }

        [HttpGet("getbyusername/{username}")]
        public IEnumerable<CHITIETKQHT> GetBuUsername(string username)
        {

            List<SINHVIEN> sinhvien = _dataAccessProvider.GetSINHVIENRecords();
            List<KETQUAHOCTAP> ketquahoctap = _dataAccessProvider.GetKETQUAHOCTAPRecords();
            List<HOCPHAN> hocphan = _dataAccessProvider.GetHOCPHANRecords();

            var query = (from kqht in ketquahoctap
                         join sv in sinhvien on kqht.idsv equals sv.idsv
                         join hp in hocphan on kqht.idhocphan equals hp.idhocphan
                         where sv.username == username
                         select new CHITIETKQHT
                         {
                             idketquahoctap = kqht.idketquahoctap,
                             idsv = kqht.idsv,
                             idnhomlop = kqht.idnhomlop,
                             tenhocphan = hp.tenhocphan,
                             idhocphan = kqht.idhocphan,
                             quatrinh = kqht.quatrinh,
                             thuchanh = kqht.thuchanh,
                             thi = kqht.thi,
                             ketqua = kqht.ketqua,
                             sotinchi = hp.sotinchi
                         }
                ).ToList();

            return query;
        }

        [HttpPost("post")]
        public IActionResult Create([FromBody] KETQUAHOCTAP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddKETQUAHOCTAPRecord(k);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getid/{id}")]
        public KETQUAHOCTAP Details(string id)
        {
            return _dataAccessProvider.GetKETQUAHOCTAPSingleRecord(id);
        }

        [HttpPut("edit")]
        public IActionResult Edit([FromBody] KETQUAHOCTAP k)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateKETQUAHOCTAPRecord(k);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            var data = _dataAccessProvider.GetKETQUAHOCTAPSingleRecord(id);
            Console.WriteLine(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteKETQUAHOCTAPRecord(id);
            return Ok();
        }
    }
}
