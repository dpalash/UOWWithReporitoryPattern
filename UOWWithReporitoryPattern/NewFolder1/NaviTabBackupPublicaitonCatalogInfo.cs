namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupPublicaitonCatalogInfo")]
    public partial class NaviTabBackupPublicaitonCatalogInfo
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        [StringLength(5000)]
        public string MyFavoriteNauProdIdList { get; set; }

        [StringLength(5000)]
        public string IsJustUpdatedNauProdIdList { get; set; }

        [StringLength(5000)]
        public string IsMarkedForAutoUpdateNauProdIdList { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
