namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class document_types
    {
        [Key]
        [Column("_Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Id { get; set; }

        [Key]
        [Column("_Type", Order = 1)]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Key]
        [Column("_FilePart", Order = 2)]
        [StringLength(20)]
        public string C_FilePart { get; set; }

        [Key]
        [Column("_Startpos", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Startpos { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
