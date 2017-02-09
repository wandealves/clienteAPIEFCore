using System;
using System.Collections.Generic;
using ClientesAPI.Dominio;
using ClientesAPI.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly EFContext _context;

        public ClienteController(EFContext context)
        {
             _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var clientes = new Clientes(this._context);
            return clientes.GetAll();
        }
    }
}
