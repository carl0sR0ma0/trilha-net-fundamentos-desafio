
namespace Estacionamento.Console.models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal _initialPrice, decimal _pricePerHour)
        {
            this.initialPrice = _initialPrice;
            this.pricePerHour = _pricePerHour;
        }

        public void AddVehicles()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            System.Console.WriteLine("Digite a placa do veículo para estacionar:");
            var plate = System.Console.ReadLine();
            this.vehicles.Add(plate);
        }
        public void RemoveVehicles()
        {
            System.Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string plate = System.Console.ReadLine();

            // Verifica se o veículo existe
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int hours = 0;
                hours = int.Parse(System.Console.ReadLine());
                decimal totalValue = 0;
                totalValue = this.initialPrice + (this.pricePerHour * hours);
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                this.vehicles.Remove(plate);
                System.Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                System.Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicles()
        {
            // Verifica se há veículos no estacionamento
            if (vehicles.Any())
            {
                System.Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string vehicle in vehicles)
                {
                    System.Console.WriteLine(vehicle);
                }
            }
            else
            {
                System.Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}