using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class SqlDbContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder
                .UseSqlServer(connStr)
#if DEBUG
                .EnableSensitiveDataLogging(true)
                .LogTo
                   (
                       (id, level) => level == LogLevel.Error,            //过滤条件
                        log => Console.WriteLine(log)   //如何记录log
                    );
#endif
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>
                (
                e =>
                {
                    e.ToTable("Register").HasKey("Name");
                    e.Property("Name")
                       .HasColumnName("UserName")
                       .HasMaxLength(256);
                    e.Property("Password").IsRequired(true);
                    e.Ignore("FailedTry");
                    e.HasIndex(x => x.CreateTime).IsUnique();
                    e.HasCheckConstraint(
                        "CK_CreateTime",
                        "CreateTime Between '2000/1/1' AND '2999/12/31'");
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }



}
