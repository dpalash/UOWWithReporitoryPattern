namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuersCustomerInfo")]
    public partial class IssuersCustomerInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IssuerId { get; set; }

        [StringLength(50)]
        public string IssuersCustomerId { get; set; }

        [Column(TypeName = "xml")]
        public string IssuersAdditionalInfo { get; set; }

        public bool IsActive { get; set; }

        public DateTime ChangedAt { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        public virtual issuer issuer { get; set; }
    }
}
