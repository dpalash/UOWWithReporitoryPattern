namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Moved_XmlNTMData
    {
        [Key]
        [Column("_Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long C_Id { get; set; }

        [Key]
        [Column("_PrimaryKey", Order = 1)]
        [StringLength(50)]
        public string C_PrimaryKey { get; set; }

        [Column("_PubDate", TypeName = "smalldatetime")]
        public DateTime? C_PubDate { get; set; }

        [Key]
        [Column("_IssuerID", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_IssuerID { get; set; }

        [Column("_Type")]
        [StringLength(20)]
        public string C_Type { get; set; }

        [Key]
        [Column("_Week", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Week { get; set; }

        [Key]
        [Column("_NMNumber", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_NMNumber { get; set; }

        [Key]
        [Column("_Year", Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Year { get; set; }

        [Key]
        [Column("_ChartNumber", Order = 6)]
        [StringLength(50)]
        public string C_ChartNumber { get; set; }

        [Column("_areacode")]
        public int? C_areacode { get; set; }

        [Column("_region")]
        [StringLength(255)]
        public string C_region { get; set; }

        [Column("_sub_region")]
        [StringLength(255)]
        public string C_sub_region { get; set; }

        [Column("_vicinities")]
        [StringLength(255)]
        public string C_vicinities { get; set; }

        [Column("_feature_types")]
        [StringLength(255)]
        public string C_feature_types { get; set; }

        [Column("_light_list")]
        [StringLength(255)]
        public string C_light_list { get; set; }

        [Column("_authority")]
        [StringLength(255)]
        public string C_authority { get; set; }

        [Column("_note")]
        [StringLength(2000)]
        public string C_note { get; set; }

        [Key]
        [Column("_Ident", Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Ident { get; set; }

        [Key]
        [Column("_FolioNumber", Order = 8)]
        [StringLength(50)]
        public string C_FolioNumber { get; set; }

        [Column("_LastUpdateNM")]
        public int? C_LastUpdateNM { get; set; }

        [Column("_LastUpdateDate", TypeName = "smalldatetime")]
        public DateTime? C_LastUpdateDate { get; set; }

        [Column("_XML", TypeName = "image")]
        public byte[] C_XML { get; set; }

        [Column("_GraphicsPath")]
        [StringLength(4000)]
        public string C_GraphicsPath { get; set; }

        [Column("_LowresPath")]
        [StringLength(4000)]
        public string C_LowresPath { get; set; }

        [Column("_SuperLowresPath")]
        [StringLength(4000)]
        public string C_SuperLowresPath { get; set; }

        [Column("_NewEdition")]
        public bool? C_NewEdition { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
