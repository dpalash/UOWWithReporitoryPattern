namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class package_open
    {
        public int id { get; set; }

        public int? sid { get; set; }

        public int? pid { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
