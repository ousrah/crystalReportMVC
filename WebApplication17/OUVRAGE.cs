namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OUVRAGE")]
    public partial class OUVRAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OUVRAGE()
        {
            STOCKER = new HashSet<STOCKER>();
            TARIFER = new HashSet<TARIFER>();
            ECRIVAIN = new HashSet<ECRIVAIN>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMOUVR { get; set; }

        [Required]
        [StringLength(150)]
        public string NOMOUVR { get; set; }

        public short? ANNEEPARU { get; set; }

        public int? NUMRUB { get; set; }

        public int? NUMTYPEOUVR{ get; set; }



        [StringLength(30)]
        public string NOMED { get; set; }

        public int? NUMCAT { get; set; }

  
        public virtual CATEGORIE CATEGORIE { get; set; }

        public virtual CLASSIFICATION CLASSIFICATION { get; set; }

        public virtual TYPEOUVR TYPEOUVR { get; set; }

        public virtual EDITEUR EDITEUR { get; set; }

    

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCKER> STOCKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARIFER> TARIFER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECRIVAIN> ECRIVAIN { get; set; }
    }
}
