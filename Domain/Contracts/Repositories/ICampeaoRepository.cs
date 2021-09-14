using System;
using System.Collections.Generic;
using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Contracts.Repositories
{
    public interface ICampeaoRepository
    {
        IEnumerable<CampeaoEntity> RecuperarLista();
        CampeaoEntity RecuperarPorId(Guid id);
        CampeaoEntity RecuperarPorNome(string nome);
        void Adicionar(CampeaoEntity campeaoEntity);
        void Atualizar(Guid id, CampeaoEntity campeaoEntity);
        void Excluir(Guid id);
    }
}