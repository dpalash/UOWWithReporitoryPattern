namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Moved_OptionalFiles
    {
        [Key]
        [Column("_Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Id { get; set; }

        [Key]
        [Column("_Type", Order = 1)]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Column("_Number")]
        [StringLength(50)]
        public string C_Number { get; set; }

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

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
