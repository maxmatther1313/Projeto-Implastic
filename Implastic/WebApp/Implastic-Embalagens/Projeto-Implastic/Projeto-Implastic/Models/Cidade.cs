using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Implastic.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public Pais Pais { get; set; }
        public Estado Estado { get; set; }
        public String Bairro { get; set; }
        public int Cep { get; set; }
    }
}