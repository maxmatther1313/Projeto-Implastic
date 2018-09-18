using Projeto_Implastic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Implastic.DAO
{
    public class PaisesDAO
    {
        public IList<Pais> Lista()
        {
            using(var contexto = new ImplasticContext())
            {
                return contexto.Paises.ToList();
            }
        }
    }
}