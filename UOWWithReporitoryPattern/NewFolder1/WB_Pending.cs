namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WB_Pending
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string StartPage { get; set; }

        [Required]
        [StringLength(10)]
        public string EndPage { get; set; }

        public int Section { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
