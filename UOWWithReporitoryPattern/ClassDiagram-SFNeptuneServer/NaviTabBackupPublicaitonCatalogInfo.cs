//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NaviTabBackupPublicaitonCatalogInfo
    {
        public int Id { get; set; }
        public int CustomerInfoId { get; set; }
        public string MyFavoriteNauProdIdList { get; set; }
        public string IsJustUpdatedNauProdIdList { get; set; }
        public string IsMarkedForAutoUpdateNauProdIdList { get; set; }
        public string Discriminator { get; set; }
    
        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
