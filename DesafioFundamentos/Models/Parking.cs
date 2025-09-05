namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.Write("\nEnter the vehicle license plate number to park: ");
            string plate = Console.ReadLine();
            vehicles.Add(plate);
        }

        public void RemoveVehicle()
        {
            Console.Write("\nEnter the vehicle license plate to remove: ");
            string plate = Console.ReadLine();

            // Check if the vehicle exists
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.Write("Enter the number of hours the vehicle was parked: ");

                int hours = Convert.ToInt32(Console.ReadLine());
                decimal totalValue = initialPrice + pricePerHour * hours;

                vehicles.Remove(plate);

                Console.WriteLine($"\nThe vehicle {plate} was removed and the total price was: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please check that you have entered the license plate number correctly.");
            }
        }

        public void ListVehicles()
        {
            // Verifica se há veículos no estacionamento
            if (vehicles.Any())
            {
                Console.WriteLine("Parked vehicles are:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
