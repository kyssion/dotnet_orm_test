using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace efcore_test.modules;

public partial class KMediaPlatformContext : DbContext
{
    public KMediaPlatformContext()
    {
    }

    public KMediaPlatformContext(DbContextOptions<KMediaPlatformContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MediaResource> MediaResources { get; set; }

    public virtual DbSet<MediaResourceNovel> MediaResourceNovels { get; set; }

    public virtual DbSet<MediaResourceNovelCategory> MediaResourceNovelCategories { get; set; }

    public virtual DbSet<MediaResourceNovelChapter> MediaResourceNovelChapters { get; set; }

    public virtual DbSet<MediaResourceNovelLabel> MediaResourceNovelLabels { get; set; }

    public virtual DbSet<MediaUser> MediaUsers { get; set; }

    public virtual DbSet<MediaUserAuthorization> MediaUserAuthorizations { get; set; }

    public virtual DbSet<MediaUserCrossPlatform> MediaUserCrossPlatforms { get; set; }

    public virtual DbSet<MediaUserPersonalise> MediaUserPersonalises { get; set; }

    public virtual DbSet<UserLoginHistory> UserLoginHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=39.100.86.193;Username=postgres;Password=Javarustc++11.;Database=k_media_platform;Pooling=true;Maximum Pool Size=50");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MediaResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_resources_pkey");

            entity.ToTable("media_resources");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.ResouceId).HasColumnName("resouce_id");
            entity.Property(e => e.ResouceProvider).HasColumnName("resouce_provider");
            entity.Property(e => e.ResourceDescription)
                .HasMaxLength(600)
                .HasColumnName("resource_description");
            entity.Property(e => e.ResourceName)
                .HasColumnType("character varying")
                .HasColumnName("resource_name");
            entity.Property(e => e.ResourceType).HasColumnName("resource_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MediaResourceNovel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("media_resource_novel");

            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.Category)
                .HasColumnType("jsonb")
                .HasColumnName("category");
            entity.Property(e => e.ContentSummary)
                .HasMaxLength(1000)
                .HasColumnName("content_summary");
            entity.Property(e => e.CoverImage)
                .HasColumnType("character varying")
                .HasColumnName("cover_image");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Label)
                .HasColumnType("jsonb")
                .HasColumnName("label");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PublicationInformation)
                .HasColumnType("jsonb")
                .HasColumnName("publication_information");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
            entity.Property(e => e.WordCount).HasColumnName("word_count");
        });

        modelBuilder.Entity<MediaResourceNovelCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_resource_novel_category_pkey");

            entity.ToTable("media_resource_novel_category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .HasColumnName("category_name");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.ParentCategory).HasColumnName("parent_category");
            entity.Property(e => e.ResourceType).HasColumnName("resource_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MediaResourceNovelChapter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_resource_novel_chapter_pkey");

            entity.ToTable("media_resource_novel_chapter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChapterNo).HasColumnName("chapter_no");
            entity.Property(e => e.ChapterSummary)
                .HasMaxLength(600)
                .HasColumnName("chapter_summary");
            entity.Property(e => e.ChapterTitle)
                .HasMaxLength(200)
                .HasColumnName("chapter_title");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.NovelId).HasColumnName("novel_id");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MediaResourceNovelLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_resource_novel_label_pkey");

            entity.ToTable("media_resource_novel_label");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.LabeCategory)
                .HasColumnType("jsonb")
                .HasColumnName("labe_category");
            entity.Property(e => e.LabelName)
                .HasMaxLength(100)
                .HasColumnName("label_name");
            entity.Property(e => e.ResourceType).HasColumnName("resource_type");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MediaUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_user_pkey");

            entity.ToTable("media_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId)
                .HasMaxLength(100)
                .HasColumnName("account_id");
            entity.Property(e => e.CoreUserId).HasColumnName("core_user_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(100)
                .HasColumnName("phone_number");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<MediaUserAuthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_user_authorization_pkey");

            entity.ToTable("media_user_authorization");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorizationConfig)
                .HasColumnType("jsonb")
                .HasColumnName("authorization_config");
            entity.Property(e => e.CoreUserId).HasColumnName("core_user_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.PlatformId).HasColumnName("platform_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<MediaUserCrossPlatform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_user_cross_platform_pkey");

            entity.ToTable("media_user_cross_platform");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CoreUserId).HasColumnName("core_user_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.PlatformId).HasColumnName("platform_id");
            entity.Property(e => e.PlatformInformation)
                .HasColumnType("jsonb")
                .HasColumnName("platform_information");
            entity.Property(e => e.PlatformUserId)
                .HasColumnType("character varying")
                .HasColumnName("platform_user_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<MediaUserPersonalise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("media_user_personalise_pkey");

            entity.ToTable("media_user_personalise");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CoreUserId).HasColumnName("core_user_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Introduction).HasColumnName("introduction");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Portrait)
                .HasMaxLength(100)
                .HasColumnName("portrait");
            entity.Property(e => e.Region).HasColumnName("region");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserLoginHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_login_history_pkey");

            entity.ToTable("user_login_history");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CoreUserId).HasColumnName("core_user_id");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time");
            entity.Property(e => e.DeviceInfo)
                .HasColumnType("jsonb")
                .HasColumnName("device_info");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.LoginIpv4)
                .HasMaxLength(100)
                .HasColumnName("login_ipv4");
            entity.Property(e => e.LoginIpv6)
                .HasMaxLength(100)
                .HasColumnName("login_ipv6");
            entity.Property(e => e.LoginTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("login_time");
            entity.Property(e => e.LoginType).HasColumnName("login_type");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Os).HasColumnName("os");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
