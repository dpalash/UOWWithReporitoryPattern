namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_custom_userinformation
    {
        public int id { get; set; }

        public int? customerid { get; set; }

        [Column(TypeName = "text")]
        public string phone { get; set; }

        [Column(TypeName = "text")]
        public string email { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
