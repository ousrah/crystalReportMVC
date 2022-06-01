namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TARIFER")]
    public partial class TARIFER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMOUVR { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime DATEDEB { get; set; }

        public double? PRIXVENTE { get; set; }

        public virtual CATALOGUE CATALOGUE { get; set; }

        public virtual OUVRAGE OUVRAGE { get; set; }
    }
}
