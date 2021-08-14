namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_flag
    {
        public int id { get; set; }

        public int flag { get; set; }

        public int n1 { get; set; }

        public int n2 { get; set; }

        public int userid { get; set; }

        public int position { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
