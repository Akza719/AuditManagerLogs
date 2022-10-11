using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DomainLayer
{
    public partial class AuditLogContext : DbContext
    {
        public AuditLogContext()
            : base("name=AuditLogContext")
        {
        }

        public virtual DbSet<Log4NetLog> Log4NetLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Thread)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Logger)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Exception)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<Log4NetLog>()
                .Property(e => e.Path)
                .IsUnicode(false);
        }
    }
}
