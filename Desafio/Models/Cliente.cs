using System.ComponentModel.DataAnnotations;

namespace Desafio.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Cliente
    {

        [Key]
        public int ClienteId { get; set; }
        public string ClienteName { get; set; } = string.Empty;
        public string ClienteEmail { get; set; } = string.Empty;
    }
}
