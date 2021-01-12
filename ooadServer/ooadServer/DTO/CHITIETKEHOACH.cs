using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.DTO
{
    public class CHITIETKEHOACH
    {
        public int idchitietkhdt { get; set; }
        public int idkhdt { get; set; }
        public string tenkhdt { get; set; }
        public int idhdt { get; set; }
        public string idhocphan { get; set; }
        public string tenhocphan { get; set; }
        public int sotinchi { get; set; }
        public int sotietlythuyet { get; set; }
        public int sotietthuchanh { get; set; }
        public int sotiettuhoc { get; set; }
        public int sotietthamquan { get; set; }

    }
}
