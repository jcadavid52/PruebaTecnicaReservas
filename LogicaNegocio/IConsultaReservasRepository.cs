using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface IConsultaReservasRepository
    {
        public Task<IEnumerable<Alojamiento>> FiltroReserva(FiltroReservaDTO Filtro);
    }
}
