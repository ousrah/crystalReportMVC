namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [Key]
        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(255)]
        public string hash { get; set; }

        public DateTime? dateExpiration { get; set; }

        public bool? valide { get; set; }
    }
}
