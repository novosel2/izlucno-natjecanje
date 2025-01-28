namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Racun")]
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            StavkaRacuna = new HashSet<StavkaRacuna>();
        }

        public int RacunId { get; set; }

        public DateTime DatumNarudzbe { get; set; }

        public DateTime DatumDostave { get; set; }

        public DateTime? DatumOtpreme { get; set; }

        public int MetodaDostaveId { get; set; }

        public int? KreditnaKarticaId { get; set; }

        public int? KupacId { get; set; }

        public virtual KreditnaKartica KreditnaKartica { get; set; }

        public virtual Kupac Kupac { get; set; }

        public virtual MetodaDostave MetodaDostave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaRacuna> StavkaRacuna { get; set; }
    }
}
