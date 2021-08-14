namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerDeviceInfo")]
    public partial class CustomerDeviceInfo
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DeviceSerialNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerDeviceNum { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        [StringLength(200)]
        public string RandomNumber { get; set; }

        [StringLength(200)]
        public string WifiMAC { get; set; }

        [StringLength(200)]
        public string DockingMAC { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
