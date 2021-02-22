namespace Csharp_2021_Autowerkstatt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reparatur")]
    public partial class Reparatur
    {
        [Key]
        public int Nr { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Datum { get; set; }

        [Required]
        [StringLength(100)]
        public string Beschreibung { get; set; }

        public decimal Kosten { get; set; }

        public int FahrzeugNr { get; set; }

        public virtual Fahrzeug Fahrzeug { get; set; }
    }
}
