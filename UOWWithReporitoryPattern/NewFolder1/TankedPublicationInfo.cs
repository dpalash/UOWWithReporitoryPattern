namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TankedPublicationInfo")]
    public partial class TankedPublicationInfo
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string DeviceSerialNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string NauProdId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProdId { get; set; }

        [Required]
        [MaxLength(50)]
        public byte[] Salt { get; set; }

        [Required]
        [MaxLength(50)]
        public byte[] RandomString { get; set; }

        public int Iteration { get; set; }

        public DateTime? TankedOn { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
