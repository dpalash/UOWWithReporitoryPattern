namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncBaseCDCoverage")]
    public partial class EncBaseCDCoverage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BaseCD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string CountryCodes { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
