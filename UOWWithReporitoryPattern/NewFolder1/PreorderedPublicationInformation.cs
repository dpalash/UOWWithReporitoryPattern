namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreorderedPublicationInformation")]
    public partial class PreorderedPublicationInformation
    {
        public long Id { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }
    }
}
