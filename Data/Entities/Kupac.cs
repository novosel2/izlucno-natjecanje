namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kupac")]
    public partial class Kupac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kupac()
        {
            Racun = new HashSet<Racun>();
        }

        public int KupacId { get; set; }

        [StringLength(8)]
        public string Titula { get; set; }

        [Required]
        [StringLength(100)]
        public string Ime { get; set; }

        [Required]
        [StringLength(100)]
        public string Prezime { get; set; }

        [StringLength(40)]
        public string Ulica { get; set; }

        public int? KucniBroj { get; set; }

        [StringLength(10)]
        public string PostanskiBroj { get; set; }

        [StringLength(20)]
        public string Grad { get; set; }

        [StringLength(20)]
        public string Drzava { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; } = new List<Racun>();
    }
}
