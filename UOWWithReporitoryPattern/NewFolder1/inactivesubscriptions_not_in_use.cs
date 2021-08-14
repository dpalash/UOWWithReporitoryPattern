namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inactivesubscriptions_not_in_use
    {
        [Key]
        [Column("_Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_Id { get; set; }

        [Key]
        [Column("_CustomerID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_CustomerID { get; set; }

        [Key]
        [Column("_NauProdID", Order = 2)]
        [StringLength(50)]
        public string C_NauProdID { get; set; }

        [Key]
        [Column("_IssuerID", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_IssuerID { get; set; }

        [Key]
        [Column("_Type", Order = 4)]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Key]
        [Column("_ChartNumber", Order = 5)]
        [StringLength(50)]
        public string C_ChartNumber { get; set; }

        [Key]
        [Column("_Added", Order = 6, TypeName = "smalldatetime")]
        public DateTime C_Added { get; set; }

        [Key]
        [Column("_Removed", Order = 7, TypeName = "smalldatetime")]
        public DateTime C_Removed { get; set; }

        [Column("_Description")]
        [StringLength(255)]
        public string C_Description { get; set; }

        [Column("_ShipEd")]
        public int? C_ShipEd { get; set; }

        [Column("_CurrentEd")]
        public int? C_CurrentEd { get; set; }

        [Column("_Sent", TypeName = "smalldatetime")]
        public DateTime? C_Sent { get; set; }

        [Column("_Antall")]
        public int? C_Antall { get; set; }

        [Column("_SubStatus")]
        [StringLength(50)]
        public string C_SubStatus { get; set; }

        [Column("_CustNotified", TypeName = "smalldatetime")]
        public DateTime? C_CustNotified { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
