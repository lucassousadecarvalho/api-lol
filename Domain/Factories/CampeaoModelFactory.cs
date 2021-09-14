using System.Collections.Generic;
using Lol.Domain.Entities.Campeao;
using Lol.Infra.Models;

namespace Lol.Domain.Factories
{
    public class CampeaoModelFactory
    {
        public static CampeaoModel Build(CampeaoEntity campeaoEntity)
        {
            return CampeaoModel
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
        public static IEnumerable<CampeaoModel> Build(IEnumerable<CampeaoEntity> campeoesEntity)
        {
            foreach(CampeaoEntity campeaoEntity in campeoesEntity)
            {
                yield return CampeaoModelFactory.Build(campeaoEntity);
            }
        }
    }
}