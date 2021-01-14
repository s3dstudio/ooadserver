using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        // KHDT
        public void AddKHDTRecord(KHDT k)
        {
            _context.khdt.Add(k);
            _context.SaveChanges();
        }

        public void UpdateKHDTRecord(KHDT k)
        {
            _context.khdt.Update(k);
            _context.SaveChanges();
        }

        public void DeleteKHDTRecord(string id)
        {
            Console.WriteLine(id);
            var entity = _context.khdt.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
            _context.khdt.Remove(entity);
            _context.SaveChanges();
            Console.WriteLine(id);
        }

        public KHDT GetKHDTSingleRecord(string id)
        {
            return _context.khdt.FirstOrDefault(t => Convert.ToString(t.idkhdt) == id);
        }

        public List<KHDT> GetKHDTRecords()
        {
            return _context.khdt.ToList();
        }

        // KHOA
        public List<KHOA> GetKHOARecords()
        {
            return _context.khoa.ToList();
        }

        public void AddKHOARecord(KHOA khoa)
        {
            _context.khoa.Add(khoa);
            _context.SaveChanges();
        }

        public void UpdateKHOARecord(KHOA khoa)
        {
            _context.khoa.Update(khoa);
            _context.SaveChanges();
        }

        public void DeleteKHOARecord(string id)
        {
            Console.WriteLine(id);
            var entity = _context.khoa.FirstOrDefault(t => Convert.ToString(t.idkhoa) == id);
            _context.khoa.Remove(entity);
            _context.SaveChanges();
            Console.WriteLine(id);
        }

        public KHOA GetKHOASingleRecord(string id)
        {
            return _context.khoa.FirstOrDefault(t => Convert.ToString(t.idkhoa) == id);
        }

        // CHUYEN NGANH
        public void AddCHUYENNGANHRecord(CHUYENNGANH cn)
        {
            _context.chuyennganh.Add(cn);
            _context.SaveChanges();
        }
        public void UpdateCHUYENNGANHRecord(CHUYENNGANH cn)
        {
            _context.chuyennganh.Update(cn);
            _context.SaveChanges();
        }
        public void DeleteCHUYENNGANHRecord(string id)
        {
            var entity = _context.chuyennganh.FirstOrDefault(t => Convert.ToString(t.idchuyennganh) == id);
            _context.chuyennganh.Remove(entity);
            _context.SaveChanges();
        }
        public CHUYENNGANH GetCHUYENNGANHSingleRecord(string id)
        {
            return _context.chuyennganh.FirstOrDefault(t => Convert.ToString(t.idchuyennganh) == id);
        }
        public List<CHUYENNGANH> GetCHUYENNGANHRecords()
        {
            return _context.chuyennganh.ToList();
        }

        // GIANG VIEN
        public void AddGIANGVIENRecord(GIANGVIEN GV)
        {
            _context.giangvien.Add(GV);
            _context.SaveChanges();
        }
        public void UpdateGIANGVIENRecord(GIANGVIEN GV)
        {
            _context.giangvien.Update(GV);
            _context.SaveChanges();
        }
        public void DeleteGIANGVIENRecord(string id)
        {
            var entity = _context.giangvien.FirstOrDefault(t => Convert.ToString(t.idgiangvien) == id);
            _context.giangvien.Remove(entity);
            _context.SaveChanges();
        }
        public GIANGVIEN GetGIANGVIENSingleRecord(string id)
        {
            return _context.giangvien.FirstOrDefault(t => Convert.ToString(t.idgiangvien) == id);
        }
        public List<GIANGVIEN> GetGIANGVIENRecords()
        {
            return _context.giangvien.ToList();
        }

        // CHUC NANG
        public void AddCHUCNANGRecord(CHUCNANG cn)
        {
            _context.chucnang.Add(cn);
            _context.SaveChanges();
        }

        public void UpdateCHUCNANGRecord(CHUCNANG cn)
        {
            _context.chucnang.Update(cn);
            _context.SaveChanges();
        }

        public void DeleteCHUCNANGRecord(string id)
        {
            var entity = _context.chucnang.FirstOrDefault(t => Convert.ToString(t.idchucnang) == id);
            _context.chucnang.Remove(entity);
            _context.SaveChanges();
        }

        public CHUCNANG GetCHUCNANGSingleRecord(string id)
        {
            return _context.chucnang.FirstOrDefault(t => Convert.ToString(t.idchucnang) == id);
        }

        public List<CHUCNANG> GetCHUCNANGRecords()
        {
            return _context.chucnang.ToList();
        }

        //HE DAO TAO
        public void AddHEDAOTAORecord(HEDAOTAO hdt)
        {
            _context.hedaotao.Add(hdt);
            _context.SaveChanges();
        }

        public void UpdateHEDAOTAORecord(HEDAOTAO hdt)
        {
            _context.hedaotao.Update(hdt);
            _context.SaveChanges();
        }

        public void DeleteHEDAOTAORecord(string id)
        {
            var entity = _context.hedaotao.FirstOrDefault(t => Convert.ToString(t.idhedaotao) == id);
            _context.hedaotao.Remove(entity);
            _context.SaveChanges();
        }

        public HEDAOTAO GetHEDAOTAOSingleRecord(string id)
        {
            return _context.hedaotao.FirstOrDefault(t => Convert.ToString(t.idhedaotao) == id);
        }

        public List<HEDAOTAO> GetHEDAOTAORecords()
        {
            return _context.hedaotao.ToList();
        }

        // HOC PHAN
        public void AddHOCPHANRecord(HOCPHAN hp)
        {
            _context.hocphan.Add(hp);
            _context.SaveChanges();
        }

        public void UpdateHOCPHANRecord(HOCPHAN hp)
        {
            _context.hocphan.Update(hp);
            _context.SaveChanges();
        }

        public void DeleteHOCPHANRecord(string id)
        {
            var entity = _context.hocphan.FirstOrDefault(t => Convert.ToString(t.idhocphan) == id);
            _context.hocphan.Remove(entity);
            _context.SaveChanges();
        }

        public HOCPHAN GetHOCPHANSingleRecord(string id)
        {
            return _context.hocphan.FirstOrDefault(t => Convert.ToString(t.idhocphan) == id);
        }

        public List<HOCPHAN> GetHOCPHANRecords()
        {
            return _context.hocphan.ToList();
        }
        
        // HOP DONG
        public void AddHOPDONGRecord(HOPDONG hd)
        {
            _context.hopdong.Add(hd);
            _context.SaveChanges();
        }

        public void UpdateHOPDONGRecord(HOPDONG hd)
        {
            _context.hopdong.Update(hd);
            _context.SaveChanges();
        }

        public void DeleteHOPDONGRecord(string id)
        {
            var entity = _context.hopdong.FirstOrDefault(t => Convert.ToString(t.idhopdong) == id);
            _context.hopdong.Remove(entity);
            _context.SaveChanges();
        }

        public HOPDONG GetHOPDONGSingleRecord(string id)
        {
            return _context.hopdong.FirstOrDefault(t => Convert.ToString(t.idhopdong) == id);
        }

        public List<HOPDONG> GetHOPDONGRecords()
        {
            return _context.hopdong.ToList();
        }

        // LOAI HINH DAO TAO
        public void AddLOAIHINHDTRecord(LOAIHINHDT lhdt)
        {
            _context.loaihinhdt.Add(lhdt);
            _context.SaveChanges();
        }

        public void UpdateLOAIHINHDTRecord(LOAIHINHDT lhdt)
        {
            _context.loaihinhdt.Update(lhdt);
            _context.SaveChanges();
        }

        public void DeleteLOAIHINHDTRecord(string id)
        {
            var entity = _context.loaihinhdt.FirstOrDefault(t => Convert.ToString(t.idlhdt) == id);
            _context.loaihinhdt.Remove(entity);
            _context.SaveChanges();
        }

        public LOAIHINHDT GetLOAIHINHDTSingleRecord(string id)
        {
            return _context.loaihinhdt.FirstOrDefault(t => Convert.ToString(t.idlhdt) == id);
        }

        public List<LOAIHINHDT> GetLOAIHINHDTRecords()
        {
            return _context.loaihinhdt.ToList();
        }

        // NHOM LOP
        public void AddNHOMLOPRecord(NHOMLOP nl)
        {
            _context.nhomlop.Add(nl);
            _context.SaveChanges();
        }

        public void UpdateNHOMLOPRecord(NHOMLOP nl)
        {
            _context.nhomlop.Update(nl);
            _context.SaveChanges();
        }

        public void DeleteNHOMLOPRecord(string id)
        {
            var entity = _context.nhomlop.FirstOrDefault(t => Convert.ToString(t.idnhomlop) == id);
            _context.nhomlop.Remove(entity);
            _context.SaveChanges();
        }

        public NHOMLOP GetNHOMLOPSingleRecord(string id)
        {
            return _context.nhomlop.FirstOrDefault(t => Convert.ToString(t.idnhomlop) == id);
        }

        public List<NHOMLOP> GetNHOMLOPRecords()
        {
            return _context.nhomlop.ToList();
        }

        // PHONG HOC
        public void AddPHONGHOCRecord(PHONGHOC ph)
        {
            _context.phonghoc.Add(ph);
            _context.SaveChanges();
        }

        public void UpdatePHONGHOCRecord(PHONGHOC ph)
        {
            _context.phonghoc.Update(ph);
            _context.SaveChanges();
        }

        public void DeletePHONGHOCRecord(string id)
        {
            var entity = _context.phonghoc.FirstOrDefault(t => Convert.ToString(t.idphonghoc) == id);
            _context.phonghoc.Remove(entity);
            _context.SaveChanges();
        }

        public PHONGHOC GetPHONGHOCSingleRecord(string id)
        {
            return _context.phonghoc.FirstOrDefault(t => Convert.ToString(t.idphonghoc) == id);
        }

        public List<PHONGHOC> GetPHONGHOCRecords()
        {
            return _context.phonghoc.ToList();
        }

        // SINH VIEN
        public void AddSINHVIENRecord(SINHVIEN sv)
        {
            _context.sinhvien.Add(sv);
            _context.SaveChanges();
        }

        public void UpdateSINHVIENRecord(SINHVIEN sv)
        {
            _context.sinhvien.Update(sv);
            _context.SaveChanges();
        }

        public void DeleteSINHVIENRecord(string id)
        {
            var entity = _context.sinhvien.FirstOrDefault(t => Convert.ToString(t.idsv) == id);
            _context.sinhvien.Remove(entity);
            _context.SaveChanges();
        }

        public SINHVIEN GetSINHVIENSingleRecord(string id)
        {
            return _context.sinhvien.FirstOrDefault(t => Convert.ToString(t.idsv) == id);
        }

        public List<SINHVIEN> GetSINHVIENRecords()
        {
            return _context.sinhvien.ToList();
        }

        // SUC CHUA
        public void AddSUCCHUARecord(SUCCHUA sc)
        {
            _context.succhua.Add(sc);
            _context.SaveChanges();
        }

        public void UpdateSUCCHUARecord(SUCCHUA sc)
        {
            _context.succhua.Update(sc);
            _context.SaveChanges();
        }

        public void DeleteSUCCHUARecord(string id)
        {
            var entity = _context.succhua.FirstOrDefault(t => Convert.ToString(t.idsucchua) == id);
            _context.succhua.Remove(entity);
            _context.SaveChanges();
        }

        public SUCCHUA GetSUCCHUASingleRecord(string id)
        {
            return _context.succhua.FirstOrDefault(t => Convert.ToString(t.idsucchua) == id);
        }

        public List<SUCCHUA> GetSUCCHUARecords()
        {
            return _context.succhua.ToList();
        }

        // TRINH DO
        public void AddTRINHDORecord(TRINHDO td)
        {
            _context.trinhdo.Add(td);
            _context.SaveChanges();
        }

        public void UpdateTRINHDORecord(TRINHDO td)
        {
            _context.trinhdo.Update(td);
            _context.SaveChanges();
        }

        public void DeleteTRINHDORecord(string id)
        {
            var entity = _context.trinhdo.FirstOrDefault(t => Convert.ToString(t.idtrinhdo) == id);
            _context.trinhdo.Remove(entity);
            _context.SaveChanges();
        }

        public TRINHDO GetTRINHDOSingleRecord(string id)
        {
            return _context.trinhdo.FirstOrDefault(t => Convert.ToString(t.idtrinhdo) == id);
        }

        public List<TRINHDO> GetTRINHDORecords()
        {
            return _context.trinhdo.ToList();
        }

        // KET QUA HOC TAP
        public void AddKETQUAHOCTAPRecord(KETQUAHOCTAP kqht)
        {
            _context.ketquahoctap.Add(kqht);
            _context.SaveChanges();
        }

        public void UpdateKETQUAHOCTAPRecord(KETQUAHOCTAP kqht)
        {
            _context.ketquahoctap.Update(kqht);
            _context.SaveChanges();
        }

        public void DeleteKETQUAHOCTAPRecord(string id)
        {
            var entity = _context.ketquahoctap.FirstOrDefault(t => Convert.ToString(t.idketquahoctap) == id);
            _context.ketquahoctap.Remove(entity);
            _context.SaveChanges();
        }

        public KETQUAHOCTAP GetKETQUAHOCTAPSingleRecord(string id)
        {
            return _context.ketquahoctap.FirstOrDefault(t => Convert.ToString(t.idketquahoctap) == id);
        }

        public List<KETQUAHOCTAP> GetKETQUAHOCTAPRecords()
        {
            return _context.ketquahoctap.ToList();
        }

        // TKB SINH VIEN
        public void AddTKBSVRecord(TKBSV tkbsv)
        {
            _context.tkbsv.Add(tkbsv);
            _context.SaveChanges();
        }

        public void UpdateTKBSVRecord(TKBSV tkbsv)
        {
            _context.tkbsv.Update(tkbsv);
            _context.SaveChanges();
        }

        public void DeleteTKBSVRecord(string id)
        {
            var entity = _context.tkbsv.FirstOrDefault(t => Convert.ToString(t.idtkbsinhvien) == id);
            _context.tkbsv.Remove(entity);
            _context.SaveChanges();
        }

        public TKBSV GetTKBSVSingleRecord(string id)
        {
            return _context.tkbsv.FirstOrDefault(t => Convert.ToString(t.idtkbsinhvien) == id);
        }

        public List<TKBSV> GetTKBSVRecords()
        {
            return _context.tkbsv.ToList();
        }

        // TKB NHOM LOP
        public void AddTKBNHOMLOPRecord(TKBNHOMLOP tkbnl)
        {
            _context.tkbnhomlop.Add(tkbnl);
            _context.SaveChanges();
        }

        public void UpdateTKBNHOMLOPRecord(TKBNHOMLOP tkbnl)
        {
            _context.tkbnhomlop.Update(tkbnl);
            _context.SaveChanges();
        }

        public void DeleteTKBNHOMLOPRecord(string id)
        {
            var entity = _context.tkbnhomlop.FirstOrDefault(t => Convert.ToString(t.idtkbnhomlop) == id);
            _context.tkbnhomlop.Remove(entity);
            _context.SaveChanges();
        }

        public TKBNHOMLOP GetTKBNHOMLOPSingleRecord(string id)
        {
            return _context.tkbnhomlop.FirstOrDefault(t => Convert.ToString(t.idtkbnhomlop) == id);
        }

        public List<TKBNHOMLOP> GetTKBNHOMLOPRecords()
        {
            return _context.tkbnhomlop.ToList();
        }

        public void AddKHOAHOCRecord(KHOAHOC kh)
        {
            _context.khoahoc.Add(kh);
            _context.SaveChanges();
        }

        public void UpdateKHOAHOCRecord(KHOAHOC kh)
        {
            _context.khoahoc.Update(kh);
            _context.SaveChanges();
        }

        public void DeleteKHOAHOCRecord(string id)
        {
            var entity = _context.khoahoc.FirstOrDefault(t => Convert.ToString(t.idkhoahoc) == id);
            _context.khoahoc.Remove(entity);
            _context.SaveChanges();
        }

        public KHOAHOC GetKHOAHOCSingleRecord(string id)
        {
            return _context.khoahoc.FirstOrDefault(t => Convert.ToString(t.idkhoahoc) == id);
        }

        public List<KHOAHOC> GetKHOAHOCRecords()
        {
            return _context.khoahoc.ToList();
        }

        public void AddCHITIETKHDTRecord(CHITIETKHDT ct)
        {
            _context.chitietkhdt.Add(ct);
            _context.SaveChanges();
        }

        public void UpdateCHITIETKHDTRecord(CHITIETKHDT ct)
        {
            _context.chitietkhdt.Update(ct);
            _context.SaveChanges();
        }

        public void DeleteCHITIETKHDTRecord(string id)
        {
            var entity = _context.chitietkhdt.FirstOrDefault(t => Convert.ToString(t.idchitietkhdt) == id);
            _context.chitietkhdt.Remove(entity);
            _context.SaveChanges();
        }

        public CHITIETKHDT GetCHITIETKHDTSingleRecord(string id)
        {
            return _context.chitietkhdt.FirstOrDefault(t => Convert.ToString(t.idchitietkhdt) == id);
        }

        public List<CHITIETKHDT> GetCHITIETKHDTRecords()
        {
            return _context.chitietkhdt.ToList();
        }

        public void AddUSERRecord(USER user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUSERRecord(USER user)
        {
            _context.user.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUSERRecord(string username)
        {
            var entity = _context.user.FirstOrDefault(t => Convert.ToString(t.username) == username);
            _context.user.Remove(entity);
            _context.SaveChanges();
        }

        public USER GetUSERSingleRecord(string username)
        {
            return _context.user.FirstOrDefault(t => Convert.ToString(t.username) == username);
        }

        public List<USER> GetUSERRecords()
        {
            return _context.user.ToList();
        }

        public void AddROLERecord(ROLE role)
        {
            _context.role.Add(role);
            _context.SaveChanges();
        }

        public void UpdateROLERecord(ROLE role)
        {
            _context.role.Update(role);
            _context.SaveChanges();
        }

        public void DeleteROLERecord(string id)
        {
            var entity = _context.role.FirstOrDefault(t => Convert.ToString(t.idrole) == id);
            _context.role.Remove(entity);
            _context.SaveChanges();
        }

        public ROLE GetROLESingleRecord(string id)
        {
            return _context.role.FirstOrDefault(t => Convert.ToString(t.idrole) == id);
        }

        public List<ROLE> GetROLERecords()
        {
            return _context.role.ToList();
        }

        public SINHVIEN GetSINHVIENByUsername(string usernames)
        {
            return _context.sinhvien.FirstOrDefault(t => Convert.ToString(t.username) == usernames);
        }

        public void AddDKHP_DataRecord(DKHPData dkhp)
        {
            _context.dkhpdata.Add(dkhp);
            _context.SaveChanges();
        }

        public void UpdateDKHP_DataRecord(DKHPData dkhp)
        {
            _context.dkhpdata.Update(dkhp);
            _context.SaveChanges();
        }

        public void DeleteDKHP_DataRecord(string id)
        {
            var entity = _context.dkhpdata.FirstOrDefault(t => Convert.ToString(t.iddkhp) == id);
            _context.dkhpdata.Remove(entity);
            _context.SaveChanges();
        }

        public DKHPData GetDKHP_DataSingleRecord(string id)
        {
            return _context.dkhpdata.FirstOrDefault(t => Convert.ToString(t.iddkhp) == id);
        }

        public List<DKHPData> GetDKHP_DataRecords()
        {
            return _context.dkhpdata.ToList();
        }
    }
}
