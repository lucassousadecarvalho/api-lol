using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Contracts.UseCases.Campeao
{
    public interface IAdicionarCampeao
    {
        void Adicionar(CampeaoEntity campeaoEntity);
    }
}