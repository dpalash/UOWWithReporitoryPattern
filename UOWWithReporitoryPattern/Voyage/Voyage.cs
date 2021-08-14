namespace UOWWithReporitoryPattern.Voyage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Voyage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voyage()
        {
            MissingEncsForVoyages = new HashSet<MissingEncsForVoyage>();
            OutdatedEncsForVoyages = new HashSet<OutdatedEncsForVoyage>();
            RequiredEncsForVoyages = new HashSet<RequiredEncsForVoyage>();
            VoyageRoutes = new HashSet<VoyageRoute>();
        }

        public int CustomerId { get; set; }

        public DateTime? ETA { get; set; }

        public DateTime? ETD { get; set; }

        public string Destination { get; set; }

        public string Departure { get; set; }

        public string PdfFileName { get; set; }

        public string RtzFileName { get; set; }

        public int? RouteStatus { get; set; }

        public int? ProductStatus { get; set; }

        public int? UpdateStatus { get; set; }

        public int IssuerId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public int? NaviPlannerUserId { get; set; }

        [StringLength(100)]
        public string NaviPlannerUserName { get; set; }

        public string PdfFilePath { get; set; }

        public string RtzFilePath { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? ChangedDate { get; set; }

        public string EncIds { get; set; }

        [StringLength(500)]
        public string RouteName { get; set; }

        public int Id { get; set; }

        public virtual issuer issuer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MissingEncsForVoyage> MissingEncsForVoyages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutdatedEncsForVoyage> OutdatedEncsForVoyages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredEncsForVoyage> RequiredEncsForVoyages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoyageRoute> VoyageRoutes { get; set; }
    }
}
