using System;
using Lol.Domain.Contracts.Repositories;
using Lol.Domain.Contracts.UseCases.Campeao;
using Lol.Domain.Entities.Campeao;

namespace Api.Domain.UseCases.Campeao
{
    public class DuelarCampeao : IDuelarCampeao
    {
        private ICampeaoRepository _repository;
        public DuelarCampeao(ICampeaoRepository repository)
        {
            this._repository = repository;
        }
        public string Duelar(string nome1, string nome2)
        {
            CampeaoEntity campeaoUm = this._repository.RecuperarPorNome(nome1);
            CampeaoEntity campeaoDois = this._repository.RecuperarPorNome(nome2);

             if(campeaoUm != null && campeaoDois != null)
            {
                double campeaoUmPontuacao = campeaoUm.GetPontuacao();
                double campeaoDoisPontuacao = campeaoDois.GetPontuacao();

                if(campeaoUmPontuacao > campeaoDoisPontuacao)
                {
                    return $"Campeão {campeaoUm.Nome.Valor} venceu!";
                }
                if(campeaoUmPontuacao == campeaoDoisPontuacao)
                {
                    return $"Ambos morreram... Luto por {campeaoUm.Nome.Valor} e {campeaoDois.Nome.Valor}";
                }

                return $"Campeão {campeaoDois.Nome.Valor} venceu!";
            }
            return "Campeões não encontrados!";
        }
    }
}