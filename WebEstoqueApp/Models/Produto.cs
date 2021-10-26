using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEstoqueApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string setor { get; set; }
        public string fornecedor { get; set; }
        public string local { get; set; }
        public string quantidade { get; set; }
    }
}
