namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCKER")]
    public partial class STOCKER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMOUVR { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMDEP { get; set; }

        public int? QTESTOCK { get; set; }

        public virtual DEPOT DEPOT { get; set; }

        public virtual OUVRAGE OUVRAGE { get; set; }
    }
}
