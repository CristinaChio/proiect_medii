namespace PizzeriaModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orar")]
    public partial class Orar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orar()
        {
            Programs = new HashSet<Program>();
        }

        public int OrarId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataIntreaga { get; set; }

        [StringLength(15)]
        public string Tura { get; set; }

        [StringLength(10)]
        public string ZiuaSaptamanii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Programs { get; set; }
    }
}
