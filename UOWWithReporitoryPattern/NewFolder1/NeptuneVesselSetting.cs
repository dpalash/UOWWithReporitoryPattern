namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NeptuneVesselSetting
    {
        public long Id { get; set; }

        public int? CustomerId { get; set; }

        public int? CustomerGroupId { get; set; }

        [Column(TypeName = "xml")]
        public string SettingsXml { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
