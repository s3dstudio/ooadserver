using ooadServer.DAL;
using ooadServer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.BUS
{
    public class DKHP_BUS
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public DKHP_BUS(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        public List<DKHP> GetThongTinDKHP()
        {
            List<HOCPHAN> hocphan = _dataAccessProvider.GetHOCPHANRecords();
            List<NHOMLOP> nhomlop = _dataAccessProvider.GetNHOMLOPRecords();
            List<TKBNHOMLOP> tkbnhomlop = _dataAccessProvider.GetTKBNHOMLOPRecords();
            List<KHOA> khoa = _dataAccessProvider.GetKHOARecords();
            List<GIANGVIEN> giangvien = _dataAccessProvider.GetGIANGVIENRecords();

            var query = ( from nl in nhomlop
                          join hp in hocphan on nl.idhocphan equals hp.idhocphan
                          join tkbnl in tkbnhomlop on nl.idnhomlop equals  tkbnl.idnhomlop
                          join k in khoa on hp.idkhoa equals k.idkhoa
                          join gv in giangvien on tkbnl.idgiangvien equals gv.idgiangvien
                          select new DKHP
                          {
                              idnhomlop = nl.idnhomlop,
                              tenhocphan = hp.tenhocphan,
                              khoaquanly = k.tenkhoa,
                              sotinchi = hp.sotinchi,
                              giangvien = gv.tengv,
                              thu = tkbnl.thu,
                              tietbatdau = tkbnl.tietbatdau,
                              tietketthuc = tkbnl.tietketthuc
                          }
                ).ToList();

            return query;
        }
    }
}
