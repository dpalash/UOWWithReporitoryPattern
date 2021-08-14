namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Neptune_Files_old
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(50)]
        public string sessionid { get; set; }

        public DateTime? starttime { get; set; }

        public DateTime? finishtime { get; set; }

        [StringLength(30)]
        public string ip { get; set; }

        [Column(TypeName = "text")]
        public string file_name { get; set; }

        public long? file_size { get; set; }

        [StringLength(50)]
        public string customer { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
