namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogEntry
    {
        public int LogEntryID { get; set; }

        public int ServerID { get; set; }

        public int LogLevel { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Entry { get; set; }

        public bool Handled { get; set; }

        public DateTime CreationTime { get; set; }

        [StringLength(50)]
        public string HandledBy { get; set; }

        public DateTime? HandledAt { get; set; }

        public bool? IsPending { get; set; }

        public string Comment { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Server Server { get; set; }
    }
}
