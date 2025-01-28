namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Potkategorija")]
    public partial class Potkategorija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Potkategorija()
        {
            Proizvod = new HashSet<Proizvod>();
        }

        public int PotkategorijaId { get; set; }

        public int KategorijaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        public virtual Kategorija Kategorija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}
