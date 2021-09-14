using System;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Repositories;

namespace Lol.Domain.UseCases.Campeao
{
    public class AtualizarCampeao : IAtualizarCampeao
    {
        private ICampeaoRepository _repository;
        public AtualizarCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public void Atualizar(string id, CampeaoEntity campeaoEntity)
        {
            try
            {
                Guid.TryParse(id, out Guid guid);

                this._repository.Atualizar(guid, campeaoEntity);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }

}