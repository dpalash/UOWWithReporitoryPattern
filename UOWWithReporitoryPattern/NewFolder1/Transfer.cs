namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transfer
    {
        public int TransferID { get; set; }

        public int SessionID { get; set; }

        public long Size { get; set; }

        public int FileCount { get; set; }

        public long Speed { get; set; }

        public DateTime Date { get; set; }

        public bool IsFaulted { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Session1 Session { get; set; }
    }
}
