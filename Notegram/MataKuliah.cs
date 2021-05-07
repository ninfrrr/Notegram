namespace Notegram
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MataKuliah")]
    public partial class MataKuliah
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        public int Hari { get; set; }

        public TimeSpan Jam_Mulai { get; set; }

        public TimeSpan Jam_Selesai { get; set; }

        [StringLength(20)]
        public string Warna { get; set; }
    }
}
