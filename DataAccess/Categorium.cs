using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Categorium
    {
        public Categorium()
        {
            Alojamientos = new HashSet<Alojamiento>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Alojamiento> Alojamientos { get; set; }
    }
}
