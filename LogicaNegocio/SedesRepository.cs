using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class SedesRepository : ISedesRepository
    {
        private readonly PruebaReservasBDContext _DbContext;

        public SedesRepository(PruebaReservasBDContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Sede>> GetAll()
        {
            return await _DbContext.Sedes.ToListAsync();
        }
    }
}
