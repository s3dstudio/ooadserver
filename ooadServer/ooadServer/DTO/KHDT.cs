using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.DTO
{
    public class KHDT
    {
        public int idkhdt { get; set; }
        public string tenkhdt { get; set; }
        public int idhdt { get; set; }
        public int idchuyennganh { get; set; }
        public int idlhdt { get; set; }
        public int idkhoahoc {get;set;}
        public bool active { get; set; }

        public static explicit operator KHDT(List<KHDT> v)
        {
            throw new NotImplementedException();
        }
    }
}
