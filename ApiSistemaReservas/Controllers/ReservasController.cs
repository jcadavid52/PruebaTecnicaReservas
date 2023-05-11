using DataAccess;
using LogicaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSistemaReservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly ICategoriaRepository _categoria;
        private readonly ISedesRepository _sedes;
        private readonly IConsultaReservasRepository _alojamientos;
        public ReservasController(ICategoriaRepository categoria,
                                  ISedesRepository sedes,
                                  IConsultaReservasRepository alojamientos)
        {
            _categoria = categoria;
            _sedes = sedes;
            _alojamientos = alojamientos;

        }

        [HttpGet]
        [Route("categorias")]
        public async Task<IEnumerable<Categorium>> ListarCategoria()
        {
            return await _categoria.GetAll();
        }

        [HttpGet]
        [Route("sedes")]
        public async Task<IEnumerable<Sede>> ListarSedes()
        {
            return await _sedes.GetAll();
        }
        [HttpPost]
        [Route("alojamientos")]
        public async Task<IEnumerable<Alojamiento>> AlojamientosDisponibles([FromBody] FiltroReservaDTO Filtro)
        {
            return await _alojamientos.FiltroReserva(Filtro);
        }
    }
}
