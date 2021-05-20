using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Notegram
{
    public partial class NotegramDBModel : DbContext
    {
        public NotegramDBModel()
            : base("name=NgDBModel")
        {
        }

        public virtual DbSet<MataKuliah> MataKuliahs { get; set; }

        public virtual DbSet<ToDoList> ToDoList { get; set; }
        //public virtual DbSet<ClassLibrary1.ToDoLists> ToDoLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
