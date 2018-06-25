namespace SocialMedia.Data.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Data.Models;

    public class SocialMediaDbContext : IdentityDbContext<User>
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Follower> Followers { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Follower>()
                .HasKey(f => new { f.FollowedId, f.UserId });

            builder
                .Entity<User>()
                .HasMany(u => u.Albums)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId);

            builder
                .Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Picture>()
                .HasMany(u => u.Comments)
                .WithOne(u => u.Picture)
                .HasForeignKey(u => u.PictureId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Album>()
                .HasMany(u => u.Pictures)
                .WithOne(u => u.Album)
                .HasForeignKey(u => u.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<User>()
               .HasMany(u => u.Pictures)
               .WithOne(u => u.Owner)
               .HasForeignKey(u => u.OwnerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<User>()
                .HasMany(u => u.MessagesReceive)
                .WithOne(u => u.Recipient)
                .HasForeignKey(u => u.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<User>()
                .HasMany(u => u.MessagesSend)
                .WithOne(u => u.Sender)
                .HasForeignKey(u => u.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<User>()
               .HasMany(u => u.Followers)
               .WithOne(u => u.Followed)
               .HasForeignKey(u => u.FollowedId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<User>()
               .HasMany(u => u.Followed)
               .WithOne(u => u.User)
               .HasForeignKey(u => u.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
