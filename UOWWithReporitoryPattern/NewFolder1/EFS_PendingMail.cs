namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EFS_PendingMail
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string subject { get; set; }

        [StringLength(200)]
        public string path { get; set; }

        public DateTime added { get; set; }

        public DateTime? parsed { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
