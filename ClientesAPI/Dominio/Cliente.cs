using System;
using System.ComponentModel.DataAnnotations;

namespace ClientesAPI.Dominio
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Cliente()
        {
        }
    }
}
