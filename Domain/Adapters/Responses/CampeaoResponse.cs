using System;

namespace Lol.Domain.Adapters.Responses
{
    public class CampeaoResponse
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public int danoFisico { get; set; }
        public int poderDeHabilidade { get; set; }
        public int armadura { get; set; }
        public int resistenciaMagica { get; set; }
        public int vida { get; set; }
        public string lane { get; set; }
        public static CampeaoResponseBuilder Builder() => new CampeaoResponseBuilder();
        public class CampeaoResponseBuilder
        {
            public string id { get; set; }
            public string nome { get; set; }
            public int danoFisico { get; set; }
            public int poderDeHabilidade { get; set; }
            public int armadura { get; set; }
            public int resistenciaMagica { get; set; }
            public int vida { get; set; }
            public string lane { get; set; }
            
            public CampeaoResponseBuilder WithId(string id)
            {
                this.id = id;
                return this;
            }
            public CampeaoResponseBuilder WithNome(string nome)
            {
                this.nome = nome;
                return this;
            }
            public CampeaoResponseBuilder WithDanoFisico(int danoFisico)
            {
                this.danoFisico = danoFisico;
                return this;
            }
            public CampeaoResponseBuilder WithPoderDeHabilidade(int poderDeHabilidade)
            {
                this.poderDeHabilidade = poderDeHabilidade;
                return this;
            }
            public CampeaoResponseBuilder WithArmadura(int armadura)
            {
                this.armadura = armadura;
                return this;
            }
            public CampeaoResponseBuilder WithResistenciaMagica(int resistenciaMagica)
            {
                this.resistenciaMagica = resistenciaMagica;
                return this;
            }
            public CampeaoResponseBuilder WithVida(int vida)
            {
                this.vida = vida;
                return this;
            }
            public CampeaoResponseBuilder WithLane(string lane)
            {
                this.lane = lane;
                return this;
            }
            public CampeaoResponse Build()
            {
                CampeaoResponse campeaoResponse = new CampeaoResponse();
                Guid.TryParse(this.id, out Guid id);

                campeaoResponse.id = id;
                campeaoResponse.nome =  this.nome;
                campeaoResponse.danoFisico = this.danoFisico;
                campeaoResponse.poderDeHabilidade = this.poderDeHabilidade;
                campeaoResponse.armadura = this.armadura;
                campeaoResponse.resistenciaMagica = this.resistenciaMagica;
                campeaoResponse.vida = this.vida;
                campeaoResponse.lane = this.lane;
                
                return campeaoResponse;
            }
        }


    }
}