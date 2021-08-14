namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomersInmarsatProvider
    {
        public int Id { get; set; }

        public int CustPosProvId { get; set; }

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

        public int PollInterval { get; set; }

        public bool IsActivated { get; set; }

        public bool IsProgramming { get; set; }

        public DateTime LastModifiedUtc { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual CustomersPositionProvider CustomersPositionProvider { get; set; }
    }
}
