namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerEcdi
    {
        public int Id { get; set; }

        [Required]
        [StringLength(28)]
        public string UserPermit { get; set; }

        public int EcdisTypeId { get; set; }

        public int CustomerId { get; set; }

        public DateTime ChangedAt { get; set; }

        public int PermitVersion { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        public virtual EcdisType EcdisType { get; set; }
    }
}
