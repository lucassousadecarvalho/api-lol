using System.Collections.Generic;
using Lol.Domain.Adapters.Responses;
using Lol.Domain.Entities.Campeao;

namespace Lol.Domain.Factories
{
    public class CampeaoResponseFactory
    {
        public static CampeaoResponse Build(CampeaoEntity campeaoEntity)
        {
            return CampeaoResponse
                .Builder()
                    .WithId(campeaoEntity.Id.ToString())
                    .WithNome(campeaoEntity.Nome.Valor)
                    .WithDanoFisico(campeaoEntity.DanoFisico)
                    .WithPoderDeHabilidade(campeaoEntity.PoderDeHabilidade)
                    .WithArmadura(campeaoEntity.Armadura)
                    .WithResistenciaMagica(campeaoEntity.ResistenciaMagica)
                    .WithVida(campeaoEntity.Vida)
                    .WithLane(campeaoEntity.Lane.Valor)
                    .Build();
        }
        public static IEnumerable<CampeaoResponse> Build(IEnumerable<CampeaoEntity> campeoesEntity)
        {
            foreach(CampeaoEntity campeaoEntity in campeoesEntity)
            {
                yield return CampeaoResponseFactory.Build(campeaoEntity);
            }
        }
    }
}