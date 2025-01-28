namespace IzlucnoNatjecanje.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StavkaRacuna")]
    public partial class StavkaRacuna
    {
        public int RacunId { get; set; }

        public int StavkaRacunaId { get; set; }

        [StringLength(25)]
        public string BrojPosiljkeKodDostavljaca { get; set; }

        public short Kolicina { get; set; }

        public int ProizvodId { get; set; }

        [Column(TypeName = "money")]
        public decimal JedinicnaCijena { get; set; }

        [Column(TypeName = "money")]
        public decimal JedinicnaCijenaUmanjenje { get; set; }

        public virtual Proizvod Proizvod { get; set; }

        public virtual Racun Racun { get; set; }
    }
}
