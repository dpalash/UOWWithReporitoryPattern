namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_user
    {
        [Key]
        public int userid { get; set; }

        [StringLength(30)]
        public string username { get; set; }

        [StringLength(30)]
        public string displayname { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(32)]
        public string password { get; set; }

        public short? displaytype { get; set; }

        public bool? superuser { get; set; }

        public int? groupid { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
