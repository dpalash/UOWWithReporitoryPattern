namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderLine
    {
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }

        public int ProductGroupId { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductReference { get; set; }

        public int IssuerId { get; set; }

        public byte OrderStatusId { get; set; }

        [Column(TypeName = "text")]
        public string Comments { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual issuer issuer { get; set; }

        public virtual OrderHeader OrderHeader { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
