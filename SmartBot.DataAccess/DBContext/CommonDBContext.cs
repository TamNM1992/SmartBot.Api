using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Base;

namespace SmartBot.DataAccess.DBContext
{
    public partial class CommonDBContext : PDataContext
    {
        public CommonDBContext(DbContextOptions options) : base(options)
        {
        }

        //public virtual DbSet<Author> Authors { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Author>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("Author");

            //    entity.Property(e => e.AuthorId).HasColumnName("Author_Id");

            //    entity.Property(e => e.AuthorName)
            //        .HasMaxLength(50)
            //        .HasColumnName("Author_Name");
            //});

            //modelBuilder.Entity<ContactCtvRe>(entity =>
            //{
            //    entity.ToTable("ContactCtvRE");

            //    entity.Property(e => e.IdRe).HasColumnName("IdRE");

            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.ContactCtvRes)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_ContactCtvRE_TBLCTVONLINE");

            //    entity.HasOne(d => d.IdReNavigation)
            //        .WithMany(p => p.ContactCtvRes)
            //        .HasForeignKey(d => d.IdRe)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_ContactCtvRE_RealEstate");
            //});

            //modelBuilder.Entity<CounterTimeOnline>(entity =>
            //{
            //    entity.ToTable("CounterTimeOnline");

            //    entity.Property(e => e.Date).HasColumnType("date");

            //    entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.CounterTimeOnlines)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CounterTimeOnline_TBLCTVONLINE");
            //});

