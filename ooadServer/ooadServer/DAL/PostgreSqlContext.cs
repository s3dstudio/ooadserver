using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        public DbSet<KHDT> khdt { get; set; }
        public DbSet<KHOA> khoa { get; set; }
        public DbSet<CHUYENNGANH> chuyennganh { get; set; }
        public DbSet<GIANGVIEN> giangvien { get; set; }
        public DbSet<CHUCNANG> chucnang { get; set; }
        public DbSet<HEDAOTAO> hedaotao { get; set; }
        public DbSet<HOCPHAN> hocphan { get; set; }
        public DbSet<HOPDONG> hopdong { get; set; }
        public DbSet<LOAIHINHDT> loaihinhdt { get; set; }
        public DbSet<NHOMLOP> nhomlop { get; set; }
        public DbSet<PHONGHOC> phonghoc { get; set; }
        public DbSet<SINHVIEN> sinhvien { get; set; }
        public DbSet<SUCCHUA> succhua { get; set; }
        public DbSet<TRINHDO> trinhdo { get; set; }
        public DbSet<KETQUAHOCTAP> ketquahoctap { get; set; }
        public DbSet<TKBSV> tkbsv { get; set; }
        public DbSet<TKBNHOMLOP> tkbnhomlop { get; set; }
        public DbSet<KHOAHOC> khoahoc { get; set; }
        public DbSet<CHITIETKHDT> chitietkhdt { get; set; }
        public DbSet<USER> user { get; set; }
        public DbSet<ROLE> role { get; set; }
        public DbSet<DKHPData> dkhpdata { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KHDT>()
                .HasKey("idkhdt");
            builder.Entity<KHOA>()
                .HasKey("idkhoa");
            builder.Entity<CHUYENNGANH>()
                .HasKey("idchuyennganh");
            builder.Entity<GIANGVIEN>()
                .HasKey("idgiangvien");
            builder.Entity<CHUCNANG>()
                .HasKey("idchucnang");
            builder.Entity<HEDAOTAO>()
                .HasKey("idhedaotao");
            builder.Entity<HOCPHAN>()
                .HasKey("idhocphan");
            builder.Entity<HOPDONG>()
                .HasKey("idhopdong");
            builder.Entity<LOAIHINHDT>()
                .HasKey("idlhdt");
            builder.Entity<NHOMLOP>()
                .HasKey("idnhomlop");
            builder.Entity<PHONGHOC>()
                .HasKey("idphonghoc");
            builder.Entity<SINHVIEN>()
                .HasKey("idsv");
            builder.Entity<SUCCHUA>()
                .HasKey("idsucchua");
            builder.Entity<TRINHDO>()
                .HasKey("idtrinhdo");
            builder.Entity<KETQUAHOCTAP>()
                .HasKey("idketquahoctap");
            builder.Entity<TKBSV>()
                .HasKey("idtkbsinhvien");
            builder.Entity<TKBNHOMLOP>()
                .HasKey("idtkbnhomlop");
            builder.Entity<KHOAHOC>()
                .HasKey("idkhoahoc");
            builder.Entity<CHITIETKHDT>()
                .HasKey("idchitietkhdt");
            builder.Entity<USER>()
                .HasKey("username");
            builder.Entity<ROLE>()
                .HasKey("idrole");
            builder.Entity<DKHPData>()
                .HasKey("iddkhp");
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
