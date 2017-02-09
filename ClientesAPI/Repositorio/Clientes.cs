using System;
using System.Collections.Generic;
using System.Linq;
using ClientesAPI.Dominio;

namespace ClientesAPI.Repositorio
{
    public class Clientes
    {
        private readonly EFContext _context;
        
        public Clientes(EFContext context)
        {
            this._context = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return this._context.Clientes.ToList();
        }
    }
}