            //modelBuilder.Entity<CtvPositionDepartment>(entity =>
            //{
            //    entity.ToTable("CtvPositionDepartment");

            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.CtvPositionDepartments)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CtvPosition_TBLCTVONLINE");

            //    entity.HasOne(d => d.IdPositionDepartmentNavigation)
            //        .WithMany(p => p.CtvPositionDepartments)
            //        .HasForeignKey(d => d.IdPositionDepartment)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_CtvPosition_Position");
            //});

            //modelBuilder.Entity<D99Tmp>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("D99_Tmp");

            //    entity.Property(e => e.Depth)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("depth");

            //    entity.Property(e => e.File)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("file");

            //    entity.Property(e => e.Subdirectory)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("subdirectory");
            //});

            //modelBuilder.Entity<Department>(entity =>
            //{
            //    entity.ToTable("Department");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.DepartmentName).HasMaxLength(100);

            //    entity.Property(e => e.Description).HasMaxLength(500);

            //    entity.Property(e => e.Name).HasMaxLength(100);



            //    entity.HasOne(d => d.IdCompanyNavigation)
            //        .WithMany(p => p.Departments)
            //        .HasForeignKey(d => d.IdCompany)
            //        .HasConstraintName("FK_Department_tblDanhSachCongTy");
            //});

            //modelBuilder.Entity<DepositRealEstate>(entity =>
            //{
            //    entity.ToTable("DepositRealEstate");

            //    entity.Property(e => e.BuyerIdNum)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);
            //    entity.Property(e => e.ContractImg)
            //        .HasMaxLength(256)
            //        .IsUnicode(false);

            //    entity.Property(e => e.BuyerName).HasMaxLength(50);
            //    entity.Property(e => e.Name).HasMaxLength(500);
            //    entity.Property(e => e.BuyerPhone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.PaymentDeadline).HasColumnType("datetime");

            //    entity.Property(e => e.DepositDate).HasColumnType("datetime");

            //    entity.Property(e => e.DateUpdate).HasColumnType("datetime");

            //    entity.Property(e => e.Detail).HasMaxLength(1000);

            //    entity.Property(e => e.IdRE).HasColumnName("IdRE");

            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.DepositRealEstates)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_DepositRealEstate_TBLCTVONLINE");

            //    entity.HasOne(d => d.IdReNavigation)
            //        .WithMany(p => p.DepositRealEstates)
            //        .HasForeignKey(d => d.IdRE)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_DepositRealEstate_RealEstate");
            //});

            //modelBuilder.Entity<Document>(entity =>
            //{
            //    entity.ToTable("Document");

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.FileSize).HasColumnType("decimal(18, 0)");

            //    entity.Property(e => e.FileType)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Name).HasMaxLength(200);

            //    entity.Property(e => e.Url).HasMaxLength(512);

            //    entity.HasOne(d => d.IdRealEstateNavigation)
            //        .WithMany(p => p.Documents)
            //        .HasForeignKey(d => d.IdRealEstate)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Document_RealEstate");

            //    entity.HasOne(d => d.IdTypeNavigation)
            //        .WithMany(p => p.Documents)
            //        .HasForeignKey(d => d.IdType)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Document_Document");
            //});

            //modelBuilder.Entity<DocumentType>(entity =>
            //{
            //    entity.ToTable("DocumentType");

            //    entity.Property(e => e.Name).HasMaxLength(50);
            //});

            //modelBuilder.Entity<Dtproperty>(entity =>
            //{
            //    entity.HasKey(e => new { e.Id, e.Property })
            //        .HasName("pk_dtproperties");

            //    entity.ToTable("dtproperties");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("id");

            //    entity.Property(e => e.Property)
            //        .HasMaxLength(64)
            //        .IsUnicode(false)
            //        .HasColumnName("property");

            //    entity.Property(e => e.Lvalue)
            //        .HasColumnType("image")
            //        .HasColumnName("lvalue");

            //    entity.Property(e => e.Objectid).HasColumnName("objectid");

            //    entity.Property(e => e.Uvalue)
            //        .HasMaxLength(255)
            //        .HasColumnName("uvalue");

            //    entity.Property(e => e.Value)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("value");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<Dtproperty1>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("dtproperties", "usnhadatvn");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Lvalue)
            //        .HasColumnType("image")
            //        .HasColumnName("lvalue");

            //    entity.Property(e => e.Objectid).HasColumnName("objectid");

            //    entity.Property(e => e.Property)
            //        .HasMaxLength(64)
            //        .IsUnicode(false)
            //        .HasColumnName("property");

            //    entity.Property(e => e.Uvalue)
            //        .HasMaxLength(255)
            //        .HasColumnName("uvalue");

            //    entity.Property(e => e.Value)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("value");

            //    entity.Property(e => e.Version).HasColumnName("version");
            //});

            //modelBuilder.Entity<FolderUploadSmartBot>(entity =>
            //{
            //    entity.ToTable("FolderUploadSmartBot");

            //    entity.Property(e => e.Name).HasMaxLength(200);
            //});

            //modelBuilder.Entity<Getalltinvip>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("GETALLTINVIP");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ENDDATE");

            //    entity.Property(e => e.Header)
            //        .HasMaxLength(250)
            //        .HasColumnName("HEADER");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.Idu).HasColumnName("_IDU");

            //    entity.Property(e => e.Lefhour).HasColumnName("lefhour");

            //    entity.Property(e => e.TinVip).HasMaxLength(50);
            //});

            //modelBuilder.Entity<Getidconhan>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("GETIDCONHAN");

            //    entity.Property(e => e.Idu).HasColumnName("_IDU");

            //    entity.Property(e => e.Num).HasColumnName("num");
            //});

            //modelBuilder.Entity<IpCount>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("ipCount", "nhadatdb");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.Num).HasColumnName("num");
            //});

            //modelBuilder.Entity<KvQTt>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("KV_Q_TT");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");
            //});

            //modelBuilder.Entity<KvQTt1>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("KV_Q_TT", "usnhadatvn");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");
            //});

            //modelBuilder.Entity<ListTrunglap>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("LIST_TRUNGLAP");

            //    entity.Property(e => e.Header)
            //        .HasMaxLength(250)
            //        .HasColumnName("header");

            //    entity.Property(e => e.Num).HasColumnName("NUM");
            //});

            //modelBuilder.Entity<LogBook>(entity =>
            //{
            //    entity.ToTable("LogBook");

            //    entity.Property(e => e.Action).HasMaxLength(100);

            //    entity.Property(e => e.DateCreate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(1000);

            //    entity.Property(e => e.Detail).HasMaxLength(1000);
            //});

            //modelBuilder.Entity<Menu>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("Menu");

            //    entity.Property(e => e.Description).HasMaxLength(255);

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Keyword).HasMaxLength(255);

            //    entity.Property(e => e.Langid).HasColumnName("LANGID");

            //    entity.Property(e => e.Links)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.PageId).HasColumnName("PageID");

            //    entity.Property(e => e.ParentId).HasColumnName("ParentID");

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.TabId).HasColumnName("TabID");

            //    entity.Property(e => e.Text).HasMaxLength(50);
            //});

            //modelBuilder.Entity<Permission>(entity =>
            //{
            //    entity.ToTable("Permission");

            //    entity.Property(e => e.Description).HasMaxLength(100);
            //});

            //modelBuilder.Entity<Position>(entity =>
            //{
            //    entity.ToTable("Position");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Description).HasMaxLength(200);

            //    entity.Property(e => e.Name).HasMaxLength(100);
            //});

            //modelBuilder.Entity<PositionDepartment>(entity =>
            //{
            //    entity.ToTable("PositionDepartment");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Description).HasMaxLength(100);
            //    entity.HasOne(d => d.IdDepartmentNavigation)
            //        .WithMany(p => p.PositionDepartments)
            //        .HasForeignKey(d => d.IdDepartment)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_PositionDepartment_Department");

            //    entity.HasOne(d => d.IdPositionNavigation)
            //        .WithMany(p => p.PositionDepartments)
            //        .HasForeignKey(d => d.IdPosition)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_PositionDepartment_Position");
            //});

            //modelBuilder.Entity<RealEstate>(entity =>
            //{
            //    entity.ToTable("RealEstate");

            //    entity.Property(e => e.Address).HasMaxLength(200);

            //    entity.Property(e => e.BonusPercent).HasColumnType("decimal(4, 2)");

            //    entity.Property(e => e.CountView).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.DateCreate).HasColumnType("datetime");

            //    entity.Property(e => e.DateUpdate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(2000);

            //    entity.Property(e => e.Email).HasMaxLength(50);

            //    entity.Property(e => e.EntranceLenght).HasColumnType("decimal(8, 2)");

            //    entity.Property(e => e.FrontLenght).HasColumnType("decimal(8, 2)");

            //    entity.Property(e => e.ImplementCompany).HasMaxLength(100);

            //    //entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Lenght).HasColumnType("decimal(8, 2)");

            //    entity.Property(e => e.LinkFb)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("LinkFB");

            //    entity.Property(e => e.Manager).HasMaxLength(50);

            //    entity.Property(e => e.Name).HasMaxLength(200);

            //    entity.Property(e => e.NumberWc).HasColumnName("NumberWC");

            //    //entity.Property(e => e.OfferPrice).HasColumnType("decimal(18, 2)");
            //    entity.Property(e => e.OwnerCCCD)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.OwnerName).HasMaxLength(50);

            //    entity.Property(e => e.Phone).HasMaxLength(20);

            //    entity.Property(e => e.S).HasColumnType("decimal(8, 2)");

            //    entity.Property(e => e.SearchKey)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SellerPhone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.SourcePhone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");

            //    entity.HasOne(d => d.DirectionHouseNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.DirectionHouse)
            //        .HasConstraintName("FK_RealEstate_TB_HUONGNHA");

            //    entity.HasOne(d => d.IdCompanyNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdCompany)
            //        .HasConstraintName("FK_RealEstate_tblDanhSachCongTy");

            //    entity.HasOne(d => d.IdDistrictNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdDistrict)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_RealEstate_TB_QUAN");

            //    entity.HasOne(d => d.IdProvinceNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdProvince)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_RealEstate_TB_TINHTHANH");

            //    entity.HasOne(d => d.IdStreetNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdStreet)
            //        .HasConstraintName("FK_RealEstate_TB_KV");

            //    entity.HasOne(d => d.IdTypeNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdType)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_RealEstate_TB_LOAINHA");

            //    entity.HasOne(d => d.IdUserNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdUser)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_RealEstate_TBLCTVONLINE");

            //    entity.HasOne(d => d.IdWardNavigation)
            //        .WithMany(p => p.RealEstates)
            //        .HasForeignKey(d => d.IdWard)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_RealEstate_TB_PHUONG");
            //});

            //modelBuilder.Entity<RewriteTable>(entity =>
            //{
            //    entity.ToTable("RewriteTable");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.NewUrl).HasMaxLength(256);

            //    entity.Property(e => e.OriginalUrl).HasMaxLength(256);

            //    entity.Property(e => e.WoId).HasColumnName("WO_ID");
            //});

            //modelBuilder.Entity<SaveRealEstate>(entity =>
            //{
            //    entity.ToTable("SaveRealEstate");

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.IdRe).HasColumnName("IdRE");

            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.SaveRealEstates)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SaveRealEstate_TBLCTVONLINE");

            //    entity.HasOne(d => d.IdReNavigation)
            //        .WithMany(p => p.SaveRealEstates)
            //        .HasForeignKey(d => d.IdRe)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SaveRealEstate_RealEstate");
            //});

            //modelBuilder.Entity<Singer>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("Singer");

            //    entity.Property(e => e.SingerId).HasColumnName("Singer_Id");

            //    entity.Property(e => e.SingerName)
            //        .HasMaxLength(250)
            //        .HasColumnName("Singer_Name");
            //});

            //modelBuilder.Entity<Song>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("Song");

            //    entity.Property(e => e.MemberId).HasColumnName("MemberID");

            //    entity.Property(e => e.Ngaysinh).HasColumnType("datetime");

            //    entity.Property(e => e.SongAuthorId)
            //        .HasColumnName("Song_AuthorId")
            //        .HasDefaultValueSql("(1)");

            //    entity.Property(e => e.SongCount)
            //        .HasColumnName("song_count")
            //        .HasDefaultValueSql("(1)");

            //    entity.Property(e => e.SongDescription)
            //        .HasMaxLength(255)
            //        .HasColumnName("Song_Description");

            //    entity.Property(e => e.SongId)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("Song_Id");

            //    entity.Property(e => e.SongListenCount).HasColumnName("Song_ListenCount");

            //    entity.Property(e => e.SongLyric)
            //        .HasColumnType("ntext")
            //        .HasColumnName("Song_Lyric");

            //    entity.Property(e => e.SongName)
            //        .HasMaxLength(250)
            //        .HasColumnName("Song_Name");

            //    entity.Property(e => e.SongPublishedDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("Song_PublishedDate");

            //    entity.Property(e => e.SongSingerId)
            //        .HasColumnName("Song_SingerId")
            //        .HasDefaultValueSql("(1)");

            //    entity.Property(e => e.SongType)
            //        .HasColumnName("Song_Type")
            //        .HasDefaultValueSql("(1)");

            //    entity.Property(e => e.SongUrl)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("Song_URL");

            //    entity.Property(e => e.Vn)
            //        .HasColumnName("VN")
            //        .HasDefaultValueSql("(1)");
            //});

            //modelBuilder.Entity<SongBinhluan>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("song_binhluan");

            //    entity.Property(e => e.BinhLuan)
            //        .HasColumnType("ntext")
            //        .HasColumnName("Binh_luan");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Ngay).HasColumnType("datetime");

            //    entity.Property(e => e.SongId).HasColumnName("song_ID");

            //    entity.Property(e => e.UserName)
            //        .HasMaxLength(250)
            //        .HasColumnName("user_name");
            //});

            //modelBuilder.Entity<SourceRE>(entity =>
            //{
            //    entity.ToTable("SourceRE");

            //    entity.Property(e => e.Name).HasMaxLength(100);
            //});

            //modelBuilder.Entity<TbBannerGroup>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tbBannerGroup");

            //    entity.Property(e => e.Description).HasMaxLength(50);

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TbCounter>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_COUNTER");

            //    entity.Property(e => e.NumKv).HasColumnName("numKV");

            //    entity.Property(e => e.NumN).HasColumnName("numN");

            //    entity.Property(e => e.Online).HasColumnName("online");

            //    entity.Property(e => e.Thanhvien).HasColumnName("thanhvien");

            //    entity.Property(e => e.Truycap).HasColumnName("truycap");
            //});

            //modelBuilder.Entity<TbDt>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_DT");

            //    entity.Property(e => e.Dientich)
            //        .HasMaxLength(50)
            //        .HasColumnName("DIENTICH");

            //    entity.Property(e => e.IdDt)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID_DT");

            //    entity.Property(e => e.Stt).HasColumnName("STT");
            //});

            //modelBuilder.Entity<TbEmailqueue>(entity =>
            //{
            //    entity.ToTable("TB_EMAILQUEUE");

            //    entity.Property(e => e.Id)
            //        .HasMaxLength(38)
            //        .IsUnicode(false)
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Body).HasColumnType("ntext");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.FromEmail)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Send)
            //        .HasColumnName("send")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Sub)
            //        .HasMaxLength(300)
            //        .HasColumnName("sub");

            //    entity.Property(e => e.ToEmail)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TbEnter>(entity =>
            //{
            //    entity.HasKey(e => e.IdE);

            //    entity.ToTable("TB_ENTER");

            //    entity.Property(e => e.IdE).HasColumnName("ID_E");

            //    entity.Property(e => e.Banner)
            //        .HasMaxLength(50)
            //        .HasColumnName("BANNER")
            //        .IsFixedLength();

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL")
            //        .IsFixedLength();

            //    entity.Property(e => e.Logo)
            //        .HasMaxLength(50)
            //        .HasColumnName("LOGO")
            //        .IsFixedLength();
            //});

            //modelBuilder.Entity<TbGiaodich>(entity =>
            //{
            //    entity.HasKey(e => e.IdT);

            //    entity.ToTable("TB_GIAODICH");

            //    entity.Property(e => e.IdT).HasColumnName("ID_T");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("email");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.Ngay)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ngay");

            //    entity.Property(e => e.Ngaygiahan)
            //        .HasColumnName("ngaygiahan")
            //        .HasDefaultValueSql("(0)");

            //    entity.Property(e => e.Thang).HasColumnName("thang");
            //});

            //modelBuilder.Entity<TbGium>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_GIA");

            //    entity.Property(e => e.Giathanh)
            //        .HasMaxLength(100)
            //        .HasColumnName("GIATHANH");

            //    entity.Property(e => e.IdG)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID_G");

            //    entity.Property(e => e.Stt).HasColumnName("STT");
            //});

            //modelBuilder.Entity<TbHuongnha>(entity =>
            //{
            //    entity.HasKey(e => e.IdHn);

            //    entity.ToTable("TB_HUONGNHA");

            //    entity.Property(e => e.IdHn)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID_HN");

            //    entity.Property(e => e.Huongnha)
            //        .HasMaxLength(50)
            //        .HasColumnName("HUONGNHA");

            //    entity.Property(e => e.Stt).HasColumnName("STT");
            //});

            //modelBuilder.Entity<TbKeydirty>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_KEYDIRTY");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Keyword)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .IsFixedLength();
            //});

            //modelBuilder.Entity<TbKeysearch>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_KEYSEARCH");

            //    entity.Property(e => e.Des).HasColumnType("ntext");

            //    entity.Property(e => e.Keyword)
            //        .HasColumnType("ntext")
            //        .HasColumnName("keyword");
            //});

            //modelBuilder.Entity<TbKv>(entity =>
            //{
            //    entity.HasKey(e => e.IdKv);

            //    entity.ToTable("TB_KV");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.Active).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Diengiai)
            //        .HasMaxLength(500)
            //        .HasColumnName("DIENGIAI");

            //    entity.Property(e => e.IdLoainha)
            //        .HasColumnName("ID_LOAINHA")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.IdPhuong).HasColumnName("ID_PHUONG");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.NumBan).HasColumnName("numBan");

            //    entity.Property(e => e.NumCanMua).HasColumnName("numCanMua");

            //    entity.Property(e => e.NumChothue).HasColumnName("numChothue");

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.Tenkv)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENKV");

            //    entity.Property(e => e.Tenkv2)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TENKV2");
            //});

            //modelBuilder.Entity<TbLienhe>(entity =>
            //{
            //    entity.HasKey(e => e.IdLh);

            //    entity.ToTable("TB_LIENHE");

            //    entity.Property(e => e.IdLh).HasColumnName("ID_LH");

            //    entity.Property(e => e.Content)
            //        .HasColumnType("ntext")
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.Diachi)
            //        .HasColumnType("ntext")
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.IdduanUser).HasColumnName("IDDUAN_USER");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.Phone)
            //        .HasColumnType("ntext")
            //        .HasColumnName("PHONE");

            //    entity.Property(e => e.Style).HasColumnName("style");

            //    entity.Property(e => e.Subject)
            //        .HasColumnType("ntext")
            //        .HasColumnName("SUBJECT");
            //});

            //modelBuilder.Entity<TbLink>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_LINK");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("email");

            //    entity.Property(e => e.IdLk)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID_LK");

            //    entity.Property(e => e.Img)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("IMG")
            //        .IsFixedLength();

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.Style).HasColumnName("style");

            //    entity.Property(e => e.Title).HasMaxLength(50);

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("URL")
            //        .IsFixedLength();
            //});

            //modelBuilder.Entity<TbLoaigium>(entity =>
            //{
            //    entity.HasKey(e => e.IdLg);

            //    entity.ToTable("TB_LOAIGIA");

            //    entity.Property(e => e.IdLg).HasColumnName("ID_LG");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.Loaigia)
            //        .HasMaxLength(50)
            //        .HasColumnName("LOAIGIA");
            //});

            //modelBuilder.Entity<TbLoainha>(entity =>
            //{
            //    entity.HasKey(e => e.IdLn);

            //    entity.ToTable("TB_LOAINHA");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.Tenln)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENLN");
            //});

            //modelBuilder.Entity<TbLoaitin>(entity =>
            //{
            //    entity.HasKey(e => e.IdLt);

            //    entity.ToTable("TB_LOAITIN");

            //    entity.Property(e => e.IdLt)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID_LT");

            //    entity.Property(e => e.Caption).HasMaxLength(50);

            //    entity.Property(e => e.TenLt)
            //        .HasMaxLength(40)
            //        .HasColumnName("TenLT");
            //});

            //modelBuilder.Entity<TbMenu>(entity =>
            //{
            //    entity.HasKey(e => e.IdMn);

            //    entity.ToTable("TB_MENU");

            //    entity.Property(e => e.IdMn).HasColumnName("ID_MN");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.Style).HasColumnName("STYLE");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(200)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(200)
            //        .HasColumnName("URL");
            //});

            //modelBuilder.Entity<TbMessage>(entity =>
            //{
            //    entity.HasKey(e => e.IdM);

            //    entity.ToTable("tb_message");

            //    entity.Property(e => e.IdM).HasColumnName("ID_M");

            //    entity.Property(e => e.Content).HasMaxLength(300);
            //});

            //modelBuilder.Entity<TbNha>(entity =>
            //{
            //    entity.HasKey(e => e.IdN);

            //    entity.ToTable("TB_NHA");

            //    entity.Property(e => e.IdN)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID_N");

            //    entity.Property(e => e.ActionsmsId)
            //        .HasColumnName("ActionsmsID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Avata)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("_AVATA");

            //    entity.Property(e => e.ClickVipstatus)
            //        .HasColumnName("ClickVIPStatus")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Cochodexe)
            //        .HasColumnName("_COCHODEXE")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Contactinfo)
            //        .HasMaxLength(500)
            //        .HasColumnName("contactinfo");

            //    entity.Property(e => e.Content)
            //        .HasColumnType("ntext")
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.Count)
            //        .HasColumnName("COUNT")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Description)
            //        .HasMaxLength(500)
            //        .HasColumnName("_DESCRIPTION");

            //    entity.Property(e => e.Dientich).HasColumnName("DIENTICH");

            //    entity.Property(e => e.Duongtruocmat)
            //        .HasColumnName("_DUONGTRUOCMAT")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Flag)
            //        .HasColumnName("FLAG")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Fullimage)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("_FULLIMAGE");

            //    entity.Property(e => e.Fullname)
            //        .HasMaxLength(100)
            //        .HasColumnName("_FULLNAME");

            //    entity.Property(e => e.Header).HasMaxLength(250);

            //    entity.Property(e => e.Huongnha)
            //        .HasMaxLength(100)
            //        .HasColumnName("_HUONGNHA");

            //    entity.Property(e => e.IdDt).HasColumnName("ID_DT");

            //    entity.Property(e => e.IdG).HasColumnName("ID_G");

            //    entity.Property(e => e.IdHn).HasColumnName("ID_HN");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.IdPhuong)
            //        .HasColumnName("ID_PHUONG")
            //        .HasDefaultValueSql("('0')");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdQq).HasColumnName("ID_QQ");

            //    entity.Property(e => e.IdTk)
            //        .HasMaxLength(36)
            //        .HasColumnName("ID_TK");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Idu).HasColumnName("_IDU");

            //    entity.Property(e => e.Infotvtrue)
            //        .HasColumnName("infotvtrue")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IntDate).HasColumnName("intDate");

            //    entity.Property(e => e.IntHtgiaodich)
            //        .HasColumnName("intHTGiaodich")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IntTtphaply)
            //        .HasColumnName("intTTPhaply")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IsInvets)
            //        .HasColumnName("isInvets")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IsPheduyetInvest)
            //        .HasColumnName("isPheduyetInvest")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IsReady)
            //        .HasColumnName("isReady")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Khuvuc)
            //        .HasMaxLength(100)
            //        .HasColumnName("_KHUVUC");

            //    entity.Property(e => e.Lat)
            //        .HasColumnName("_LAT")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.ListImage)
            //        .IsUnicode(false)
            //        .HasColumnName("listImage");

            //    entity.Property(e => e.Loainha)
            //        .HasMaxLength(100)
            //        .HasColumnName("_LOAINHA");

            //    entity.Property(e => e.Lon)
            //        .HasColumnName("_LON")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Matien)
            //        .HasColumnName("_MATIEN")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(15)
            //        .HasColumnName("_MOBILE");

            //    entity.Property(e => e.Mode).HasColumnName("mode");

            //    entity.Property(e => e.Moigioi)
            //        .HasColumnName("MOIGIOI")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Ngaydang).HasColumnType("datetime");

            //    entity.Property(e => e.Ngayhethan).HasColumnType("datetime");

            //    entity.Property(e => e.Numlike)
            //        .HasColumnName("_NUMLIKE")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.PrivateInfo).HasMaxLength(500);

            //    entity.Property(e => e.Smstrue).HasColumnName("smstrue");

            //    entity.Property(e => e.Sopk)
            //        .HasColumnName("_SOPK")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Sopn)
            //        .HasColumnName("_SOPN")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Sotang)
            //        .HasColumnName("_SOTANG")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Sotien).HasColumnName("SOTIEN");

            //    entity.Property(e => e.Tenphuong)
            //        .HasMaxLength(100)
            //        .HasColumnName("_TENPHUONG");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(100)
            //        .HasColumnName("_TENQUAN");

            //    entity.Property(e => e.Tinhthanh)
            //        .HasMaxLength(100)
            //        .HasColumnName("_TINHTHANH");

            //    entity.Property(e => e.Tinvip)
            //        .HasColumnName("tinvip")
            //        .HasDefaultValueSql("((0))")
            //        .HasComment("0");

            //    entity.Property(e => e.Tl).HasColumnName("TL");

            //    entity.Property(e => e.UrlPixbe)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("url_pixbe");
            //});

            //modelBuilder.Entity<TbNhagr>(entity =>
            //{
            //    entity.HasKey(e => e.IdNgr);

            //    entity.ToTable("TB_NHAGR");

            //    entity.Property(e => e.IdNgr).HasColumnName("ID_NGR");

            //    entity.Property(e => e.Content)
            //        .HasMaxLength(1000)
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.Count)
            //        .HasColumnName("COUNT")
            //        .HasDefaultValueSql("(0)");

            //    entity.Property(e => e.Dientich).HasColumnName("DIENTICH");

            //    entity.Property(e => e.Flag)
            //        .HasColumnName("FLAG")
            //        .HasDefaultValueSql("(0)");

            //    entity.Property(e => e.Giatien).HasColumnName("GIATIEN");

            //    entity.Property(e => e.Header)
            //        .HasMaxLength(200)
            //        .HasColumnName("HEADER");

            //    entity.Property(e => e.IdHn).HasColumnName("ID_HN");

            //    entity.Property(e => e.IdLg).HasColumnName("ID_LG");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(38)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U");

            //    entity.Property(e => e.Ngaydang)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYDANG");

            //    entity.Property(e => e.Ngayhethan)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYHETHAN");

            //    entity.Property(e => e.Tinvip)
            //        .HasColumnName("TINVIP")
            //        .HasDefaultValueSql("(0)");

            //    entity.Property(e => e.Tl)
            //        .HasColumnName("TL")
            //        .HasDefaultValueSql("(0)");

            //    entity.Property(e => e.Urlpic1)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("URLPIC1");
            //});

            //modelBuilder.Entity<TbNhomtin>(entity =>
            //{
            //    entity.HasKey(e => e.IdNt);

            //    entity.ToTable("TB_NHOMTIN");

            //    entity.Property(e => e.IdNt).HasColumnName("ID_NT");

            //    entity.Property(e => e.IdDuan)
            //        .HasColumnName("ID_DUAN")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdDuanUser)
            //        .HasColumnName("ID_DUAN_USER")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdKv)
            //        .HasColumnName("ID_KV")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdTt)
            //        .HasColumnName("ID_TT")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.ParentId)
            //        .HasColumnName("PARENT_ID")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Tennt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENNT");
            //});

            //modelBuilder.Entity<TbPhuong>(entity =>
            //{
            //    entity.ToTable("TB_PHUONG");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdQuan).HasColumnName("ID_QUAN");

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.Tenphuong)
            //        .HasMaxLength(250)
            //        .HasColumnName("TENPHUONG");

            //    entity.Property(e => e.Tenphuong2)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TENPHUONG2");
            //});

            //modelBuilder.Entity<TbPic>(entity =>
            //{
            //    entity.HasKey(e => e.FileId)
            //        .HasName("PK_TB_PIC_1");

            //    entity.ToTable("TB_PIC");

            //    entity.Property(e => e.FileId).HasColumnName("FileID");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("date")
            //        .HasColumnName("date")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.FileUrl)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("FileURL");

            //    entity.Property(e => e.Filecomment).HasMaxLength(200);

            //    entity.Property(e => e.IdN)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("id_n");

            //    entity.Property(e => e.IsDelete).HasColumnName("isDelete");

            //    entity.Property(e => e.Urlthumbnai)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("URLThumbnai");
            //});

            //modelBuilder.Entity<TbProfile>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_Profile");

            //    entity.Property(e => e.IdPro)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID_Pro");

            //    entity.Property(e => e.Title).HasMaxLength(50);

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("URL");
            //});

            //modelBuilder.Entity<TbQuan>(entity =>
            //{
            //    entity.HasKey(e => e.IdQ);

            //    entity.ToTable("TB_QUAN");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.Diengiai)
            //        .HasMaxLength(50)
            //        .HasColumnName("DIENGIAI");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.NumBan)
            //        .HasColumnName("numBan")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.NumCanmua)
            //        .HasColumnName("numCanmua")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.NumChothue)
            //        .HasColumnName("numChothue")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("stt")
            //        .HasDefaultValueSql("((10))");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENQUAN");

            //    entity.Property(e => e.Tenquan2)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TENQUAN2");
            //});

            //modelBuilder.Entity<TbReply>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_Reply");

            //    entity.Property(e => e.IdN)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_N")
            //        .IsFixedLength();

            //    entity.Property(e => e.IdR)
            //        .HasMaxLength(38)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_R");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U")
            //        .IsFixedLength();

            //    entity.Property(e => e.Ngaydang)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYDANG");

            //    entity.Property(e => e.Reply)
            //        .HasMaxLength(256)
            //        .HasColumnName("REPLY");
            //});

            //modelBuilder.Entity<TbTinhthanh>(entity =>
            //{
            //    entity.HasKey(e => e.IdTt);

            //    entity.ToTable("TB_TINHTHANH");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Diengiai).HasMaxLength(50);

            //    entity.Property(e => e.Locality).HasMaxLength(50);

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.TenTt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TenTT");

            //    entity.Property(e => e.Tentt2)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TENTT2");
            //});

            //modelBuilder.Entity<TbTinnhan>(entity =>
            //{
            //    entity.HasKey(e => e.IdTn);

            //    entity.ToTable("TB_TINNHAN");

            //    entity.Property(e => e.IdTn).HasColumnName("ID_TN");

            //    entity.Property(e => e.Address).HasMaxLength(500);

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.EmailFrom)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmailTo)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Message).HasMaxLength(500);

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Subject).HasMaxLength(100);
            //});

            //modelBuilder.Entity<TbTintuc>(entity =>
            //{
            //    entity.HasKey(e => e.IdTin);

            //    entity.ToTable("TB_TINTUC");

            //    entity.Property(e => e.IdTin).HasColumnName("ID_TIN");

            //    entity.Property(e => e.Content)
            //        .HasColumnType("ntext")
            //        .HasColumnName("content");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.IdNt).HasColumnName("ID_NT");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U");

            //    entity.Property(e => e.Intstyle)
            //        .HasColumnName("INTSTYLE")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Mode)
            //        .HasColumnName("mode")
            //        .HasDefaultValueSql("('1')");

            //    entity.Property(e => e.NewLink)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("newLink");

            //    entity.Property(e => e.Numclick)
            //        .HasColumnName("numclick")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Title2)
            //        .HasMaxLength(200)
            //        .HasColumnName("TITLE2");

            //    entity.Property(e => e.Tomtat)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TOMTAT");

            //    entity.Property(e => e.UrlImage)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("URL_IMAGE");

            //    entity.Property(e => e.UrlThumbnai)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("URL_THUMBNAI");
            //});

            //modelBuilder.Entity<TbUser>(entity =>
            //{
            //    entity.ToTable("TB_USER");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Address)
            //        .HasMaxLength(200)
            //        .HasColumnName("address");

            //    entity.Property(e => e.Appleid)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("APPLEID");

            //    entity.Property(e => e.Avatar)
            //        .HasMaxLength(512)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DailySendEmail)
            //        .HasColumnName("dailySendEmail")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Dateupdateavatar)
            //        .HasColumnType("date")
            //        .HasColumnName("dateupdateavatar")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Doituong)
            //        .HasColumnName("doituong")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.Fullname)
            //        .HasMaxLength(500)
            //        .HasColumnName("FULLNAME");

            //    entity.Property(e => e.GioiTinh).HasDefaultValueSql("((3))");

            //    entity.Property(e => e.Gps)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("GPS");

            //    entity.Property(e => e.Group)
            //        .HasColumnName("group")
            //        .HasDefaultValueSql("((4))")
            //        .HasComment("4");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(36)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U");

            //    entity.Property(e => e.Iosstatus).HasColumnName("IOSStatus");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(15)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.IsKiemduyet)
            //        .HasColumnName("isKiemduyet")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.IsOnline).HasColumnName("isOnline");

            //    entity.Property(e => e.IsReady)
            //        .HasColumnName("isReady")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IsSendEmail)
            //        .HasColumnName("isSendEmail")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Kh).HasColumnName("KH");

            //    entity.Property(e => e.Langid)
            //        .HasColumnName("langid")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.LastVisited)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Ngaydangky)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ngaydangky")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.NickSkype)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("nickSkype");

            //    entity.Property(e => e.NickYahoo)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NumUpdateDaily).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Password)
            //        .HasMaxLength(30)
            //        .IsUnicode(false)
            //        .HasColumnName("PASSWORD");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("PHONE");

            //    entity.Property(e => e.Point).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Scriptchat)
            //        .HasMaxLength(1024)
            //        .IsUnicode(false)
            //        .HasColumnName("scriptchat");

            //    entity.Property(e => e.Signal)
            //        .HasMaxLength(500)
            //        .HasDefaultValueSql("('')");

            //    entity.Property(e => e.TaiKhoan).HasDefaultValueSql("((10000))");

            //    entity.Property(e => e.TaiKhoanThat).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.UserVerify).HasMaxLength(150);

            //    entity.Property(e => e.Vip)
            //        .HasColumnName("vip")
            //        .HasDefaultValueSql("((0))")
            //        .HasComment("0");

            //    entity.Property(e => e.Weburl)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("weburl");
            //});

            //modelBuilder.Entity<TbVettimkiem>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TB_VETTIMKIEM");

            //    entity.Property(e => e.Andvip).HasColumnName("ANDVIP");

            //    entity.Property(e => e.Dvdt).HasColumnName("DVDT");

            //    entity.Property(e => e.Dvfromgia).HasColumnName("DVFROMGIA");

            //    entity.Property(e => e.Dvtogia).HasColumnName("DVTOGIA");

            //    entity.Property(e => e.Fromdt).HasColumnName("FROMDT");

            //    entity.Property(e => e.Fromgia).HasColumnName("FROMGIA");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdHn).HasColumnName("ID_HN");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(38)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U");

            //    entity.Property(e => e.Ngaydang)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYDANG");

            //    entity.Property(e => e.Numrc).HasColumnName("NUMRC");

            //    entity.Property(e => e.Orderby).HasColumnName("ORDERBY");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Todt).HasColumnName("TODT");

            //    entity.Property(e => e.Togia).HasColumnName("TOGIA");
            //});

            //modelBuilder.Entity<TblBangGiaDangVip>(entity =>
            //{
            //    entity.ToTable("tblBangGiaDangVIP");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.LoaiGia).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblBanner>(entity =>
            //{
            //    entity.ToTable("tblBanner");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Click).HasColumnName("click");

            //    entity.Property(e => e.GroupId).HasColumnName("GroupID");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.LangId).HasColumnName("LangID");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("link");

            //    entity.Property(e => e.Stt).HasColumnName("stt");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("title");
            //});

            //modelBuilder.Entity<TblBanner2012>(entity =>
            //{
            //    entity.ToTable("tblBanner2012");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("date")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Enddate).HasColumnType("datetime");

            //    entity.Property(e => e.Iduser).HasColumnName("IDUser");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Image2)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IntLoaitin).HasColumnName("intLoaitin");

            //    entity.Property(e => e.IntPage).HasColumnName("intPage");

            //    entity.Property(e => e.IntPosition).HasColumnName("intPosition");

            //    entity.Property(e => e.IntStyle).HasColumnName("intStyle");

            //    entity.Property(e => e.IntTinhThanh).HasColumnName("intTinhThanh");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("link");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<TblBlockIdforInvest>(entity =>
            //{
            //    entity.ToTable("tblBlockIDforInvest");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.BlockId).HasColumnName("BlockID");

            //    entity.Property(e => e.MyId).HasColumnName("MyID");

            //    entity.Property(e => e.Time)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");
            //});

            //modelBuilder.Entity<TblCanHo>(entity =>
            //{
            //    entity.ToTable("tblCanHo");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Dientich).HasColumnType("decimal(6, 2)");

            //    entity.Property(e => e.FullImage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.GiaGoc).HasColumnType("decimal(5, 2)");

            //    entity.Property(e => e.HuongBc)
            //        .HasColumnName("HuongBC")
            //        .HasDefaultValueSql("((11))");

            //    entity.Property(e => e.HuongCuaVao).HasDefaultValueSql("((11))");

            //    entity.Property(e => e.IdchungCu).HasColumnName("IDChungCu");

            //    entity.Property(e => e.PhongWc).HasColumnName("PhongWC");

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");

            //    entity.Property(e => e.ThumbnaiImage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblChuDe>(entity =>
            //{
            //    entity.ToTable("tblChuDe");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.TenChuDe).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblChuDeBinhLuan>(entity =>
            //{
            //    entity.ToTable("tblChuDeBinhLuan");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.ChuDe).HasColumnType("ntext");

            //    entity.Property(e => e.Img).HasMaxLength(500);

            //    entity.Property(e => e.StartDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblChungcu>(entity =>
            //{
            //    entity.ToTable("tblChungcu");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdLoainha)
            //        .HasColumnName("ID_LOAINHA")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");

            //    entity.Property(e => e.Thumbnai)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblClickBanner>(entity =>
            //{
            //    entity.ToTable("tblClickBanner");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Idbanner).HasColumnName("IDBanner");

            //    entity.Property(e => e.Intdate).HasColumnName("intdate");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.UserAgent)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblCountClickNha>(entity =>
            //{
            //    entity.ToTable("tblCountClickNha");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");
            //});

            //modelBuilder.Entity<TblDanhSachCongTy>(entity =>
            //{
            //    entity.ToTable("tblDanhSachCongTy");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Address).HasMaxLength(200);

            //    entity.Property(e => e.Avatar)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Description).HasMaxLength(500);
            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Fax)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Name).HasMaxLength(50);

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            //});

            //modelBuilder.Entity<TblDichVuDungTien>(entity =>
            //{
            //    entity.ToTable("tblDichVuDungTien");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.DichVu).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblDoanhThuNapGold>(entity =>
            //{
            //    entity.ToTable("tblDoanhThuNapGold");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein).HasColumnType("datetime");

            //    entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");
            //});

            //modelBuilder.Entity<TblDonGiaVip>(entity =>
            //{
            //    entity.ToTable("tblDonGiaVIP");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Dongia).HasColumnName("dongia");

            //    entity.Property(e => e.IdLoaivip).HasColumnName("id_loaivip");

            //    entity.Property(e => e.IdTt).HasColumnName("id_tt");
            //});

            //modelBuilder.Entity<TblGiaoDichKhachHang>(entity =>
            //{
            //    entity.ToTable("tblGiaoDichKhachHang");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idkh).HasColumnName("IDKH");

            //    entity.Property(e => e.NoiDungGiaoDich).HasMaxLength(200);

            //    entity.Property(e => e.Times).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblGroupUser>(entity =>
            //{
            //    entity.ToTable("tblGroupUser");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idgroup).HasColumnName("IDGROUP");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(200)
            //        .HasColumnName("NAME");
            //});

            //modelBuilder.Entity<TblHeSoDuToan>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblHeSoDuToan");

            //    entity.Property(e => e.Cphoanthien1)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPHOANTHIEN1");

            //    entity.Property(e => e.Cphoanthien2)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPHOANTHIEN2");

            //    entity.Property(e => e.Cpnhancong1)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPNHANCONG1");

            //    entity.Property(e => e.Cpnhancong2)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPNHANCONG2");

            //    entity.Property(e => e.Cpxdphantho1)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPXDPHANTHO1");

            //    entity.Property(e => e.Cpxpphantho2)
            //        .HasColumnType("decimal(18, 3)")
            //        .HasColumnName("CPXPPHANTHO2");

            //    entity.Property(e => e.Hesochung1).HasColumnName("HESOCHUNG1");

            //    entity.Property(e => e.Hesochung2).HasColumnName("HESOCHUNG2");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idln).HasColumnName("IDLN");

            //    entity.Property(e => e.Idm).HasColumnName("IDM");
            //});

            //modelBuilder.Entity<TblHinhThucNapTien>(entity =>
            //{
            //    entity.ToTable("tblHinhThucNapTien");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.HinhThuc).HasMaxLength(50);

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");
            //});

            //modelBuilder.Entity<TblHtgiaodich>(entity =>
            //{
            //    entity.ToTable("tblHTGiaodich");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");

            //    entity.Property(e => e.Hinhthucgiaodich).HasMaxLength(100);
            //});

            //modelBuilder.Entity<TblIdhotro>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblIDHotro");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Idcare).HasColumnName("IDCare");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");
            //});

            //modelBuilder.Entity<TblImageDuAn>(entity =>
            //{
            //    entity.ToTable("tblImageDuAn");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdKhuVuc).HasColumnName("ID_KhuVuc");

            //    entity.Property(e => e.IdLoaiBds).HasColumnName("ID_LoaiBDS");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.TitleImage)
            //        .HasMaxLength(50)
            //        .HasColumnName("titleImage");

            //    entity.Property(e => e.UrlImage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Urlthumbnai)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("URLThumbnai");
            //});

            //modelBuilder.Entity<TblInfoTv>(entity =>
            //{
            //    entity.ToTable("tblInfoTV");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.EndDate).HasColumnType("datetime");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.StartDate).HasColumnType("datetime");

            //    entity.Property(e => e.StrLinkVideo)
            //        .HasMaxLength(100)
            //        .HasColumnName("strLinkVideo");
            //});

            //modelBuilder.Entity<TblInvestInfo>(entity =>
            //{
            //    entity.ToTable("tblInvestInfo");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Info).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblIpaccess>(entity =>
            //{
            //    entity.ToTable("tblIPAccess");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblIpspam>(entity =>
            //{
            //    entity.ToTable("tblIPSpam");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Date).HasColumnType("datetime");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");
            //});

            //modelBuilder.Entity<TblKhachHang>(entity =>
            //{
            //    entity.ToTable("tblKhachHang");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.DienThoai)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.GhiChu).HasMaxLength(200);

            //    entity.Property(e => e.Idu).HasColumnName("idu");

            //    entity.Property(e => e.NhuCau).HasMaxLength(200);

            //    entity.Property(e => e.TenKhachHang).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblKhoangGium>(entity =>
            //{
            //    entity.ToTable("tblKhoangGia");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");
            //});

            //modelBuilder.Entity<TblLinkSearch>(entity =>
            //{
            //    entity.ToTable("tblLinkSearch");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Active).HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Click).HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein");

            //    entity.Property(e => e.Fromdientich).HasColumnName("fromdientich");

            //    entity.Property(e => e.Fromgia).HasColumnName("fromgia");

            //    entity.Property(e => e.IdChinhchu)
            //        .HasColumnName("id_chinhchu")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdKv).HasColumnName("id_kv");

            //    entity.Property(e => e.IdLn).HasColumnName("id_ln");

            //    entity.Property(e => e.IdLt).HasColumnName("id_lt");

            //    entity.Property(e => e.IdQh).HasColumnName("id_qh");

            //    entity.Property(e => e.IdTt).HasColumnName("id_tt");

            //    entity.Property(e => e.IntTag)
            //        .HasColumnName("intTag")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NumRows)
            //        .HasColumnName("numRows")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Processed)
            //        .HasColumnName("processed")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.ReferUrl)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("ReferURL");

            //    entity.Property(e => e.Reurl)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("reurl");

            //    entity.Property(e => e.Tenkhuvuc)
            //        .HasMaxLength(100)
            //        .HasColumnName("tenkhuvuc");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(100)
            //        .HasColumnName("tenquan");

            //    entity.Property(e => e.Tentt)
            //        .HasMaxLength(50)
            //        .HasColumnName("tentt");

            //    entity.Property(e => e.Title).HasMaxLength(200);

            //    entity.Property(e => e.Title3).HasMaxLength(200);

            //    entity.Property(e => e.Title4)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("title4");

            //    entity.Property(e => e.Todientich).HasColumnName("todientich");

            //    entity.Property(e => e.Togia).HasColumnName("togia");
            //});

            //modelBuilder.Entity<TblListDatCoc>(entity =>
            //{
            //    entity.ToTable("tblListDatCoc");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.DienGiai).HasMaxLength(100);

            //    entity.Property(e => e.GiaBan).HasMaxLength(50);

            //    entity.Property(e => e.GiaChuthu).HasMaxLength(50);

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.LinkFile)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NgayDatCoc).HasColumnType("datetime");

            //    entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

            //    entity.Property(e => e.NhanVien).HasMaxLength(50);

            //    entity.Property(e => e.Ttchu)
            //        .HasMaxLength(100)
            //        .HasColumnName("TTChu");

            //    entity.Property(e => e.Ttkhach)
            //        .HasMaxLength(100)
            //        .HasColumnName("TTKhach");

            //    entity.Property(e => e.Vtbds)
            //        .HasMaxLength(100)
            //        .HasColumnName("VTBDS");
            //});

            //modelBuilder.Entity<TblLoaiNha>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblLoaiNha");

            //    entity.Property(e => e.Idln).HasColumnName("IDLN");

            //    entity.Property(e => e.TenLoaiNha).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblLoaiTinVip>(entity =>
            //{
            //    entity.ToTable("tblLoaiTinVip");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");

            //    entity.Property(e => e.TinVip).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblMobileCode>(entity =>
            //{
            //    entity.ToTable("tblMobileCode");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Code)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .HasColumnName("code");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(30)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(256)
            //        .IsUnicode(false)
            //        .HasColumnName("mobile");

            //    entity.Property(e => e.Ssid)
            //        .HasMaxLength(30)
            //        .IsUnicode(false)
            //        .HasColumnName("SSID");
            //});

            //modelBuilder.Entity<TblModule>(entity =>
            //{
            //    entity.ToTable("tblModule");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.LinkControl).HasMaxLength(100);

            //    entity.Property(e => e.ModuleName).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblModulePage>(entity =>
            //{
            //    entity.ToTable("tblModulePage");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Description).HasMaxLength(50);

            //    entity.Property(e => e.Idm).HasColumnName("idm");

            //    entity.Property(e => e.Idp).HasColumnName("idp");

            //    entity.Property(e => e.Stt).HasColumnName("stt");
            //});

            //modelBuilder.Entity<TblMucDoHoanThien>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblMucDoHoanThien");

            //    entity.Property(e => e.Idm).HasColumnName("IDM");

            //    entity.Property(e => e.TenMucDo).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblNganLuongInfo>(entity =>
            //{
            //    entity.ToTable("tblNganLuongInfo");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Amount)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("amount");

            //    entity.Property(e => e.CardInfo)
            //        .HasMaxLength(100)
            //        .HasColumnName("card_info");

            //    entity.Property(e => e.CurrencyCode)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("currency_code");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.MerchantSiteCode)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("merchant_site_code");

            //    entity.Property(e => e.MethodPaymentName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("method_payment_name");

            //    entity.Property(e => e.PayerEmail)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("payer_email");

            //    entity.Property(e => e.PayerMobile)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("payer_mobile");

            //    entity.Property(e => e.PayerName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("payer_name");

            //    entity.Property(e => e.ReceiverAddress)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("receiver_address");

            //    entity.Property(e => e.ReceiverMobile)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("receiver_mobile");

            //    entity.Property(e => e.ReceiverName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("receiver_name");

            //    entity.Property(e => e.ResultCode)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("result_code");

            //    entity.Property(e => e.ResultDescription)
            //        .HasMaxLength(100)
            //        .HasColumnName("result_description");

            //    entity.Property(e => e.TimeLimit)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("time_limit");

            //    entity.Property(e => e.TokenCode)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("token_code");

            //    entity.Property(e => e.TransactionId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("transaction_id");

            //    entity.Property(e => e.TransactionStatus)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("transaction_status");

            //    entity.Property(e => e.TransactionType)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("transaction_type");
            //});

            //modelBuilder.Entity<TblNgayLamViec>(entity =>
            //{
            //    entity.ToTable("tblNgayLamViec");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Ngay).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblNhaGmap>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("tblNhaGmap");

            //    entity.Property(e => e.Description).HasMaxLength(50);

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Idn)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("IDN");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblNhaPhatMai>(entity =>
            //{
            //    entity.ToTable("tblNhaPhatMai");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");
            //});

            //modelBuilder.Entity<TblNhaReferId>(entity =>
            //{
            //    entity.ToTable("tblNha_ReferID");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdNhadat24h).HasColumnName("ID_Nhadat24h");

            //    entity.Property(e => e.IdRefer).HasColumnName("ID_Refer");

            //    entity.Property(e => e.IdWeb).HasColumnName("ID_Web");
            //});

            //modelBuilder.Entity<TblNhaVipbyClick>(entity =>
            //{
            //    entity.ToTable("tblNhaVIPbyClick");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.StartDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblNhanVien>(entity =>
            //{
            //    entity.ToTable("tblNhanVien");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATEIN");

            //    entity.Property(e => e.IdU).HasColumnName("ID_U");

            //    entity.Property(e => e.Level).HasColumnName("LEVEL");

            //    entity.Property(e => e.Namsinh)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NAMSINH");
            //});

            //modelBuilder.Entity<TblNhatKyDungTien>(entity =>
            //{
            //    entity.ToTable("tblNhatKyDungTien");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.IddichVuDungTien).HasColumnName("IDDichVuDungTien");

            //    entity.Property(e => e.Iduser)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("IDUser");

            //    entity.Property(e => e.Status).HasDefaultValueSql("((1))");

            //    entity.Property(e => e.ThoiGianKetThucDv)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ThoiGianKetThucDV");

            //    entity.Property(e => e.ThoiGianKetThucLenh).HasColumnType("datetime");

            //    entity.Property(e => e.ThoiGianPhatSinh).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblNhatKyNapTien>(entity =>
            //{
            //    entity.ToTable("tblNhatKyNapTien");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.ThoiGianNap).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblNhomChuDe>(entity =>
            //{
            //    entity.ToTable("tblNhomChuDe");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.TenNhomChuDe).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblNickTuVan2>(entity =>
            //{
            //    entity.ToTable("tblNickTuVan2");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdCongty).HasColumnName("ID_Congty");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

            //    entity.Property(e => e.NgayThamGia)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Skype)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.TenGoi).HasMaxLength(50);

            //    entity.Property(e => e.Yahoo)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblNumClickNha>(entity =>
            //{
            //    entity.ToTable("tblNumClickNha");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.IntDate).HasColumnName("intDate");
            //});

            //modelBuilder.Entity<TblPage>(entity =>
            //{
            //    entity.ToTable("tblPage");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Idtab).HasColumnName("IDTAB");

            //    entity.Property(e => e.PageName).HasMaxLength(50);

            //    entity.Property(e => e.Stt).HasColumnName("STT");
            //});

            //modelBuilder.Entity<TblPhoneKichHoat>(entity =>
            //{
            //    entity.ToTable("tblPhoneKichHoat");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Date).HasColumnType("datetime");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblQuanTinTuc>(entity =>
            //{
            //    entity.ToTable("tblQuan_TinTuc");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idkv).HasColumnName("IDKV");

            //    entity.Property(e => e.Idnt).HasColumnName("IDNT");

            //    entity.Property(e => e.Idq).HasColumnName("IDQ");
            //});

            //modelBuilder.Entity<TblSm>(entity =>
            //{
            //    entity.ToTable("tblSms");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.DateIn).HasColumnType("datetime");

            //    entity.Property(e => e.Message)
            //        .HasMaxLength(300)
            //        .IsUnicode(false);

            //    entity.Property(e => e.MobileNumber)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.OutPut)
            //        .HasMaxLength(600)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ServiceNumber)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Smsc)
            //        .HasMaxLength(50)
            //        .HasColumnName("smsc");

            //    entity.Property(e => e.Smsid)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("SMSID");

            //    entity.Property(e => e.StrService)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("strService");
            //});

            //modelBuilder.Entity<TblSmsAction>(entity =>
            //{
            //    entity.ToTable("tblSmsAction");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Action).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblSmsActionDetail>(entity =>
            //{
            //    entity.ToTable("tblSmsActionDetail");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.ActionId).HasColumnName("ActionID");

            //    entity.Property(e => e.EndDate).HasColumnType("datetime");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.StartDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblStyleUrl>(entity =>
            //{
            //    entity.ToTable("tblStyleURL");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.StyleUrl)
            //        .HasMaxLength(50)
            //        .HasColumnName("StyleURL");
            //});

            //modelBuilder.Entity<TblSuKienLienMinhBd>(entity =>
            //{
            //    entity.ToTable("tblSuKienLienMinhBDS");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("enddate");

            //    entity.Property(e => e.IdKv).HasColumnName("id_kv");

            //    entity.Property(e => e.IdTin).HasColumnName("id_tin");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("title");

            //    entity.Property(e => e.Tomtat)
            //        .HasColumnType("ntext")
            //        .HasColumnName("tomtat");

            //    entity.Property(e => e.TxtEmail)
            //        .HasColumnType("ntext")
            //        .HasColumnName("txtEmail");

            //    entity.Property(e => e.Txtsms)
            //        .HasMaxLength(160)
            //        .IsUnicode(false)
            //        .HasColumnName("txtsms");
            //});

            //modelBuilder.Entity<TblTab>(entity =>
            //{
            //    entity.ToTable("tblTab");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");

            //    entity.Property(e => e.TenTab).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblTaiKhoanMoney>(entity =>
            //{
            //    entity.ToTable("tblTaiKhoanMoney");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdHinhThucNap).HasColumnName("ID_HinhThucNap");

            //    entity.Property(e => e.IdU).HasColumnName("ID_U");

            //    entity.Property(e => e.MaGiaoDichNganLuong)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.MaNapTien)
            //        .HasMaxLength(150)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ThoiGianHoanThanh).HasColumnType("datetime");

            //    entity.Property(e => e.ThoiGianPhatSinh).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TblTempDetailNha>(entity =>
            //{
            //    entity.ToTable("tblTempDetailNha");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Description).HasMaxLength(158);

            //    entity.Property(e => e.Detail).HasColumnType("ntext");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.IntDate).HasColumnName("intDate");

            //    entity.Property(e => e.Navmenu)
            //        .HasColumnType("ntext")
            //        .HasColumnName("NAVMENU");

            //    entity.Property(e => e.Title).HasMaxLength(60);
            //});

            //modelBuilder.Entity<TblTempleCodeForChangePassword>(entity =>
            //{
            //    entity.ToTable("tblTempleCodeForChangePassword");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein).HasColumnType("datetime");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.TempCode)
            //        .HasMaxLength(40)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblTienDoDtm>(entity =>
            //{
            //    entity.ToTable("tblTienDoDTM");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

            //    entity.Property(e => e.TienDo).HasMaxLength(400);
            //});

            //modelBuilder.Entity<TblTinChuDe>(entity =>
            //{
            //    entity.ToTable("tblTinChuDe");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdchuDe).HasColumnName("IDChuDe");

            //    entity.Property(e => e.Idtin).HasColumnName("IDTin");
            //});

            //modelBuilder.Entity<TblTinhTrangDatCoc>(entity =>
            //{
            //    entity.ToTable("tblTinhTrangDatCoc");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.TinhTrang).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblTtphaply>(entity =>
            //{
            //    entity.ToTable("tblTTPhaply");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Tinhtrangphaply).HasMaxLength(100);
            //});

            //modelBuilder.Entity<TblUrlVisited>(entity =>
            //{
            //    entity.ToTable("tblUrlVisited");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.IntStyle).HasColumnName("intStyle");

            //    entity.Property(e => e.Time).HasColumnType("datetime");

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblUserLink>(entity =>
            //{
            //    entity.ToTable("tblUserLink");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_U");

            //    entity.Property(e => e.IdUlink)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_ULink");

            //    entity.Property(e => e.IntWebsite).HasColumnName("intWebsite");
            //});

            //modelBuilder.Entity<TblUserVip>(entity =>
            //{
            //    entity.ToTable("tbl_UserVIP");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(50)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.LinkLogo).HasMaxLength(200);
            //});

            //modelBuilder.Entity<TblVet>(entity =>
            //{
            //    entity.ToTable("tblVet");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.Ngay).HasColumnType("smalldatetime");

            //    entity.Property(e => e.Ten).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblVet1>(entity =>
            //{
            //    entity.ToTable("tblVet", "nhadatdb");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.Ngay).HasColumnType("smalldatetime");

            //    entity.Property(e => e.Ten).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblVitriBanner>(entity =>
            //{
            //    entity.ToTable("tblVitriBanner");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<TblVnptbanking>(entity =>
            //{
            //    entity.ToTable("tblVNPTBanking");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Amount)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.BankId)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .HasColumnName("BankID");

            //    entity.Property(e => e.Datein).HasColumnType("datetime");

            //    entity.Property(e => e.KetQua)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Status)
            //        .HasMaxLength(3)
            //        .IsUnicode(false)
            //        .HasDefaultValueSql("((10))");

            //    entity.Property(e => e.TransId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TransID");

            //    entity.Property(e => e.Transref)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.UserId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("UserID");
            //});

            //modelBuilder.Entity<TblVnptcard>(entity =>
            //{
            //    entity.ToTable("tblVNPTCard");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein");

            //    entity.Property(e => e.LoaiThe)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Mathe)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Serial)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Sotien)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Status).HasMaxLength(50);

            //    entity.Property(e => e.TargetId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TargetID");

            //    entity.Property(e => e.TransId)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TransID");
            //});

            //modelBuilder.Entity<TblWebOneClick>(entity =>
            //{
            //    entity.ToTable("tblWebOneClick");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Click).HasColumnName("CLICK");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(360)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Ngansach).HasColumnName("NGANSACH");

            //    entity.Property(e => e.Ngaychay)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYCHAY");

            //    entity.Property(e => e.Tinhtrang).HasColumnName("TINHTRANG");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<TblWebsite>(entity =>
            //{
            //    entity.ToTable("tblWebsite");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.ActiveIos).HasColumnName("ActiveIOS");

            //    entity.Property(e => e.Connection)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Website)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblWoElement>(entity =>
            //{
            //    entity.ToTable("TBL_WO_ELEMENT");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Cssname)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("CSSNAME");

            //    entity.Property(e => e.DefaultTheme)
            //        .HasMaxLength(256)
            //        .IsUnicode(false)
            //        .HasColumnName("DEFAULT_THEME");

            //    entity.Property(e => e.Element)
            //        .HasMaxLength(50)
            //        .HasColumnName("ELEMENT");

            //    entity.Property(e => e.Inttheme).HasColumnName("INTTHEME");

            //    entity.Property(e => e.Intthuoctinh).HasColumnName("INTTHUOCTINH");

            //    entity.Property(e => e.ThuocTinh)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<TblWoElementConfig>(entity =>
            //{
            //    entity.ToTable("TBL_WO_ELEMENT_CONFIG");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Ide).HasColumnName("IDE");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Value)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("VALUE");
            //});

            //modelBuilder.Entity<Tblagent>(entity =>
            //{
            //    entity.ToTable("TBLAGENT");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Avatar)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("AVATAR");

            //    entity.Property(e => e.Description)
            //        .HasMaxLength(300)
            //        .HasColumnName("DESCRIPTION");

            //    entity.Property(e => e.DuanUser).HasColumnName("DUAN_USER");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("PHONE");

            //    entity.Property(e => e.Ten)
            //        .HasMaxLength(100)
            //        .HasColumnName("TEN");
            //});

            //modelBuilder.Entity<TblcachedKhoanggium>(entity =>
            //{
            //    entity.ToTable("tblcached_khoanggia");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Data)
            //        .HasColumnType("date")
            //        .HasColumnName("data");

            //    entity.Property(e => e.Detail)
            //        .HasColumnType("ntext")
            //        .HasColumnName("detail");

            //    entity.Property(e => e.IdKv).HasColumnName("id_kv");

            //    entity.Property(e => e.IdLn).HasColumnName("id_ln");

            //    entity.Property(e => e.IdLt).HasColumnName("id_lt");

            //    entity.Property(e => e.IdQh).HasColumnName("id_qh");

            //    entity.Property(e => e.IdTt).HasColumnName("id_tt");

            //    entity.Property(e => e.Style).HasColumnName("style");
            //});

            //modelBuilder.Entity<Tblchitietchungcu>(entity =>
            //{
            //    entity.ToTable("TBLCHITIETCHUNGCU");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Chenh)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("CHENH");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATEIN")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Descrip)
            //        .HasMaxLength(1000)
            //        .HasColumnName("DESCRIP");

            //    entity.Property(e => e.Giagoc)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("GIAGOC");

            //    entity.Property(e => e.Hoahong)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("HOAHONG");

            //    entity.Property(e => e.IdChungcu).HasColumnName("ID_CHUNGCU");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdLoaitin).HasColumnName("ID_LOAITIN");

            //    entity.Property(e => e.IdduanUser).HasColumnName("IDDUAN_USER");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.IsDatCoc)
            //        .HasColumnName("isDatCoc")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Status).HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");

            //    entity.Property(e => e.Tang).HasColumnName("TANG");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tblchucvu>(entity =>
            //{
            //    entity.ToTable("TBLCHUCVU");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Chucvu)
            //        .HasMaxLength(50)
            //        .HasColumnName("CHUCVU");
            //});

            //modelBuilder.Entity<Tblchudautu>(entity =>
            //{
            //    entity.ToTable("TBLCHUDAUTU");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Fax)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("FAX");

            //    entity.Property(e => e.Idkv).HasColumnName("IDKV");

            //    entity.Property(e => e.Idqh).HasColumnName("IDQH");

            //    entity.Property(e => e.Idtt).HasColumnName("IDTT");

            //    entity.Property(e => e.Iduser).HasColumnName("IDUSER");

            //    entity.Property(e => e.Intgroup).HasColumnName("INTGROUP");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("LAT");

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("LON");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("PHONE");

            //    entity.Property(e => e.Ten)
            //        .HasMaxLength(50)
            //        .HasColumnName("TEN");

            //    entity.Property(e => e.Website)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("WEBSITE");
            //});

            //modelBuilder.Entity<TblcitySelected>(entity =>
            //{
            //    entity.ToTable("tblcitySelected");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Stt).HasColumnName("STT");

            //    entity.Property(e => e.TenTt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TenTT");
            //});

            //modelBuilder.Entity<Tblcomment>(entity =>
            //{
            //    entity.ToTable("TBLCOMMENT");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Comment)
            //        .HasMaxLength(200)
            //        .HasColumnName("COMMENT");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.Idtopic).HasColumnName("IDTOPIC");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(100)
            //        .HasColumnName("NAME");

            //    entity.Property(e => e.ParentId)
            //        .HasColumnName("ParentID")
            //        .HasDefaultValueSql("((0))");
            //});

            //modelBuilder.Entity<Tblcountupdate>(entity =>
            //{
            //    entity.ToTable("TBLCOUNTUPDATE");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.Intdate).HasColumnName("INTDATE");

            //    entity.Property(e => e.Sotien).HasColumnName("SOTIEN");
            //});

            //modelBuilder.Entity<Tblctvonline>(entity =>
            //{
            //    entity.ToTable("TBLCTVONLINE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Avatar2)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Backimageid)
            //        .HasMaxLength(100)
            //        .HasColumnName("BACKIMAGEID");

            //    entity.Property(e => e.CvUrl)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DateIn)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.DateOut).HasColumnType("datetime");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(300)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.FaceBook)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Frontimageid)
            //        .HasMaxLength(100)
            //        .HasColumnName("FRONTIMAGEID");

            //    entity.Property(e => e.FullName).HasMaxLength(50);

            //    entity.Property(e => e.Gioithieu)
            //        .HasMaxLength(300)
            //        .HasColumnName("GIOITHIEU");

            //    entity.Property(e => e.IdCompanys)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdDepartments)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdPositionDepartments)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdPositions)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.IdQuan).HasColumnName("ID_Quan");

            //    entity.Property(e => e.Intlevel)
            //        .HasColumnName("INTLEVEL")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.IsOnline).HasColumnName("isOnline");

            //    entity.Property(e => e.LastVisited).HasColumnType("datetime");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Ngaysinh)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("NGAYSINH");

            //    entity.Property(e => e.Position).HasMaxLength(500);

            //    entity.Property(e => e.Refid).HasColumnName("REFID");

            //    entity.Property(e => e.SearchKey)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Socmtnd)
            //        .HasMaxLength(50)
            //        .HasColumnName("SOCMTND");

            //    entity.Property(e => e.Twitter)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<Tbldanhsachdksukien>(entity =>
            //{
            //    entity.ToTable("TBLDANHSACHDKSUKIEN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("date")
            //        .HasColumnName("DATEIN");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.Hoten)
            //        .HasMaxLength(50)
            //        .HasColumnName("HOTEN");

            //    entity.Property(e => e.Idsukien).HasColumnName("IDSUKIEN");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");
            //});

            //modelBuilder.Entity<Tbldanhsachduan>(entity =>
            //{
            //    entity.ToTable("TBLDANHSACHDUAN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Avatar)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("avatar");

            //    entity.Property(e => e.Cochecatdichvu)
            //        .HasColumnType("ntext")
            //        .HasColumnName("COCHECATDICHVU");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Dientichdat)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHDAT");

            //    entity.Property(e => e.Dientichsan)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHSAN");

            //    entity.Property(e => e.Dientichsp)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHSP");

            //    entity.Property(e => e.Donvithicong)
            //        .HasMaxLength(200)
            //        .HasColumnName("DONVITHICONG");

            //    entity.Property(e => e.Donvithietke)
            //        .HasMaxLength(200)
            //        .HasColumnName("DONVITHIETKE");

            //    entity.Property(e => e.Donvivon).HasColumnName("DONVIVON");

            //    entity.Property(e => e.Giabanmin)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("GIABANMIN");

            //    entity.Property(e => e.Gioithieuduan)
            //        .HasColumnType("ntext")
            //        .HasColumnName("GIOITHIEUDUAN");

            //    entity.Property(e => e.Hientrang)
            //        .HasMaxLength(100)
            //        .HasColumnName("HIENTRANG");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdLoaiduan).HasColumnName("ID_LOAIDUAN");

            //    entity.Property(e => e.IdQh).HasColumnName("ID_QH");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.IntHot)
            //        .HasColumnName("intHot")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LAT");

            //    entity.Property(e => e.Lienhe)
            //        .HasColumnType("ntext")
            //        .HasColumnName("LIENHE");

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LON");

            //    entity.Property(e => e.Matbangtongthe)
            //        .HasColumnType("ntext")
            //        .HasColumnName("MATBANGTONGTHE");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(300)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Ngayhoanthanh)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYHOANTHANH");

            //    entity.Property(e => e.Ngaykhoicong)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYKHOICONG");

            //    entity.Property(e => e.OnStore)
            //        .HasColumnName("onStore")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Phaply)
            //        .HasColumnType("ntext")
            //        .HasColumnName("PHAPLY");

            //    entity.Property(e => e.Phuongthucthanhtoan)
            //        .HasColumnType("ntext")
            //        .HasColumnName("PHUONGTHUCTHANHTOAN");

            //    entity.Property(e => e.Slideimage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("SLIDEIMAGE");

            //    entity.Property(e => e.Sotang).HasColumnName("SOTANG");

            //    entity.Property(e => e.Status)
            //        .HasColumnName("STATUS")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Stt2)
            //        .HasColumnName("STT2")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Tenchudautu)
            //        .HasMaxLength(200)
            //        .HasColumnName("TENCHUDAUTU");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tiendothicong)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TIENDOTHICONG");

            //    entity.Property(e => e.Tienich)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TIENICH");

            //    entity.Property(e => e.Tongvondautu)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TONGVONDAUTU");

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");

            //    entity.Property(e => e.Vitri)
            //        .HasColumnType("ntext")
            //        .HasColumnName("VITRI");
            //});

            //modelBuilder.Entity<Tbldatmua>(entity =>
            //{
            //    entity.ToTable("TBLDATMUA");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("email");

            //    entity.Property(e => e.IdKv)
            //        .HasColumnName("id_kv")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdQh)
            //        .HasColumnName("id_qh")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdTt)
            //        .HasColumnName("id_tt")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Idduan)
            //        .HasColumnName("idduan")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Idlink)
            //        .HasColumnName("IDLINK")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Idstyle).HasColumnName("idstyle");

            //    entity.Property(e => e.IntActive)
            //        .HasColumnName("intActive")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Ten)
            //        .HasMaxLength(50)
            //        .HasColumnName("TEN");

            //    entity.Property(e => e.Thongtin)
            //        .HasMaxLength(300)
            //        .HasColumnName("THONGTIN");
            //});

            //modelBuilder.Entity<Tbldoituong>(entity =>
            //{
            //    entity.ToTable("TBLDOITUONG");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");

            //    entity.Property(e => e.Loaithanhvien)
            //        .HasMaxLength(50)
            //        .HasColumnName("loaithanhvien");
            //});

            //modelBuilder.Entity<Tbldownloadtailieu>(entity =>
            //{
            //    entity.ToTable("tbldownloadtailieu");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Idduan).HasColumnName("idduan");

            //    entity.Property(e => e.IdduanUser).HasColumnName("idduan_user");

            //    entity.Property(e => e.Idkhuvuc).HasColumnName("idkhuvuc");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(200)
            //        .HasColumnName("link");

            //    entity.Property(e => e.Tentailieu)
            //        .HasMaxLength(200)
            //        .HasColumnName("tentailieu");
            //});

            //modelBuilder.Entity<TblduanInvest>(entity =>
            //{
            //    entity.ToTable("tblduan_invest");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Daban).HasColumnName("daban");

            //    entity.Property(e => e.IdDuan)
            //        .HasMaxLength(10)
            //        .HasColumnName("ID_DUAN")
            //        .IsFixedLength();

            //    entity.Property(e => e.Ngu).HasColumnName("ngu");

            //    entity.Property(e => e.Price).HasColumnName("price");

            //    entity.Property(e => e.Tiemnang).HasColumnName("tiemnang");

            //    entity.Property(e => e.Totalprice).HasColumnName("totalprice");

            //    entity.Property(e => e.Wc).HasColumnName("wc");
            //});

            //modelBuilder.Entity<TblduanUser>(entity =>
            //{
            //    entity.ToTable("TBLDUAN_USER");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.About).HasMaxLength(500);

            //    entity.Property(e => e.Createdate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("CREATEDATE")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description)
            //        .HasMaxLength(200)
            //        .HasColumnName("DESCRIPTION");

            //    entity.Property(e => e.Domain)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("domain")
            //        .HasDefaultValueSql("('nhadat24h.net')");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ENDDATE");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.Idga)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("IDGA")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.IntGoiDichVu)
            //        .HasColumnName("intGoiDichVu")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IntHomePage)
            //        .HasColumnName("intHomePage")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.IntHot)
            //        .HasColumnName("intHot")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IntTheme)
            //        .HasColumnName("intTheme")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Intactive)
            //        .HasColumnName("INTACTIVE")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Intupdate)
            //        .HasColumnName("INTUPDATE")
            //        .HasDefaultValueSql("((900000))");

            //    entity.Property(e => e.Keyword)
            //        .HasMaxLength(200)
            //        .HasColumnName("KEYWORD");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("LINK");

            //    entity.Property(e => e.Logo)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.OriginalUrl)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<TblduanUserPhanphoi>(entity =>
            //{
            //    entity.HasKey(e => new { e.Idu, e.Idduan });

            //    entity.ToTable("tblduan_user_phanphoi");

            //    entity.Property(e => e.Idu).HasColumnName("idu");

            //    entity.Property(e => e.Idduan).HasColumnName("idduan");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("id");

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((10))");
            //});

            //modelBuilder.Entity<Tblgallery>(entity =>
            //{
            //    entity.ToTable("TBLGALLERY");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idkv).HasColumnName("IDKV");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tblgioithieuduan>(entity =>
            //{
            //    entity.ToTable("TBLGIOITHIEUDUAN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Dientichdat)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHDAT");

            //    entity.Property(e => e.Dientichsan)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHSAN");

            //    entity.Property(e => e.Dientichsp)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHSP");

            //    entity.Property(e => e.Donvithicong)
            //        .HasMaxLength(200)
            //        .HasColumnName("DONVITHICONG");

            //    entity.Property(e => e.Donvithietke)
            //        .HasMaxLength(200)
            //        .HasColumnName("DONVITHIETKE");

            //    entity.Property(e => e.Donvivon).HasColumnName("DONVIVON");

            //    entity.Property(e => e.Giabanmin)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("GIABANMIN");

            //    entity.Property(e => e.Gioithieuduan)
            //        .HasColumnType("ntext")
            //        .HasColumnName("GIOITHIEUDUAN");

            //    entity.Property(e => e.Hientrang)
            //        .HasMaxLength(100)
            //        .HasColumnName("HIENTRANG");

            //    entity.Property(e => e.IdLoaiduan).HasColumnName("ID_LOAIDUAN");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.IntActive)
            //        .HasColumnName("intActive")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LAT");

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LON");

            //    entity.Property(e => e.Matbangtongthe)
            //        .HasColumnType("ntext")
            //        .HasColumnName("MATBANGTONGTHE");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(300)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Ngayhoanthanh)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYHOANTHANH");

            //    entity.Property(e => e.Ngaykhoicong)
            //        .HasColumnType("datetime")
            //        .HasColumnName("NGAYKHOICONG");

            //    entity.Property(e => e.Phaply)
            //        .HasColumnType("ntext")
            //        .HasColumnName("PHAPLY");

            //    entity.Property(e => e.Phuongthucthanhtoan)
            //        .HasColumnType("ntext")
            //        .HasColumnName("PHUONGTHUCTHANHTOAN");

            //    entity.Property(e => e.Sotang).HasColumnName("SOTANG");

            //    entity.Property(e => e.Tenchudautu)
            //        .HasMaxLength(200)
            //        .HasColumnName("TENCHUDAUTU");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tiendothicong)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TIENDOTHICONG");

            //    entity.Property(e => e.Tienich)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TIENICH");

            //    entity.Property(e => e.Tongvondautu)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("TONGVONDAUTU");

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");

            //    entity.Property(e => e.Vitri)
            //        .HasColumnType("ntext")
            //        .HasColumnName("VITRI");
            //});

            //modelBuilder.Entity<Tblimagefornews>(entity =>
            //{
            //    entity.ToTable("tblimagefornews");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdTin)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_TIN");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(150)
            //        .IsUnicode(false)
            //        .HasColumnName("URL");
            //});

            //modelBuilder.Entity<Tblimagegallery>(entity =>
            //{
            //    entity.ToTable("TBLIMAGEGALLERY");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdG).HasColumnName("ID_G");

            //    entity.Property(e => e.IdSg).HasColumnName("ID_SG");

            //    entity.Property(e => e.Linkthumbnai)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("LINKTHUMBNAI");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tblimageschitietchungcu>(entity =>
            //{
            //    entity.ToTable("TBLIMAGESCHITIETCHUNGCU");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idcanho).HasColumnName("IDCANHO");

            //    entity.Property(e => e.Idchitietcanho).HasColumnName("IDCHITIETCANHO");

            //    entity.Property(e => e.Stt)
            //        .HasColumnName("STT")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Thumbnai)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("THUMBNAI");

            //    entity.Property(e => e.Titile)
            //        .HasMaxLength(200)
            //        .HasColumnName("TITILE");
            //});

            //modelBuilder.Entity<Tblkhachhangdatcoc>(entity =>
            //{
            //    entity.ToTable("TBLKHACHHANGDATCOC");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Chenh)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("CHENH")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Datcoc)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("DATCOC")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATEIN")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Giagoc)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("GIAGOC")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.IdCanho)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_CANHO");

            //    entity.Property(e => e.IdChitietcanho).HasColumnName("ID_CHITIETCANHO");

            //    entity.Property(e => e.IdNv).HasColumnName("ID_NV");

            //    entity.Property(e => e.Intstatus)
            //        .HasColumnName("INTSTATUS")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Socmt)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("SOCMT");

            //    entity.Property(e => e.Tang)
            //        .HasColumnName("TANG")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Tenkhachhang)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENKHACHHANG");

            //    entity.Property(e => e.Tinhtrang).HasColumnName("TINHTRANG");
            //});

            //modelBuilder.Entity<TblliksearchDuan>(entity =>
            //{
            //    entity.ToTable("TBLLIKSEARCH_DUAN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.IntCount).HasColumnName("intCount");

            //    entity.Property(e => e.Keyword)
            //        .HasMaxLength(200)
            //        .HasColumnName("KEYWORD");
            //});

            //modelBuilder.Entity<Tbllinkbanghang>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("TBLLINKBANGHANG");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Id1).HasColumnName("ID1");

            //    entity.Property(e => e.Id2).HasColumnName("ID2");
            //});

            //modelBuilder.Entity<TbllinksearchContent>(entity =>
            //{
            //    entity.ToTable("TBLLINKSEARCH_CONTENT");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Content)
            //        .HasColumnType("ntext")
            //        .HasColumnName("CONTENT");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("LINK");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tbllinkseo>(entity =>
            //{
            //    entity.ToTable("TBLLINKSEO");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idkhuvuc).HasColumnName("IDKHUVUC");

            //    entity.Property(e => e.Idquan).HasColumnName("IDQUAN");

            //    entity.Property(e => e.Keyword)
            //        .HasMaxLength(50)
            //        .HasColumnName("KEYWORD");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("LINK");
            //});

            //modelBuilder.Entity<Tblmagiamgium>(entity =>
            //{
            //    entity.ToTable("TBLMAGIAMGIA");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Code)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("CODE");

            //    entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("date")
            //        .HasColumnName("ENDDATE");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdQh).HasColumnName("ID_QH");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Ids).HasColumnName("IDS");
            //});

            //modelBuilder.Entity<TblnewIndexNha>(entity =>
            //{
            //    entity.HasKey(e => e.Newidn);

            //    entity.ToTable("tblnewIndexNha");

            //    entity.Property(e => e.Newidn).HasColumnName("newidn");

            //    entity.Property(e => e.IdN).HasColumnName("id_n");
            //});

            //modelBuilder.Entity<Tblnhomlienminh>(entity =>
            //{
            //    entity.HasKey(e => new { e.Idu1, e.Idu2 })
            //        .HasName("PK_TBLNHOMLIENMINH_1");

            //    entity.ToTable("TBLNHOMLIENMINH");

            //    entity.Property(e => e.Idu1).HasColumnName("IDU1");

            //    entity.Property(e => e.Idu2).HasColumnName("IDU2");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Tennhom)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENNHOM");
            //});

            //modelBuilder.Entity<Tblnotifymess>(entity =>
            //{
            //    entity.ToTable("TBLNOTIFYMESS");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idu)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("IDU");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(256)
            //        .HasColumnName("link");

            //    entity.Property(e => e.Status).HasColumnName("status");

            //    entity.Property(e => e.Time)
            //        .HasColumnType("datetime")
            //        .HasColumnName("TIME")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(250)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Token)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("TOKEN");
            //});

            //modelBuilder.Entity<Tblnumroom>(entity =>
            //{
            //    entity.ToTable("tblnumroom");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Title).HasMaxLength(50);
            //});

            //modelBuilder.Entity<Tblobjpanorama>(entity =>
            //{
            //    entity.ToTable("TBLOBJPANORAMA");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdN)
            //        .HasMaxLength(40)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_N");

            //    entity.Property(e => e.IdWo).HasColumnName("ID_WO");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Type)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .HasColumnName("TYPE")
            //        .HasDefaultValueSql("('cube')");
            //});

            //modelBuilder.Entity<Tblserchlinkduan>(entity =>
            //{
            //    entity.ToTable("TBLSERCHLINKDUAN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Click)
            //        .HasColumnName("CLICK")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Dientich)
            //        .HasColumnType("decimal(6, 2)")
            //        .HasColumnName("DIENTICH");

            //    entity.Property(e => e.Idchungcu).HasColumnName("IDCHUNGCU");

            //    entity.Property(e => e.Idkv).HasColumnName("IDKV");

            //    entity.Property(e => e.Inthuongbc).HasColumnName("INTHUONGBC");

            //    entity.Property(e => e.Inthuongcuavao).HasColumnName("INTHUONGCUAVAO");

            //    entity.Property(e => e.Intphongngu).HasColumnName("INTPHONGNGU");

            //    entity.Property(e => e.Intphongwc).HasColumnName("INTPHONGWC");

            //    entity.Property(e => e.Inttang).HasColumnName("INTTANG");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(120)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tblslider>(entity =>
            //{
            //    entity.ToTable("TBLSLIDER");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Bat).HasColumnName("BAT");

            //    entity.Property(e => e.Bed).HasColumnName("BED");

            //    entity.Property(e => e.Captionbutton)
            //        .HasMaxLength(50)
            //        .HasColumnName("CAPTIONBUTTON");

            //    entity.Property(e => e.Content1)
            //        .HasMaxLength(500)
            //        .HasColumnName("CONTENT1");

            //    entity.Property(e => e.Content2)
            //        .HasMaxLength(300)
            //        .HasColumnName("CONTENT2");

            //    entity.Property(e => e.Dientich)
            //        .HasColumnType("decimal(6, 2)")
            //        .HasColumnName("DIENTICH");

            //    entity.Property(e => e.Gara).HasColumnName("GARA");

            //    entity.Property(e => e.IdduanUser).HasColumnName("IDDUAN_USER");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("LINK");

            //    entity.Property(e => e.Linkimage)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("LINKIMAGE");

            //    entity.Property(e => e.Position).HasColumnName("POSITION");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(200)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Tonggiatien)
            //        .HasMaxLength(50)
            //        .HasColumnName("TONGGIATIEN");
            //});

            //modelBuilder.Entity<Tblsubgallery>(entity =>
            //{
            //    entity.ToTable("TBLSUBGALLERY");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idg).HasColumnName("IDG");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<Tbltag>(entity =>
            //{
            //    entity.ToTable("TBLTAG");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Captag)
            //        .HasMaxLength(50)
            //        .HasColumnName("CAPTAG");

            //    entity.Property(e => e.Link)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("LINK");

            //    entity.Property(e => e.Nametag)
            //        .HasMaxLength(50)
            //        .HasColumnName("NAMETAG");
            //});

            //modelBuilder.Entity<Tbltempdangtintrongoi>(entity =>
            //{
            //    entity.ToTable("TBLTEMPDANGTINTRONGOI");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATEIN")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ENDDATE");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Status)
            //        .HasMaxLength(10)
            //        .HasColumnName("STATUS")
            //        .IsFixedLength();
            //});

            //modelBuilder.Entity<Tbltemptinvip>(entity =>
            //{
            //    entity.ToTable("TBLTEMPTINVIP");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Enddate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ENDDATE");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.IsKhuyenmai)
            //        .HasColumnName("isKhuyenmai")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.Tinvip).HasColumnName("_tinvip");
            //});

            //modelBuilder.Entity<Tbltinhtrangcanho>(entity =>
            //{
            //    entity.ToTable("tbltinhtrangcanho");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Tinhtrangcanho).HasMaxLength(50);
            //});

            //modelBuilder.Entity<Tbltinhtranglamviec>(entity =>
            //{
            //    entity.ToTable("TBLTINHTRANGLAMVIEC");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Tinhtrang)
            //        .HasMaxLength(50)
            //        .HasColumnName("TINHTRANG");
            //});

            //modelBuilder.Entity<Tbltinseo>(entity =>
            //{
            //    entity.HasKey(e => new { e.Intkey, e.Idtin });

            //    entity.ToTable("TBLTINSEO");

            //    entity.Property(e => e.Intkey).HasColumnName("INTKEY");

            //    entity.Property(e => e.Idtin).HasColumnName("IDTIN");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");
            //});

            //modelBuilder.Entity<TbltintucTag>(entity =>
            //{
            //    entity.ToTable("TBLTINTUC_TAG");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idtag).HasColumnName("IDTAG");

            //    entity.Property(e => e.Idtin).HasColumnName("IDTIN");
            //});

            //modelBuilder.Entity<TbluserDatmua>(entity =>
            //{
            //    entity.ToTable("TBLUSER_DATMUA");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Iddatmua).HasColumnName("IDDATMUA");

            //    entity.Property(e => e.Iduserdatmua).HasColumnName("IDUSERDATMUA");

            //    entity.Property(e => e.Time)
            //        .HasColumnType("datetime")
            //        .HasColumnName("TIME");
            //});

            //modelBuilder.Entity<Tblvideoduan>(entity =>
            //{
            //    entity.ToTable("TBLVIDEODUAN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Description).HasMaxLength(300);

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IduanUser).HasColumnName("IDUAN_USER");

            //    entity.Property(e => e.Linkvideo)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("LINKVIDEO");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<TblvmgpayLog>(entity =>
            //{
            //    entity.HasKey(e => e.TraceId);

            //    entity.ToTable("TBLVMGPAY_LOG");

            //    entity.Property(e => e.TraceId).HasColumnName("TraceID");

            //    entity.Property(e => e.DateIn)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DateIN")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.DateOut)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DateOUT");

            //    entity.Property(e => e.Uid).HasColumnName("UID");
            //});

            //modelBuilder.Entity<Tblweboneclickdetail>(entity =>
            //{
            //    entity.ToTable("TBLWEBONECLICKDETAIL");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Datetime)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATETIME")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Day).HasColumnName("DAY");

            //    entity.Property(e => e.Idwoclick).HasColumnName("IDWOCLICK");

            //    entity.Property(e => e.Ip)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("IP");

            //    entity.Property(e => e.Url)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("URL");
            //});

            //modelBuilder.Entity<Tblwostore>(entity =>
            //{
            //    entity.ToTable("TBLWOSTORE");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Giaban).HasColumnName("GIABAN");

            //    entity.Property(e => e.Giachothue).HasColumnName("GIACHOTHUE");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(250)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Status).HasColumnName("STATUS");
            //});

            //modelBuilder.Entity<UserPermission>(entity =>
            //{
            //    entity.ToTable("UserPermission");

            //    entity.HasOne(d => d.IdPermisionNavigation)
            //        .WithMany(p => p.UserPermissions)
            //        .HasForeignKey(d => d.IdPermision)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_UserPermission_Permission");

            //    entity.HasOne(d => d.IdUserNavigation)
            //        .WithMany(p => p.UserPermissions)
            //        .HasForeignKey(d => d.IdUser)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_UserPermission_TB_USER");
            //});

            //modelBuilder.Entity<VCanho>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_CANHO");

            //    entity.Property(e => e.Chenh)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("CHENH");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATEIN");

            //    entity.Property(e => e.Descrip)
            //        .HasMaxLength(300)
            //        .HasColumnName("DESCRIP");

            //    entity.Property(e => e.Dientich).HasColumnType("decimal(5, 2)");

            //    entity.Property(e => e.FullImage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Giagoc)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("GIAGOC");

            //    entity.Property(e => e.Huongbc)
            //        .HasMaxLength(50)
            //        .HasColumnName("HUONGBC");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idch).HasColumnName("IDCH");

            //    entity.Property(e => e.IdchungCu).HasColumnName("IDChungCu");

            //    entity.Property(e => e.PhongWc).HasColumnName("PhongWC");

            //    entity.Property(e => e.Tang).HasColumnName("TANG");

            //    entity.Property(e => e.ThumbnaiImage)
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.ToaChungcu).HasMaxLength(50);
            //});

            //modelBuilder.Entity<VDanhsachduanGetall>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_DANHSACHDUAN_GETALL");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("CREATEDATE");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Dientichsp)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("DIENTICHSP");

            //    entity.Property(e => e.Domain)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("domain");

            //    entity.Property(e => e.Giabanmin)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("GIABANMIN");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Idwo).HasColumnName("IDWO");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.Intupdate).HasColumnName("INTUPDATE");

            //    entity.Property(e => e.Linkweb)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("LINKWEB");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(300)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.OriginalUrl)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");
            //});

            //modelBuilder.Entity<VDatmuaGetall>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_DATMUA_GETALL");

            //    entity.Property(e => e.Datein)
            //        .HasColumnType("datetime")
            //        .HasColumnName("datein");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Diachiduan)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHIDUAN");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("EMAIL");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.Idstyle).HasColumnName("idstyle");

            //    entity.Property(e => e.IntActive).HasColumnName("intActive");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");

            //    entity.Property(e => e.Ten)
            //        .HasMaxLength(50)
            //        .HasColumnName("TEN");

            //    entity.Property(e => e.TenTt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TenTT");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tenkv)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENKV");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENQUAN");

            //    entity.Property(e => e.Thongtin)
            //        .HasMaxLength(300)
            //        .HasColumnName("THONGTIN");

            //    entity.Property(e => e.Title3).HasMaxLength(200);

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");
            //});

            //modelBuilder.Entity<VGetduanlienminhphanphoi>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_GETDUANLIENMINHPHANPHOI");

            //    entity.Property(e => e.Createdate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("CREATEDATE");

            //    entity.Property(e => e.IdKv).HasColumnName("ID_KV");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.Intactive).HasColumnName("INTACTIVE");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LAT");

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("LON");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(300)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Stt2).HasColumnName("stt2");

            //    entity.Property(e => e.Tencongty)
            //        .HasMaxLength(300)
            //        .HasColumnName("TENCONGTY");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");
            //});

            //modelBuilder.Entity<VGettinbymonth>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_GETTINBYMONTH");
            //});

            //modelBuilder.Entity<VListMobile>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_ListMobile");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("MOBILE");
            //});

            //modelBuilder.Entity<VLoaitinLoainha>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_LOAITIN_LOAINHA");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.TenLt)
            //        .HasMaxLength(40)
            //        .HasColumnName("TenLT");

            //    entity.Property(e => e.Tenln)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENLN");
            //});

            //modelBuilder.Entity<VNhaGetlistinvest>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_NHA_GETLISTINVEST");

            //    entity.Property(e => e.Avatar)
            //        .HasMaxLength(512)
            //        .IsUnicode(false)
            //        .HasColumnName("avatar");

            //    entity.Property(e => e.Fullname)
            //        .HasMaxLength(500)
            //        .HasColumnName("fullname");

            //    entity.Property(e => e.Header)
            //        .HasMaxLength(250)
            //        .HasColumnName("header");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.IdN).HasColumnName("id_n");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Info)
            //        .HasMaxLength(50)
            //        .HasColumnName("info");

            //    entity.Property(e => e.IsInvets).HasColumnName("isInvets");

            //    entity.Property(e => e.Mobile)
            //        .HasMaxLength(15)
            //        .HasColumnName("mobile");

            //    entity.Property(e => e.Tinhthanh)
            //        .HasMaxLength(50)
            //        .HasColumnName("_TINHTHANH");
            //});

            //modelBuilder.Entity<VNhagmap>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_NHAGMAP");

            //    entity.Property(e => e.ActionsmsId).HasColumnName("ActionsmsID");

            //    entity.Property(e => e.Contactinfo)
            //        .HasMaxLength(500)
            //        .HasColumnName("contactinfo");

            //    entity.Property(e => e.Dientich).HasColumnName("DIENTICH");

            //    entity.Property(e => e.Header).HasMaxLength(250);

            //    entity.Property(e => e.IdG).HasColumnName("ID_G");

            //    entity.Property(e => e.IdLn).HasColumnName("ID_LN");

            //    entity.Property(e => e.IdLt).HasColumnName("ID_LT");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.IdQq).HasColumnName("ID_QQ");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.IntDate).HasColumnName("intDate");

            //    entity.Property(e => e.Lat)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Lon)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Mode).HasColumnName("mode");

            //    entity.Property(e => e.Ngaydang).HasColumnType("datetime");

            //    entity.Property(e => e.Smstrue).HasColumnName("smstrue");

            //    entity.Property(e => e.Sotien).HasColumnName("SOTIEN");

            //    entity.Property(e => e.Tinvip).HasColumnName("tinvip");

            //    entity.Property(e => e.UrlPixbe)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("url_pixbe");
            //});

            //modelBuilder.Entity<VNumSm>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("v_numSMS");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.Ngaydang).HasColumnType("datetime");

            //    entity.Property(e => e.NumSms).HasColumnName("NumSMS");

            //    entity.Property(e => e.Smstrue).HasColumnName("smstrue");
            //});

            //modelBuilder.Entity<VNumSm1>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("v_numSMS", "nhadat24h");

            //    entity.Property(e => e.IdN).HasColumnName("id_n");

            //    entity.Property(e => e.Ngaydang)
            //        .HasColumnType("datetime")
            //        .HasColumnName("ngaydang");

            //    entity.Property(e => e.NumSms).HasColumnName("NumSMS");
            //});

            //modelBuilder.Entity<VQGet4sl>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_Q_GET4SL");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTk)
            //        .HasMaxLength(36)
            //        .HasColumnName("ID_TK");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENQUAN");
            //});

            //modelBuilder.Entity<VQGet4sl1>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("V_Q_GET4SL", "usnhadatvn");

            //    entity.Property(e => e.IdQ).HasColumnName("ID_Q");

            //    entity.Property(e => e.IdTk)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("ID_TK");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Tenquan)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENQUAN");
            //});

            //modelBuilder.Entity<VSmsGetNha>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("v_sms_getNHA", "nhadat24h");

            //    entity.Property(e => e.Message)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("message");
            //});

            //modelBuilder.Entity<VTemptinvipConhan>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_TEMPTINVIP_CONHAN");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");

            //    entity.Property(e => e.Tinvip).HasColumnName("tinvip");
            //});

            //modelBuilder.Entity<VTemptinvipHethan>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_TEMPTINVIP_HETHAN");

            //    entity.Property(e => e.IdN).HasColumnName("ID_N");
            //});

            //modelBuilder.Entity<VTimcanho>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("V_timcanho");

            //    entity.Property(e => e.Descrip)
            //        .HasMaxLength(300)
            //        .HasColumnName("DESCRIP");

            //    entity.Property(e => e.Tinhtrangcanho).HasMaxLength(50);

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(50)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<VTopduanmoinhat>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("v_topduanmoinhat");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("ID");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.IntHot).HasColumnName("intHot");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(100)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Tukhoa)
            //        .HasMaxLength(300)
            //        .HasColumnName("TUKHOA");
            //});

            //modelBuilder.Entity<VUserGetslTinDang>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("v_user_getslTinDang", "nhadat24h");

            //    entity.Property(e => e.IdU)
            //        .HasMaxLength(36)
            //        .IsUnicode(false)
            //        .HasColumnName("id_u");

            //    entity.Property(e => e.SlTin).HasColumnName("slTin");
            //});

            //modelBuilder.Entity<Video>(entity =>
            //{
            //    entity.ToTable("Video");

            //    entity.Property(e => e.DateCreate).HasColumnType("datetime");

            //    entity.Property(e => e.DateUpdate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(2000);

            //    entity.Property(e => e.Hashtag).HasMaxLength(500);

            //    entity.Property(e => e.Title).HasMaxLength(200);

            //    entity.Property(e => e.UrlVideo)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);
            //    entity.Property(e => e.UrlImage)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);
            //    entity.HasOne(d => d.IdCtvNavigation)
            //        .WithMany(p => p.Videos)
            //        .HasForeignKey(d => d.IdCtv)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Video_TBLCTVONLINE");
            //});

            //modelBuilder.Entity<View1>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("VIEW1");

            //    entity.Property(e => e.IdTt).HasColumnName("ID_TT");

            //    entity.Property(e => e.Sltin).HasColumnName("sltin");

            //    entity.Property(e => e.TenTt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TenTT");
            //});

            //modelBuilder.Entity<ViewGetChitietchungcuwidthImage>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("View_getChitietchungcuwidthImage");

            //    entity.Property(e => e.Diachi)
            //        .HasMaxLength(200)
            //        .HasColumnName("DIACHI");

            //    entity.Property(e => e.Dientich).HasColumnType("decimal(6, 2)");

            //    entity.Property(e => e.Expr1).HasMaxLength(50);

            //    entity.Property(e => e.Giagoc)
            //        .HasColumnType("decimal(5, 2)")
            //        .HasColumnName("GIAGOC");

            //    entity.Property(e => e.HuongBc).HasColumnName("HuongBC");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.IdduanUser).HasColumnName("IDDUAN_USER");

            //    entity.Property(e => e.Idsp).HasColumnName("IDSP");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.PhongWc).HasColumnName("PhongWC");

            //    entity.Property(e => e.Tenduan)
            //        .HasMaxLength(100)
            //        .HasColumnName("TENDUAN");

            //    entity.Property(e => e.Thumbnai)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("THUMBNAI");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");
            //});

            //modelBuilder.Entity<ViewGetSliderWobyIddum>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("View_getSliderWObyIDDA");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.Linkimage)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("LINKIMAGE");
            //});

            //modelBuilder.Entity<ViewTintucGetbyTagid>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("VIEW_TINTUC_GETBY_TAGID");

            //    entity.Property(e => e.Date)
            //        .HasColumnType("datetime")
            //        .HasColumnName("DATE");

            //    entity.Property(e => e.IdNt).HasColumnName("ID_NT");

            //    entity.Property(e => e.IdTin).HasColumnName("ID_TIN");

            //    entity.Property(e => e.Idtag).HasColumnName("IDTAG");

            //    entity.Property(e => e.NewLink)
            //        .HasMaxLength(300)
            //        .IsUnicode(false)
            //        .HasColumnName("newLink");

            //    entity.Property(e => e.Tennt)
            //        .HasMaxLength(50)
            //        .HasColumnName("TENNT");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(100)
            //        .HasColumnName("TITLE");

            //    entity.Property(e => e.Title2)
            //        .HasMaxLength(200)
            //        .HasColumnName("TITLE2");

            //    entity.Property(e => e.Tomtat)
            //        .HasColumnType("ntext")
            //        .HasColumnName("TOMTAT");

            //    entity.Property(e => e.UrlImage)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("URL_IMAGE");

            //    entity.Property(e => e.UrlThumbnai)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("URL_THUMBNAI");
            //});

            //modelBuilder.Entity<WebTblnhatkygiaodich>(entity =>
            //{
            //    entity.HasKey(e => e.Idnk);

            //    entity.ToTable("Web_tblnhatkygiaodich");

            //    entity.Property(e => e.Idnk).HasColumnName("IDNK");

            //    entity.Property(e => e.Giaodich).HasColumnType("ntext");

            //    entity.Property(e => e.Idn).HasColumnName("IDN");

            //    entity.Property(e => e.Inputer)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Intstatusread)
            //        .HasColumnName("INTSTATUSREAD")
            //        .HasDefaultValueSql("((1))");

            //    entity.Property(e => e.Ketqua).HasMaxLength(500);

            //    entity.Property(e => e.KhachHang).HasMaxLength(500);

            //    entity.Property(e => e.Thoigian)
            //        .HasColumnType("datetime")
            //        .HasColumnName("thoigian");
            //});

            //modelBuilder.Entity<WeboneclickGetbyclickview>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToView("WEBONECLICK_GETBYCLICKview");

            //    entity.Property(e => e.Domain)
            //        .HasMaxLength(100)
            //        .IsUnicode(false)
            //        .HasColumnName("domain");

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Idduan).HasColumnName("IDDUAN");

            //    entity.Property(e => e.Idu).HasColumnName("IDU");

            //    entity.Property(e => e.Image)
            //        .HasMaxLength(250)
            //        .IsUnicode(false)
            //        .HasColumnName("IMAGE");

            //    entity.Property(e => e.IntTheme).HasColumnName("intTheme");

            //    entity.Property(e => e.Mota)
            //        .HasMaxLength(148)
            //        .HasColumnName("MOTA");

            //    entity.Property(e => e.OriginalUrl)
            //        .HasMaxLength(500)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(55)
            //        .HasColumnName("TITLE");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
