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
    public class TKBController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public TKBController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet("get/{id}")]
        public IEnumerable<TKBDATA> Get(string id)
        {
            List<SINHVIEN> sv = _dataAccessProvider.GetSINHVIENRecords();
            List<TKBSV> tkbsinhvien = _dataAccessProvider.GetTKBSVRecords();
            List<TKBNHOMLOP> tkbnhomllop = _dataAccessProvider.GetTKBNHOMLOPRecords();
            List<NHOMLOP> nhomlop = _dataAccessProvider.GetNHOMLOPRecords();
            var query = (from s in sv
                         join tkbsv in tkbsinhvien on s.idsv equals tkbsv.idsv
                         join tkbnl in tkbnhomllop on tkbsv.idtkbnhomlop equals tkbnl.idtkbnhomlop
                         join nl in nhomlop on tkbnl.idnhomlop equals nl.idnhomlop
                         where s.idsv.ToString() == id
                         select new
                         {
                             nl.idnhomlop,
                             nl.ten,
                             nl.thoigianmo,
                             tkbnl.thu,
                             tkbnl.tietbatdau,
                             tkbnl.tietketthuc
                         }).ToList();

            List<TKBDATA> result = new List<TKBDATA>();

            foreach(var item in query)
            {
                TKBDATA tkbdata = new TKBDATA();
                tkbdata.idnhomlop = item.idnhomlop;
                tkbdata.tennhomlop = item.ten;
                tkbdata.thoigianmo = item.thoigianmo;
                tkbdata.thu = item.thu;
                tkbdata.tietbatdau = item.tietbatdau;
                tkbdata.tietketthuc = item.tietketthuc;
                result.Add(tkbdata);
            }

            return result;
        }
    }
}
