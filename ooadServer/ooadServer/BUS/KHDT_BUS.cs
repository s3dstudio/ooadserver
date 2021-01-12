using ooadServer.DAL;
using ooadServer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.BUS
{
    public class KHDT_BUS
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public KHDT_BUS(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        public List<KHDT> GetKHDTFromYear(int year)
        {
            List<KHOAHOC> KHOAHOC = _dataAccessProvider.GetKHOAHOCRecords();
            List<KHDT> KHDTs = _dataAccessProvider.GetKHDTRecords();

            var query = (from kh in KHOAHOC
                         join khdt in KHDTs on kh.idkhoahoc equals khdt.idkhoahoc
                         where kh.namkhoahoc == year
                         select khdt
                         ).ToList();

            return query;
        }
    }
}
