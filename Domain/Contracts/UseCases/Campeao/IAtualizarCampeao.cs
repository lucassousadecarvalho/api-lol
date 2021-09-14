using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Contracts.UseCases.Campeao
{
    public interface IAtualizarCampeao
    {
        void Atualizar(string id, CampeaoEntity campeaoEntity);
    }
}