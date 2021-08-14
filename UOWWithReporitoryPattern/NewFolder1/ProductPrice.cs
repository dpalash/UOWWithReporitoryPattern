namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductPrice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductGroupId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string Currency { get; set; }

        public DateTime LastModified { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
