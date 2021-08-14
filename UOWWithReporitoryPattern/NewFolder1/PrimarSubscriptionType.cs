namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PrimarSubscriptionType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int PeriodInMonths { get; set; }

        public bool RealTimeEnc { get; set; }

        public bool AutoRenewal { get; set; }

        public int? EncOrderTypeId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncOrderType EncOrderType { get; set; }
    }
}
