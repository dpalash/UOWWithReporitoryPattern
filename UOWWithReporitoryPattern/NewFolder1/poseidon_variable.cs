namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_variable
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(100)]
        public string value { get; set; }

        public int? userid { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
