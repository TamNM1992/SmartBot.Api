using Microsoft.EntityFrameworkCore;
using SmartBot.DataAccess.Base;
using SmartBot.DataAccess.Entities;
using Action = SmartBot.DataAccess.Entities.Action;

namespace SmartBot.DataAccess.DBContext
{
    public partial class CommonDBContext : PDataContext
    {

        public CommonDBContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<AccountFb> AccountFbs { get; set; }

        public virtual DbSet<Action> Actions { get; set; }

        public virtual DbSet<ClassDatum> ClassData { get; set; }

        public virtual DbSet<ClientCustomer> ClientCustomers { get; set; }

        public virtual DbSet<ContentFb> ContentFbs { get; set; }

        public virtual DbSet<ContentTopic> ContentTopics { get; set; }

        public virtual DbSet<District> Districts { get; set; }

        public virtual DbSet<FaceBookGroup> FaceBookGroups { get; set; }

        public virtual DbSet<FaceBookPage> FaceBookPages { get; set; }

        public virtual DbSet<GroupFb> GroupFbs { get; set; }

        public virtual DbSet<ImagePath> ImagePaths { get; set; }

        public virtual DbSet<ImageTopic> ImageTopics { get; set; }

        public virtual DbSet<PageFb> PageFbs { get; set; }

        public virtual DbSet<PostGroup> PostGroups { get; set; }

        public virtual DbSet<Province> Provinces { get; set; }

        public virtual DbSet<Script> Scripts { get; set; }

        public virtual DbSet<Topic> Topics { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserClient> UserClients { get; set; }

        public virtual DbSet<UsersAccountFb> UsersAccountFbs { get; set; }

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

            modelBuilder.Entity<Action>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_ActionLike");

                entity.ToTable("Action");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.IdAccountFb).HasColumnName("IdAccountFB");
                entity.Property(e => e.Link)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAccountFbNavigation).WithMany(p => p.Actions)
                    .HasForeignKey(d => d.IdAccountFb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionLike_AccountFB");

                entity.HasOne(d => d.IdContentNavigation).WithMany(p => p.Actions)
                    .HasForeignKey(d => d.IdContent)
                    .HasConstraintName("FK_Action_ContentFB");

                entity.HasOne(d => d.IdScriptNavigation).WithMany(p => p.Actions)
                    .HasForeignKey(d => d.IdScript)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionLike_Script");
            });

            modelBuilder.Entity<ClassDatum>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<ClientCustomer>(entity =>
            {
                entity.ToTable("ClientCustomer");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.HardwareId)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContentFb>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_CommentFB");

                entity.ToTable("ContentFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.IdFaceBookNavigation).WithMany(p => p.ContentFbs)
                    .HasForeignKey(d => d.IdFaceBook)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentFB_AccountFB");
            });

            modelBuilder.Entity<ContentTopic>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_CommentTopic");

                entity.ToTable("ContentTopic");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdCommentNavigation).WithMany(p => p.ContentTopics)
                    .HasForeignKey(d => d.IdComment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentTopic_CommentFB");

                entity.HasOne(d => d.IdTopicNavigation).WithMany(p => p.ContentTopics)
                    .HasForeignKey(d => d.IdTopic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentTopic_Topic");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.KeyWord).HasMaxLength(100);
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdProvinceNavigation).WithMany(p => p.Districts)
                    .HasForeignKey(d => d.IdProvince)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_Province");
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

                entity.Property(e => e.Path).HasMaxLength(1000);

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.ImagePaths)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImagePath_ClientCustomer");
            });

            modelBuilder.Entity<ImageTopic>(entity =>
            {
                entity.ToTable("ImageTopic");

                entity.HasOne(d => d.IdImageNavigation).WithMany(p => p.ImageTopics)
                    .HasForeignKey(d => d.IdImage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageTopic_ImagePath");

                entity.HasOne(d => d.IdTopicNavigation).WithMany(p => p.ImageTopics)
                    .HasForeignKey(d => d.IdTopic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageTopic_Topic");
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

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.KeyWord).HasMaxLength(100);
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.ToTable("Script");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.KeyWord).HasMaxLength(50);
                entity.Property(e => e.Topic1)
                    .HasMaxLength(50)
                    .HasColumnName("Topic");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");
                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.License)
                    .HasMaxLength(100)
                    .IsFixedLength();
                entity.Property(e => e.Password).HasMaxLength(20);
                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<UserClient>(entity =>
            {
                entity.ToTable("UserClient");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.UserClients)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClient_ClientCustomer");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserClients)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClient_Users");
            });

            modelBuilder.Entity<UsersAccountFb>(entity =>
            {
                entity.ToTable("UsersAccountFB");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");
                entity.Property(e => e.IdAccountFb).HasColumnName("IdAccountFB");

                entity.HasOne(d => d.IdAccountFbNavigation).WithMany(p => p.UsersAccountFbs)
                    .HasForeignKey(d => d.IdAccountFb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAccountFB_AccountFB");

                entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UsersAccountFbs)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersAccountFB_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
