namespace UOWWithReporitoryPattern.ValueAddedSubscription
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValueAddedSubscription
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public int CustomerId { get; set; }

        public DateTime? AddedDate { get; set; }

        public DateTime? RemovedDate { get; set; }

        public bool IsPending { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual ValueAddedSubscriptionType ValueAddedSubscriptionType { get; set; }
    }
}
