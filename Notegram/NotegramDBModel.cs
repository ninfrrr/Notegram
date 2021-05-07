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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
