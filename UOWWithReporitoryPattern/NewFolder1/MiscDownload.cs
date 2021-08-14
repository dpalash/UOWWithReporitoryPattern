namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MiscDownload
    {
        public int Id { get; set; }

        [Column(TypeName = "ntext")]
        public string FilePath { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeDescription { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
