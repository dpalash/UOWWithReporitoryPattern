namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_group
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public short? type { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
