namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_admin_users
    {
        public int id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(32)]
        public string password { get; set; }

        [StringLength(50)]
        public string displayname { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public byte admin { get; set; }

        public DateTime? lastlogin { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
