using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornarPorId(int id);
        void Inserir(T objeto);
        void Atualizar(int id, T objeto);
        void Excluir(int id);
        int ProximoId();
    }
}