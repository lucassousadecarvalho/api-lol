using System;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Repositories;

namespace Lol.Domain.UseCases.Campeao
{
    public class RecuperarCampeao : IRecuperarCampeao
    {
        private ICampeaoRepository _repository;
        public RecuperarCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public CampeaoEntity RecuperarPorId(string id)
        {
            try
            {
                Guid.TryParse(id, out Guid guid);
                return this._repository.RecuperarPorId(guid);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}