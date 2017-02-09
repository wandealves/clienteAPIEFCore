using System;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Dominio
{
    public class EFContext: DbContext
    {
       public EFContext(DbContextOptions<EFContext> options): base (options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
