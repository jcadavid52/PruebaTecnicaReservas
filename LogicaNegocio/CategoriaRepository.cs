using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly PruebaReservasBDContext _DbContext;

        public CategoriaRepository(PruebaReservasBDContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Categorium>> GetAll()
        {
            return await _DbContext.Categoria.ToListAsync();
        }
    }
}
