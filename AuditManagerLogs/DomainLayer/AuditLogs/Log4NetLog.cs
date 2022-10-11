namespace DomainLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log4NetLog
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Thread { get; set; }

        [Required]
        [StringLength(50)]
        public string Level { get; set; }

        [Required]
        [StringLength(255)]
        public string Logger { get; set; }

        [Required]
        [StringLength(4000)]
        public string Message { get; set; }

        public string Exception { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

        [StringLength(1000)]
        public string Path { get; set; }
    }
}
