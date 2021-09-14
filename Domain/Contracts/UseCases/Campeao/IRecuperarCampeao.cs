using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Contracts.UseCases.Campeao
{
    public interface IRecuperarCampeao
    {
        CampeaoEntity RecuperarPorId(string id);
    } 
}