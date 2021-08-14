namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class package_files
    {
        public int id { get; set; }

        public int? pid { get; set; }

        [Column(TypeName = "text")]
        public string name { get; set; }

        public long? filesize { get; set; }

        public bool? sentasmail { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
