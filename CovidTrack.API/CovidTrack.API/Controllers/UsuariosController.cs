using CovidTrack.BLL.Models;
using CovidTrack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CovidTrack.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    /*public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepositorio usuarioRepositorio; 

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio)
        {
            _context = context;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        
    */    
}
