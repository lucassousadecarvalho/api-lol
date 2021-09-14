using System;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Infra.Repositories;

namespace Lol.Domain.UseCases.Campeao
{
    public class ExcluirCampeao : IExcluirCampeao
    {
        private ICampeaoRepository _repository;
        public ExcluirCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public void Excluir(string id)
        {
            try
            {
                Guid.TryParse(id, out Guid guid);
                this._repository.Excluir(guid);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}