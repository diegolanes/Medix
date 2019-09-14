using Medix.Dominio.Contratos;
using Medix.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medix.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ConsultaController : Controller
    {
        private readonly IConsultaRepositorio _consultaRepositorio;
        public ConsultaController(IConsultaRepositorio consultaRepositorio)
        {
            _consultaRepositorio = consultaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_consultaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Consulta consulta)
        {
            try
            {
                _consultaRepositorio.Adicionar(consulta);
                return Created("api/consulta", consulta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

