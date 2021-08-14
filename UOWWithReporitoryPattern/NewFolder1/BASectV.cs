namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BASectV")]
    public partial class BASectV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BA_Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NauProdID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
