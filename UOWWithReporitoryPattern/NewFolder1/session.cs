namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("session")]
    public partial class session
    {
        [Key]
        public int sid { get; set; }

        [StringLength(26)]
        public string skey { get; set; }

        public int? customer { get; set; }

        [StringLength(15)]
        public string ip { get; set; }

        public DateTime? starttime { get; set; }

        public DateTime? endtime { get; set; }

        public bool? admin { get; set; }

        public int? encryptionfile { get; set; }

        public bool? mail { get; set; }

        [StringLength(50)]
        public string server { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
