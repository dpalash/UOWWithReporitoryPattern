namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OptionalFile
    {
        [Key]
        [Column("_Id", Order = 0)]
        public int C_Id { get; set; }

        [Key]
        [Column("_Type", Order = 1)]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Column("_Number")]
        [StringLength(50)]
        public string C_Number { get; set; }

        [Column("_NauProdID")]
        [StringLength(50)]
        public string C_NauProdID { get; set; }

        [Key]
        [Column("_Path", Order = 2)]
        [StringLength(150)]
        public string C_Path { get; set; }

        [Key]
        [Column("_Week", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Week { get; set; }

        [Key]
        [Column("_Year", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Year { get; set; }

        [Column("_Page")]
        [StringLength(10)]
        public string C_Page { get; set; }

        [Key]
        [Column("_Added", Order = 5)]
        public DateTime C_Added { get; set; }

        [Key]
        [Column("_Active", Order = 6)]
        public bool C_Active { get; set; }

        [Key]
        [Column("_IssuerID", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_IssuerID { get; set; }

        [Column("_EndPage")]
        [StringLength(10)]
        public string C_EndPage { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
