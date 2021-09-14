using System.Collections.Generic;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Repositories;

namespace Lol.Domain.UseCases.Campeao
{
    public class RecuperarListaCampeao : IRecuperarListaCampeao
    {
        private ICampeaoRepository _repository;
        public RecuperarListaCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public IEnumerable<CampeaoEntity> RecuperarLista()
        {
            try
            { 
                return this._repository.RecuperarLista();
            }
            catch (System.Exception)
            {   
                throw;
            }
        }
    }
}