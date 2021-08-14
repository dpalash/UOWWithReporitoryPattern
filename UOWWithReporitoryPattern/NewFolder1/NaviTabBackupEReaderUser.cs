namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupEReaderUser")]
    public partial class NaviTabBackupEReaderUser
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int? RememberMe { get; set; }

        public int? AutoLoggedInEnabled { get; set; }

        public int? IsAdministrator { get; set; }

        public int? IsAllowedToOrder { get; set; }

        public int? IsActive { get; set; }

        public DateTime? LastLogin { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
