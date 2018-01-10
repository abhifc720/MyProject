using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testNetCore.Models
{
    public partial class rtmcomContext : DbContext
    {
        public virtual DbSet<AandroidConversion> AandroidConversion { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountUser> AccountUser { get; set; }
        public virtual DbSet<Apikey> Apikey { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<EmailList> EmailList { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<EmailTracking> EmailTracking { get; set; }
        public virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberPromotion> MemberPromotion { get; set; }
        public virtual DbSet<OptOut> OptOut { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<Prize> Prize { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Share> Share { get; set; }
        public virtual DbSet<ShareTracking> ShareTracking { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }
        public virtual DbSet<Winner> Winner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=RI-9\sqlexpress;Database=rtmcom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AandroidConversion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Node)
                    .HasColumnName("node")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("nchar(255)");

                entity.Property(e => e.ParentAccountId).HasColumnName("parentAccountId");
            });

            modelBuilder.Entity<AccountUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Apikey>(entity =>
            {
                entity.ToTable("APIKey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.ApiKey).HasColumnName("apiKey");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Phaseid).HasColumnName("phaseid");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code1).HasColumnName("code");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUsed)
                    .HasColumnName("dateUsed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Grouping).HasColumnName("grouping");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valid).HasColumnName("valid");
            });

            modelBuilder.Entity<EmailList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("emailAddress")
                    .HasMaxLength(512);

                entity.Property(e => e.EmailTemplateId).HasColumnName("emailTemplateId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUsed)
                    .HasColumnName("dateUsed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Grouping).HasColumnName("grouping");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(78)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Valid).HasColumnName("valid");
            });

            modelBuilder.Entity<EmailTracking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("emailAddress")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTemplateId).HasColumnName("emailTemplateId");

                entity.Property(e => e.Event)
                    .HasColumnName("event")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EventTs)
                    .HasColumnName("eventTs")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalTrackingId)
                    .HasColumnName("externalTrackingId")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EntryType)
                    .HasColumnName("entryType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.PhaseId).HasColumnName("phaseId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.PromotionMemberId).HasColumnName("promotionMemberId");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("passwordHash")
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberPromotion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.ShareId).HasColumnName("shareId");
            });

            modelBuilder.Entity<OptOut>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntriesPerDay)
                    .HasColumnName("entriesPerDay")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phase1)
                    .HasColumnName("phase")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalEntriesPhase)
                    .HasColumnName("totalEntriesPhase")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Prize>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseId).HasColumnName("phaseId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentPromotionid).HasColumnName("parentPromotionid");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Share>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("emailaddress")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.PromotionMemberId).HasColumnName("promotionMemberId");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(2048);

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasMaxLength(2048);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShareTracking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClickDate)
                    .HasColumnName("clickDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.ShareId).HasColumnName("shareId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("passwordHash")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("dateEntered")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EntryId).HasColumnName("entryId");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.Phaseid).HasColumnName("phaseid");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");
            });

            modelBuilder.Entity<Winner>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(512);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRedeemed)
                    .HasColumnName("dateRedeemed")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnName("detail");

                entity.Property(e => e.EntryId).HasColumnName("entryId");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.PlayedTime)
                    .HasColumnName("playedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrizeId).HasColumnName("prizeId");

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WinTime)
                    .HasColumnName("winTime")
                    .HasColumnType("datetime");
            });
        }
    }
}
