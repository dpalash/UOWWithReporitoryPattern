namespace UOWWithReporitoryPattern.Notifications
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotificationMessage
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string DetailsText { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? DateCreatedUtc { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }
    }
}
