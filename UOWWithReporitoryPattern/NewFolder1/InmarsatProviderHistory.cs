namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InmarsatProviderHistory")]
    public partial class InmarsatProviderHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public short Region { get; set; }

        [Required]
        [StringLength(255)]
        public string DNID { get; set; }

        [Required]
        [StringLength(255)]
        public string MemberNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string TerminalId { get; set; }

        [Required]
        [StringLength(255)]
        public string PollInterval { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime AuditUtcDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
