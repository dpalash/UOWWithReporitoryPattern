namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rssNew
    {
        [Key]
        [Column("_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_ID { get; set; }

        [Key]
        [Column("_Publisher", Order = 1)]
        [StringLength(255)]
        public string C_Publisher { get; set; }

        [Key]
        [Column("_Category", Order = 2)]
        [StringLength(255)]
        public string C_Category { get; set; }

        [Key]
        [Column("_Region", Order = 3)]
        [StringLength(255)]
        public string C_Region { get; set; }

        [Key]
        [Column("_rssURL", Order = 4)]
        [StringLength(255)]
        public string C_rssURL { get; set; }

        [Column("_Content", TypeName = "text")]
        public string C_Content { get; set; }

        [Key]
        [Column("_FeedFileName", Order = 5)]
        [StringLength(255)]
        public string C_FeedFileName { get; set; }

        [Column("_Updated")]
        public DateTime? C_Updated { get; set; }

        [Key]
        [Column("_Added", Order = 6)]
        public DateTime C_Added { get; set; }

        [Key]
        [Column("_Active", Order = 7)]
        public bool C_Active { get; set; }

        [Key]
        [Column("_ActiveChanged", Order = 8)]
        public DateTime C_ActiveChanged { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
