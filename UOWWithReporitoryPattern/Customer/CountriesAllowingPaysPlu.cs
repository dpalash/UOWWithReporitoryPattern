namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CountriesAllowingPaysPlu
    {
        [Key]
        [StringLength(2)]
        public string CountryCode { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
