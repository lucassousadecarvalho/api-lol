namespace Lol.Domain.Adapters.Requests
{
    public class CampeaoAdicionarRequest
    {
        public string nome { get; set; }
        public int danoFisico { get; set; }
        public int poderDeHabilidade { get; set;}
        public int armadura { get; set; }
        public int resistenciaMagica { get; set; }
        public int vida { get; set; }
        public string lane { get; set; }
    }
}