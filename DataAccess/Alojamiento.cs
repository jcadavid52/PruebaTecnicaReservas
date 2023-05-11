using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Alojamiento
    {
        public int IdAlojamiento { get; set; }
        public int? Capacidad { get; set; }
        public string CodigoHabitacion { get; set; }
        public DateTime? FechaReserva { get; set; }
        public DateTime? FechaDisponibilidad { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSede { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual Sede IdSedeNavigation { get; set; }
    }
}
