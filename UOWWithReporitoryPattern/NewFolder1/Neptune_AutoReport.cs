namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Neptune_AutoReport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(40)]
        public string reportname { get; set; }

        [StringLength(10)]
        public string sendstyle { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
