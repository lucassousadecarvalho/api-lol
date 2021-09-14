using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Repositories;

namespace Lol.Domain.UseCases.Campeao
{
    public class AdicionarCampeao : IAdicionarCampeao
    {
        private ICampeaoRepository _repository;
        public AdicionarCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public void Adicionar(CampeaoEntity campeaoEntity)
        {
            try
            { 
                this._repository.Adicionar(campeaoEntity);
            }
            catch (System.Exception)
            {   
                throw;
            }
        }
    }
}