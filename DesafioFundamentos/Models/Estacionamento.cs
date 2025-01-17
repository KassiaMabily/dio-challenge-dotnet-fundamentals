namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            this.veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }

            // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int horas;
            while(!int.TryParse(Console.ReadLine(), out horas)){
                Console.WriteLine("Por favor, insira um número!");
            }

            // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
            decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);

            // Remover a placa digitada da lista de veículos
            this.veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (!veiculos.Any())
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;
            }

            Console.WriteLine("Os veículos estacionados são:");
            // Realizar um laço de repetição, exibindo os veículos estacionados
            foreach(string placa in this.veiculos)
            {
                Console.WriteLine(placa);
            }

        }
    }
}
