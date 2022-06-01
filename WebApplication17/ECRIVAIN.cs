namespace WebApplication17
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECRIVAIN")]
    public partial class ECRIVAIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECRIVAIN()
        {
            OUVRAGE = new HashSet<OUVRAGE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMECR { get; set; }

        [StringLength(30)]
        public string PRENOMECR { get; set; }

        [StringLength(30)]
        public string NOMECR { get; set; }

        [StringLength(30)]
        public string PAYSECR { get; set; }

        [StringLength(30)]
        public string LANGUECR { get; set; }

        [StringLength(30)]
        public string Adresse { get; set; }

   
        [StringLength(30)]
        public string email { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUVRAGE> OUVRAGE { get; set; }
    }
}
