namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Neptune_Logons_old
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public DateTime? date { get; set; }

        [StringLength(30)]
        public string ip { get; set; }

        [StringLength(50)]
        public string customer { get; set; }

        [Column(TypeName = "text")]
        public string parameters { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
