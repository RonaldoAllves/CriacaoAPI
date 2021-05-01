using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CriacaoAPI.Models
{
    public class Pessoa
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatorio")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo UF é obrigatorio")]
        public String Uf { get; set; }

        [Required(ErrorMessage = "Campo Data é obrigatorio")]
        public String Data { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatorio")]
        public Int64 Cpf { get; set; }

    }
}
