namespace Csharp_2021_Autowerkstatt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fahrzeug")]
    public partial class Fahrzeug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fahrzeug()
        {
            Reparaturs = new HashSet<Reparatur>();
        }

        [Key]
        public int Nr { get; set; }

        [Required]
        [StringLength(50)]
        public string Kennzeichen { get; set; }

        [Required]
        [StringLength(50)]
        public string Marke { get; set; }

        [Required]
        [StringLength(50)]
        public string Modell { get; set; }

        [Required]
        [StringLength(100)]
        public string Halter { get; set; }

        [Required]
        [StringLength(50)]
        public string Ort { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reparatur> Reparaturs { get; set; }
    }
}
