using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLiquide.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
