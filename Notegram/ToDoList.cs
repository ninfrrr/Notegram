namespace Notegram
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToDoList")]
    public partial class ToDoList
    {
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime DueDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(500)]
        public string Task { get; set; }

        [Required]
        [StringLength(100)]
        public string Course { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
