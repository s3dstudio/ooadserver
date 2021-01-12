using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ooadServer.DTO
{
    public class SINHVIEN
    {
        public int idsv { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string noisinh { get; set; }
        public string hktt { get; set; }
        public int idkhoa { get; set; }
        public string ktx { get; set; }
        public string bixoa { get; set; }
        public string lydoxoa { get; set; }
        public string anh { get; set; }
        public string username { get; set; }

        public static implicit operator SINHVIEN(List<SINHVIEN> v)
        {
            throw new NotImplementedException();
        }
    }
}
