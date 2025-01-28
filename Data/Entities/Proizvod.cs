namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proizvod")]
    public partial class Proizvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proizvod()
        {
            StavkaRacuna = new HashSet<StavkaRacuna>();
        }

        public int ProizvodId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(25)]
        public string Broj { get; set; }

        [StringLength(15)]
        public string Boja { get; set; }

        public int? PotkategorijaId { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public virtual Potkategorija Potkategorija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
    }
}
