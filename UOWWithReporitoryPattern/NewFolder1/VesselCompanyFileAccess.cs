namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VesselCompanyFileAccess")]
    public partial class VesselCompanyFileAccess
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public int? CustomerId { get; set; }

        public bool IsApproved { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        public virtual VesselCompanyFile VesselCompanyFile { get; set; }
    }
}
