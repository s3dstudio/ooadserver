using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public interface IDataAccessProvider
    {
        void AddKHDTRecord(KHDT khdt);
        void UpdateKHDTRecord(KHDT khdt);
        void DeleteKHDTRecord(string id);
        KHDT GetKHDTSingleRecord(string id);
        List<KHDT> GetKHDTRecords();

        void AddKHOARecord(KHOA khoa);
        void UpdateKHOARecord(KHOA khoa);
        void DeleteKHOARecord(string id);
        KHOA GetKHOASingleRecord(string id);
        List<KHOA> GetKHOARecords();

        void AddCHUYENNGANHRecord(CHUYENNGANH cn);
        void UpdateCHUYENNGANHRecord(CHUYENNGANH cn);
        void DeleteCHUYENNGANHRecord(string id);
        CHUYENNGANH GetCHUYENNGANHSingleRecord(string id);
        List<CHUYENNGANH> GetCHUYENNGANHRecords();

        void AddGIANGVIENRecord(GIANGVIEN GV);
        void UpdateGIANGVIENRecord(GIANGVIEN GV);
        void DeleteGIANGVIENRecord(string id);
        GIANGVIEN GetGIANGVIENSingleRecord(string id);
        List<GIANGVIEN> GetGIANGVIENRecords();

        void AddCHUCNANGRecord(CHUCNANG cn);
        void UpdateCHUCNANGRecord(CHUCNANG cn);
        void DeleteCHUCNANGRecord(string id);
        CHUCNANG GetCHUCNANGSingleRecord(string id);
        List<CHUCNANG> GetCHUCNANGRecords();

        void AddHEDAOTAORecord(HEDAOTAO hdt);
        void UpdateHEDAOTAORecord(HEDAOTAO hdt);
        void DeleteHEDAOTAORecord(string id);
        HEDAOTAO GetHEDAOTAOSingleRecord(string id);
        List<HEDAOTAO> GetHEDAOTAORecords();

        void AddHOCPHANRecord(HOCPHAN hp);
        void UpdateHOCPHANRecord(HOCPHAN hp);
        void DeleteHOCPHANRecord(string id);
        HOCPHAN GetHOCPHANSingleRecord(string id);
        List<HOCPHAN> GetHOCPHANRecords();

        void AddHOPDONGRecord(HOPDONG hd);
        void UpdateHOPDONGRecord(HOPDONG hd);
        void DeleteHOPDONGRecord(string id);
        HOPDONG GetHOPDONGSingleRecord(string id);
        List<HOPDONG> GetHOPDONGRecords();

        void AddLOAIHINHDTRecord(LOAIHINHDT lhdt);
        void UpdateLOAIHINHDTRecord(LOAIHINHDT lhdt);
        void DeleteLOAIHINHDTRecord(string id);
        LOAIHINHDT GetLOAIHINHDTSingleRecord(string id);
        List<LOAIHINHDT> GetLOAIHINHDTRecords();

        void AddNHOMLOPRecord(NHOMLOP nl);
        void UpdateNHOMLOPRecord(NHOMLOP nl);
        void DeleteNHOMLOPRecord(string id);
        NHOMLOP GetNHOMLOPSingleRecord(string id);
        List<NHOMLOP> GetNHOMLOPRecords();

        void AddPHONGHOCRecord(PHONGHOC ph);
        void UpdatePHONGHOCRecord(PHONGHOC ph);
        void DeletePHONGHOCRecord(string id);
        PHONGHOC GetPHONGHOCSingleRecord(string id);
        List<PHONGHOC> GetPHONGHOCRecords();

        void AddSINHVIENRecord(SINHVIEN sv);
        void UpdateSINHVIENRecord(SINHVIEN sv);
        void DeleteSINHVIENRecord(string id);
        SINHVIEN GetSINHVIENSingleRecord(string id);
        SINHVIEN GetSINHVIENByUsername(string usernames);
        List<SINHVIEN> GetSINHVIENRecords();

        void AddSUCCHUARecord(SUCCHUA sc);
        void UpdateSUCCHUARecord(SUCCHUA sc);
        void DeleteSUCCHUARecord(string id);
        SUCCHUA GetSUCCHUASingleRecord(string id);
        List<SUCCHUA> GetSUCCHUARecords();

        void AddTRINHDORecord(TRINHDO td);
        void UpdateTRINHDORecord(TRINHDO td);
        void DeleteTRINHDORecord(string id);
        TRINHDO GetTRINHDOSingleRecord(string id);
        List<TRINHDO> GetTRINHDORecords();

        void AddKETQUAHOCTAPRecord(KETQUAHOCTAP kqht);
        void UpdateKETQUAHOCTAPRecord(KETQUAHOCTAP kqht);
        void DeleteKETQUAHOCTAPRecord(string id);
        KETQUAHOCTAP GetKETQUAHOCTAPSingleRecord(string id);
        List<KETQUAHOCTAP> GetKETQUAHOCTAPRecords();

        void AddTKBSVRecord(TKBSV tkbsv);
        void UpdateTKBSVRecord(TKBSV tkbsv);
        void DeleteTKBSVRecord(string id);
        TKBSV GetTKBSVSingleRecord(string id);
        List<TKBSV> GetTKBSVRecords();

        void AddTKBNHOMLOPRecord(TKBNHOMLOP tkbnl);
        void UpdateTKBNHOMLOPRecord(TKBNHOMLOP tkbnl);
        void DeleteTKBNHOMLOPRecord(string id);
        TKBNHOMLOP GetTKBNHOMLOPSingleRecord(string id);
        List<TKBNHOMLOP> GetTKBNHOMLOPRecords();

        void AddKHOAHOCRecord(KHOAHOC kh);
        void UpdateKHOAHOCRecord(KHOAHOC kh);
        void DeleteKHOAHOCRecord(string id);
        KHOAHOC GetKHOAHOCSingleRecord(string id);
        List<KHOAHOC> GetKHOAHOCRecords();

        void AddCHITIETKHDTRecord(CHITIETKHDT ct);
        void UpdateCHITIETKHDTRecord(CHITIETKHDT ct);
        void DeleteCHITIETKHDTRecord(string id);
        CHITIETKHDT GetCHITIETKHDTSingleRecord(string id);
        List<CHITIETKHDT> GetCHITIETKHDTRecords();

        void AddUSERRecord(USER user);
        void UpdateUSERRecord(USER user);
        void DeleteUSERRecord(string username);
        USER GetUSERSingleRecord(string username);
        List<USER> GetUSERRecords();

        void AddROLERecord(ROLE role);
        void UpdateROLERecord(ROLE role);
        void DeleteROLERecord(string id);
        ROLE GetROLESingleRecord(string id);
        List<ROLE> GetROLERecords();

    }
}
