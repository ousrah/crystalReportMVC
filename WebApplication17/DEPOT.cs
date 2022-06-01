namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPOT")]
    public partial class DEPOT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPOT()
        {
            STOCKER = new HashSet<STOCKER>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMDEP { get; set; }

        [StringLength(30)]
        public string NOMDEP { get; set; }

        [StringLength(40)]
        public string ADRDEP { get; set; }

        [StringLength(5)]
        public string CPDEP { get; set; }

        [StringLength(30)]
        public string VILLEDEP { get; set; }

        [StringLength(30)]
        public string PAYSDEP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKER> STOCKER { get; set; }
    }
}
