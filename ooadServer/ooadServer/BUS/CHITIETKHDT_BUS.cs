using ooadServer.DAL;
using ooadServer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.BUS
{
    public class CHITIETKHDT_BUS
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CHITIETKHDT_BUS(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        public List<CHITIETKEHOACH> GetChiTietKHDT(string id)
        {
            List<CHITIETKHDT> cHITIETKHDTs = _dataAccessProvider.GetCHITIETKHDTRecords();
            List<KHDT> KHDTs = _dataAccessProvider.GetKHDTRecords();
            List<HOCPHAN> hocphan = _dataAccessProvider.GetHOCPHANRecords();
            List<KHOAHOC> khoahoc = _dataAccessProvider.GetKHOAHOCRecords();

            var query = (from khdt in KHDTs
                         join ct in cHITIETKHDTs on khdt.idkhdt equals ct.idkhdt
                         join hp in hocphan on ct.idhocphan equals hp.idhocphan
                         join kh in khoahoc on khdt.idkhoahoc equals kh.idkhoahoc
                         where khdt.idkhdt == Int32.Parse(id)
                         select new CHITIETKEHOACH
                         {
                             idchitietkhdt = ct.idchitietkhdt,
                             idkhdt = khdt.idkhdt,
                             tenkhdt = khdt.tenkhdt,
                             idhdt = khdt.idhdt,
                             idhocphan = hp.idhocphan,
                             tenhocphan = hp.tenhocphan,
                             sotinchi = hp.sotinchi,
                             sotietlythuyet = hp.sotietlythuyet,
                             sotietthuchanh = hp.sotietthuchanh,
                             sotiettuhoc = hp.sotiettuhoc,
                             sotietthamquan = hp.sotietthamquan
                         }).ToList();

            //List<CHITIETKEHOACH> result = new List<CHITIETKEHOACH>();

            //foreach (var item in query)
            //{
            //    CHITIETKEHOACH temp = new CHITIETKEHOACH();

            //    temp.idchitietkhdt = item.idchitietkhdt;
            //    temp.idkhdt = item.idkhdt;
            //    temp.idhdt = temp.
            //}

            return query;

        }
    }
}
