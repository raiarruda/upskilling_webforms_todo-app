using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Utilitarios
{
    public interface IPersistencia<T>
    {
        void Incluir(T entidade);
        void Atualizar(T entidade);
        List<T> Buscar();
        void Apagar(T entidade);
    }
}

