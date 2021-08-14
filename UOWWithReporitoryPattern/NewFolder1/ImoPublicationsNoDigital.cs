namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImoPublicationsNoDigital")]
    public partial class ImoPublicationsNoDigital
    {
        [Key]
        [StringLength(50)]
        public string ProdId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
