﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace webApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public equiposController(equiposContext equiposContexto)

        {
            _equiposContexto = equiposContexto;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<equipos> listadoEquipo = (from e in _equiposContexto.equipos select e).ToList();


            if (listadoEquipo.Count == 0) {
                return NotFound();
            }

            return Ok(listadoEquipo);

        }

        // Endpoint que que retona los registros de una tbala filtrados por su ID

        [HttpGet]
        [Route("GetById/{id}")]


        public IActionResult Get(int id)
        {

            equipos? equipo = (from e in _equiposContexto.equipos

                               where e.id_equipos == id
                               select e).FirstOrDefault();

            if (equipo == null) {
                return NotFound();

            }
            return Ok(equipo);




        }
        // este endpoint retorna los registros de una tabla filtrados por descripcion
        [HttpGet]
        [Route("Find/{filtro}")]

        public IActionResult FindByDescription(string filtro) {
        
        equipos? equipo = (from e in _equiposContexto.equipos
                           where e.descripcion.Contains(filtro)
                           select e).FirstOrDefault();

            if (equipo == null) {

                return NotFound();
            
            
            }

            return Ok(equipo);
        }


        [HttpPost]






    }

}
