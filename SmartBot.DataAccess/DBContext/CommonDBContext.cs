using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Base;
using SmartBot.DataAccess.Entities;

namespace SmartBot.DataAccess.DBContext
{
    public partial class CommonDBContext : PDataContext
    {
        public CommonDBContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<AccountFb> AccountFbs { get; set; }

        public virtual DbSet<ClassDatum> ClassData { get; set; }

        public virtual DbSet<CommentFb> CommentFbs { get; set; }

        public virtual DbSet<FaceBookGroup> FaceBookGroups { get; set; }

        public virtual DbSet<FaceBookPage> FaceBookPages { get; set; }

        public virtual DbSet<GroupFb> GroupFbs { get; set; }

        public virtual DbSet<ImagePath> ImagePaths { get; set; }

        public virtual DbSet<PageFb> PageFbs { get; set; }

        public virtual DbSet<PostFb> PostFbs { get; set; }

        public virtual DbSet<PostGroup> PostGroups { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountFb>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_FaceBookAccount");

                entity.ToTable("AccountFB");

                entity.Property(e => e.DateLogin).HasColumnType("datetime");
                entity.Property(e => e.FbPassword).HasMaxLength(20);
                entity.Property(e => e.FbProfileLink)
                    .HasMaxLength(512)
                    .IsUnicode(false);
                entity.Property(e => e.FbUser).HasMaxLength(50);
                entity.Property(e => e.KeySearch).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassDatum>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<CommentFb>(entity =>
            {
                entity.ToTable("CommentFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.IdFaceBookNavigation).WithMany(p => p.CommentFbs)
                    .HasForeignKey(d => d.IdFaceBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentFB_AccountFB");

                entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.CommentFbs)
                    .HasForeignKey(d => d.IdImage)
                    .HasConstraintName("FK_CommentFB_ImagePath");
            });

            modelBuilder.Entity<FaceBookGroup>(entity =>
            {
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.IdGroupFb).HasColumnName("IdGroupFB");

                entity.HasOne(d => d.IdFaceBookNavigation).WithMany(p => p.FaceBookGroups)
                    .HasForeignKey(d => d.IdFaceBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaceBookGroups_AccountFB");

                entity.HasOne(d => d.IdGroupFbNavigation).WithMany(p => p.FaceBookGroups)
                    .HasForeignKey(d => d.IdGroupFb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaceBookGroups_GroupFB");
            });

            modelBuilder.Entity<FaceBookPage>(entity =>
            {
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.IdPageFb).HasColumnName("IdPageFB");

                entity.HasOne(d => d.IdFaceBookNavigation).WithMany(p => p.FaceBookPages)
                    .HasForeignKey(d => d.IdFaceBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaceBookPages_AccountFB");

                entity.HasOne(d => d.IdPageFbNavigation).WithMany(p => p.FaceBookPages)
                    .HasForeignKey(d => d.IdPageFb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaceBookPages_PageFB");
            });

            modelBuilder.Entity<GroupFb>(entity =>
            {
                entity.ToTable("GroupFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Name).HasMaxLength(256);
                entity.Property(e => e.Type).HasMaxLength(100);
                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImagePath>(entity =>
            {
                entity.ToTable("ImagePath");

                entity.Property(e => e.HardwareId).HasMaxLength(100);
                entity.Property(e => e.Path).HasMaxLength(1000);

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.ImagePaths)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImagePath_Users");
            });

            modelBuilder.Entity<PageFb>(entity =>
            {
                entity.ToTable("PageFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.Distance).HasMaxLength(100);
                entity.Property(e => e.Name).HasMaxLength(200);
                entity.Property(e => e.NumPostPerDay).HasMaxLength(100);
                entity.Property(e => e.Price).HasMaxLength(100);
                entity.Property(e => e.Rate).HasMaxLength(100);
                entity.Property(e => e.Status).HasMaxLength(100);
                entity.Property(e => e.Type).HasMaxLength(100);
                entity.Property(e => e.Url)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PostFb>(entity =>
            {
                entity.ToTable("PostFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.IdFaceBookNavigation).WithMany(p => p.PostFbs)
                    .HasForeignKey(d => d.IdFaceBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostFB_AccountFB");
            });

            modelBuilder.Entity<PostGroup>(entity =>
            {
                entity.ToTable("PostGroup");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Url).HasMaxLength(1000);

                entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.PostGroups)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostGroup_GroupFB");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.HardwareId).HasMaxLength(100);
                entity.Property(e => e.License)
                    .HasMaxLength(100)
                    .IsFixedLength();
                entity.Property(e => e.Password).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
