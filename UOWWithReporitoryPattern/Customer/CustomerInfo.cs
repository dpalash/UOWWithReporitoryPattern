namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerInfo")]
    public partial class CustomerInfo
    {
        [Key]
        [Column("_ID", Order = 0)]
        public int C_ID { get; set; }

        [Key]
        [Column("_customerID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_customerID { get; set; }

        [Key]
        [Column("_ShipName", Order = 2)]
        [StringLength(100)]
        public string C_ShipName { get; set; }

        [Key]
        [Column("_NeptuneCode", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_NeptuneCode { get; set; }

        [Key]
        [Column("_InfoDate", Order = 4, TypeName = "smalldatetime")]
        public DateTime C_InfoDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
