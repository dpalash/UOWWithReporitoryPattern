namespace UOWWithReporitoryPattern.Voyage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MissingEncsForVoyage")]
    public partial class MissingEncsForVoyage
    {
        [StringLength(50)]
        public string Id { get; set; }

        public int? EncId { get; set; }

        public int VoyageId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncCell EncCell { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
