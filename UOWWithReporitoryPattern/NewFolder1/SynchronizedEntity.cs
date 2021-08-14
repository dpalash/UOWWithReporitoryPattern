namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SynchronizedEntity
    {
        [Key]
        [StringLength(50)]
        public string EntityName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime LastSynchronized { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
