using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceOsorioManha.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        
        public string Login { get; set; }

        public string Senha { get; set; }
    }
}