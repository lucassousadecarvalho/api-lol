using System.Collections.Generic;
using Lol.Domain.Adapters.Requests;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Models;

namespace Lol.Domain.Factories
{
    public class CampeaoEntityFactory
    {
        public static CampeaoEntity Build(CampeaoModel campeaoModel)
        {
            return CampeaoEntity
                .Builder()
                    .WithId(campeaoModel.Id.ToString())
                    .WithNome(campeaoModel.Nome)
                    .WithDanoFisico(campeaoModel.DanoFisico)
                    .WithPoderDeHabilidade(campeaoModel.PoderDeHabilidade)
                    .WithArmadura(campeaoModel.Armadura)
                    .WithResistenciaMagica(campeaoModel.ResistenciaMagica)
                    .WithVida(campeaoModel.Vida)
                    .WithLane(campeaoModel.Lane)
                    .Build();
        }
        public static CampeaoEntity Build(CampeaoAtualizarRequest campeaoRequest)
        {
            return CampeaoEntity
                .Builder()
                    .WithNome(campeaoRequest.nome)
                    .WithDanoFisico(campeaoRequest.danoFisico)
                    .WithPoderDeHabilidade(campeaoRequest.poderDeHabilidade)
                    .WithArmadura(campeaoRequest.armadura)
                    .WithResistenciaMagica(campeaoRequest.resistenciaMagica)
                    .WithVida(campeaoRequest.vida)
                    .WithLane(campeaoRequest.lane)
                    .Build();
        }
        public static CampeaoEntity Build(CampeaoAdicionarRequest campeaoRequest)
        {
            return CampeaoEntity
                .Builder()
                    .WithNome(campeaoRequest.nome)
                    .WithDanoFisico(campeaoRequest.danoFisico)
                    .WithPoderDeHabilidade(campeaoRequest.poderDeHabilidade)
                    .WithArmadura(campeaoRequest.armadura)
                    .WithResistenciaMagica(campeaoRequest.resistenciaMagica)
                    .WithVida(campeaoRequest.vida)
                    .WithLane(campeaoRequest.lane)
                    .Build();
        }
        public static IEnumerable<CampeaoEntity> Build(IEnumerable<CampeaoModel> campeoesModel)
        {
            foreach(CampeaoModel campeaoModel in campeoesModel)
            {
                yield return CampeaoEntityFactory.Build(campeaoModel);
            }
        }
    }
}