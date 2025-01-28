namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetodaDostave")]
    public partial class MetodaDostave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetodaDostave()
        {
            Racun = new HashSet<Racun>();
        }

        public int MetodaDostaveId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Column(TypeName = "money")]
        public decimal Cijena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }


        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
