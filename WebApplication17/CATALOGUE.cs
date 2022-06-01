namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGUE")]
    public partial class CATALOGUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATALOGUE()
        {
            TARIFER = new HashSet<TARIFER>();
        }

        [Key]
        [Column(TypeName = "date")]
        public DateTime DATEDEB { get; set; }

        public DateTime? DATEFIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARIFER> TARIFER { get; set; }
    }
}
