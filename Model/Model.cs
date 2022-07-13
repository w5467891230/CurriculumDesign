using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelConn")
        {
        }

        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<BookInfo> BookInfoes { get; set; }
        public virtual DbSet<bookOut> bookOuts { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<identityinfo> identityinfoes { get; set; }
        public virtual DbSet<manager> managers { get; set; }
        public virtual DbSet<NewBookInfo> NewBookInfoes { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<ReaderInfo> ReaderInfoes { get; set; }
        public virtual DbSet<ReaderType> ReaderTypes { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<Type> types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.BookID)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.BookName)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.BookBarCode)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.BookType)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.TotalNum)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.StorPosion)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.Press)
                .IsFixedLength();

            modelBuilder.Entity<NewBookInfo>()
                .Property(e => e.Author)
                .IsFixedLength();
        }
    }
}
