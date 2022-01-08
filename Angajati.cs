namespace PizzeriaModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Angajati")]
    public partial class Angajati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Angajati()
        {
            Programs = new HashSet<Program>();
        }

        public int AngajatiId { get; set; }

        [StringLength(30)]
        public string Nume { get; set; }

        [StringLength(30)]
        public string Prenume { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataNastere { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataAngajare { get; set; }

        [StringLength(15)]
        public string Post { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Programs { get; set; }
    }
}
