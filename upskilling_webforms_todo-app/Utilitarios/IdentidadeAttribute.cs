using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Utilitarios
{

    public class IdentidadeAttribute : Attribute
    {
        public string NomeNoBancoDeDados { get; set; } = default;
    }
}