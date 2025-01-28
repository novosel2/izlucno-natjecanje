namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KreditnaKartica")]
    public partial class KreditnaKartica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KreditnaKartica()
        {
            Racun = new HashSet<Racun>();
        }

        public int KreditnaKarticaId { get; set; }

        [Required]
        [StringLength(50)]
        public string TipKartice { get; set; }

        [Required]
        [StringLength(25)]
        public string BrojKartice { get; set; }

        public byte IstekMjesec { get; set; }

        public short IstekGodina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
    }
}
