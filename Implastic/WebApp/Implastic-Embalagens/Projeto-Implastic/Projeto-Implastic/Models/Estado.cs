using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Implastic.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public Pais Pais { get; set; }
        public String Cidade { get; set; }        
    }
}