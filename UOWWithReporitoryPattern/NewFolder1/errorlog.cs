namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("errorlog")]
    public partial class errorlog
    {
        [Key]
        [Column("_Id")]
        public long C_Id { get; set; }

        [Column("_Added")]
        public DateTime? C_Added { get; set; }

        [Column("_Where")]
        public string C_Where { get; set; }

        [Column("_What")]
        public string C_What { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
