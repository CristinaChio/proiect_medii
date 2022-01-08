namespace PizzeriaModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Program")]
    public partial class Program
    {
        public int ProgramId { get; set; }

        public int? AngajatiId { get; set; }

        public int? OrarId { get; set; }

        public virtual Angajati Angajati { get; set; }

        public virtual Orar Orar { get; set; }
    }
}
