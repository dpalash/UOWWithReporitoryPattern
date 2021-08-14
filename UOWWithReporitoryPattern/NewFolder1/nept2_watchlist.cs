namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_watchlist
    {
        public int id { get; set; }

        public int? userid { get; set; }

        public int? customer { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
