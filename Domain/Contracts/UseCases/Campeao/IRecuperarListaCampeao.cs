using System.Collections.Generic;
using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Contracts.UseCases.Campeao
{
    public interface IRecuperarListaCampeao
    {
        IEnumerable<CampeaoEntity> RecuperarLista();
    }
}