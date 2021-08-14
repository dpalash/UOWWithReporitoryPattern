namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class activesubscriptions_backup
    {
        [Key]
        [Column("_Id")]
        public int C_Id { get; set; }

        [Column("_CustomerId")]
        public int C_CustomerId { get; set; }

        [Column("_ShipName")]
        [StringLength(100)]
        public string C_ShipName { get; set; }

        [Column("_NauProdID")]
        [Required]
        [StringLength(50)]
        public string C_NauProdID { get; set; }

        [Column("_IssuerID")]
        public int C_IssuerID { get; set; }

        [Column("_Type")]
        [Required]
        [StringLength(50)]
        public string C_Type { get; set; }

        [Column("_ChartNumber")]
        [Required]
        [StringLength(50)]
        public string C_ChartNumber { get; set; }

        [Column("_Added", TypeName = "smalldatetime")]
        public DateTime C_Added { get; set; }

        [Column("_Removed", TypeName = "smalldatetime")]
        public DateTime? C_Removed { get; set; }

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
        public int? C_SubStatus { get; set; }

        [Column("_eNTMSubCode")]
        public int? C_eNTMSubCode { get; set; }

        [Column("_CustNotifiedAdded", TypeName = "smalldatetime")]
        public DateTime? C_CustNotifiedAdded { get; set; }

        [Column("_CustNotifiedRemoved", TypeName = "smalldatetime")]
        public DateTime? C_CustNotifiedRemoved { get; set; }

        [Column("_UniqueVBValue")]
        [StringLength(255)]
        public string C_UniqueVBValue { get; set; }

        [Column("_EditionDate")]
        public DateTime? C_EditionDate { get; set; }

        [Column("_VBEditionDate")]
        [StringLength(50)]
        public string C_VBEditionDate { get; set; }

        [Column("_TransferredDate")]
        public DateTime? C_TransferredDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
