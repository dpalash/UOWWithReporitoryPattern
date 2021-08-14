namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PackageOpen
    {
        public int SessionID { get; set; }

        public int PackageID { get; set; }

        [Key]
        public int PackageOpensID { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Package1 Package { get; set; }

        public virtual Session1 Session { get; set; }
    }
}
