namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ntm_BR
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int Edition { get; set; }

        [Required]
        [StringLength(500)]
        public string Path { get; set; }

        public DateTime? AddedOnUtc { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
