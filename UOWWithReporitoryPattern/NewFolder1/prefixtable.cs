namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prefixtable")]
    public partial class prefixtable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column("_Prefix", Order = 1)]
        [StringLength(50)]
        public string C_Prefix { get; set; }

        [Key]
        [Column("_IssuerPrefix", Order = 2)]
        [StringLength(50)]
        public string C_IssuerPrefix { get; set; }

        [Key]
        [Column("_Type", Order = 3)]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Column("_Description")]
        [StringLength(100)]
        public string C_Description { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
