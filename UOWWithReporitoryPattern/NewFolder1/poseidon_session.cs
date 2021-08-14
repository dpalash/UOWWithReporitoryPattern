namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class poseidon_session
    {
        [Key]
        public int sid { get; set; }

        public int? uid { get; set; }

        public long? ip { get; set; }

        public long? start { get; set; }

        public long? action { get; set; }

        [Column(TypeName = "text")]
        public string request { get; set; }

        [Column(TypeName = "text")]
        public string useragent { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
