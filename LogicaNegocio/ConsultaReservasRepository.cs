using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ConsultaReservasRepository : IConsultaReservasRepository
    {
        private readonly PruebaReservasBDContext _DbContext;

        public ConsultaReservasRepository(PruebaReservasBDContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Alojamiento>> FiltroReserva(FiltroReservaDTO Filtro)
        {
            
            var alojamientos = await _DbContext.Alojamientos.Where(x => x.Capacidad == Filtro.Capacidad
                                                             && x.FechaDisponibilidad < x.FechaReserva
                                                             && x.IdCategoria == x.IdCategoria
                                                             && x.IdSede == x.IdSede).ToListAsync();

            return alojamientos;
        }
    }
}
