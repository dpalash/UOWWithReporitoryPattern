namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class log_sentfiles
    {
        [Key]
        [Column("_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_id { get; set; }

        [Key]
        [Column("_customerID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_customerID { get; set; }

        [Column("_ntmID")]
        public long? C_ntmID { get; set; }

        [Column("_optfileID")]
        public int? C_optfileID { get; set; }

        [Key]
        [Column("_filename", Order = 2)]
        [StringLength(255)]
        public string C_filename { get; set; }

        [Key]
        [Column("_sentasemail", Order = 3)]
        public bool C_sentasemail { get; set; }

        [Key]
        [Column("_requesttime", Order = 4, TypeName = "smalldatetime")]
        public DateTime C_requesttime { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
