namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilesAddedDate")]
    public partial class FilesAddedDate
    {
        [Key]
        [Column(Order = 0)]
        public string FilePath { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime AddedDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
