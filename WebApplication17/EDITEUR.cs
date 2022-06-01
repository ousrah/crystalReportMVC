namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EDITEUR")]
    public partial class EDITEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EDITEUR()
        {
            OUVRAGE = new HashSet<OUVRAGE>();
        }

        [Key]
        [StringLength(30)]
        public string NOMED { get; set; }

        [StringLength(40)]
        public string ADRED { get; set; }

        [StringLength(5)]
        public string CPED { get; set; }

        [StringLength(30)]
        public string VILLEED { get; set; }

        [StringLength(16)]
        public string TELED { get; set; }

        [StringLength(26)]
        public string LANGUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUVRAGE> OUVRAGE { get; set; }
    }
}
