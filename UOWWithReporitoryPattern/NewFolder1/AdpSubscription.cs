namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdpSubscription
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public int AdpItemId { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(50)]
        public string StartupKey { get; set; }

        [StringLength(50)]
        public string MainActivationKey { get; set; }

        [StringLength(50)]
        public string BackupActivationKey { get; set; }

        public DateTime DateModified { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual AdpItem AdpItem { get; set; }
    }
}
