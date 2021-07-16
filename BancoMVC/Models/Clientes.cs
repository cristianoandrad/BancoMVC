using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoMVC.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }

    }
}
