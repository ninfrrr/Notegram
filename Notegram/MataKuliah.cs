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
        [Key]
        [StringLength(50)]
        public string Nama { get; set; }

        public int Hari_ID { get; set; }

        [Required]
        [StringLength(6)]
        public string Hari { get; set; }

        public TimeSpan Jam_Mulai { get; set; }

        public TimeSpan Jam_Selesai { get; set; }

        [StringLength(20)]
        public string Warna { get; set; }
    }
}
