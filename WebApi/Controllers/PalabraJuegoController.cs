using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logica;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Default")]
    public class PalabraJuegoController : Controller
    {
        Juego juego = new Juego();

        // GET: api/Default
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/palabraJuego
        [HttpPost]
        public void Post([FromBody]string value)
        {
            juego.IngresarPalabra(value);
        }
        
        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
