namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("package")]
    public partial class package
    {
        [Key]
        public int pid { get; set; }

        public int? sid { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        [Column(TypeName = "text")]
        public string arguments { get; set; }

        public int? size { get; set; }

        public int? files { get; set; }

        public int? ntms { get; set; }

        public DateTime? date { get; set; }

        [Required]
        [StringLength(50)]
        public string pkey { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
