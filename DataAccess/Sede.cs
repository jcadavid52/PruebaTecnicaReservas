using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Sede
    {
        public Sede()
        {
            Alojamientos = new HashSet<Alojamiento>();
        }

        public int IdSede { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Alojamiento> Alojamientos { get; set; }
    }
}
