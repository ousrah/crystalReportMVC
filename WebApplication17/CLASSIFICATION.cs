namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASSIFICATION")]
    public partial class CLASSIFICATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASSIFICATION()
        {
            OUVRAGE = new HashSet<OUVRAGE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMRUB { get; set; }

        [StringLength(50)]
        public string LIBRUB { get; set; }


        [StringLength(150)]
        public string photo { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUVRAGE> OUVRAGE { get; set; }
    }
}
