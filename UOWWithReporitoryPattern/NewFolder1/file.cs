namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class file
    {
        [Key]
        public int fid { get; set; }

        public int? sid { get; set; }

        public int? pid { get; set; }

        public DateTime? starttime { get; set; }

        public DateTime? endtime { get; set; }

        [Column(TypeName = "text")]
        public string filename { get; set; }

        public int? filesize { get; set; }

        public int? resumefrom { get; set; }

        public long? speed { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
