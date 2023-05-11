using System;

namespace DataAccess
{
    public class FiltroReservaDTO
    {
        public int Capacidad { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaDisponibilidad { get; set; }
        public int IdCategoria { get; set; }
        public int IdSede { get; set; }
    }
}
