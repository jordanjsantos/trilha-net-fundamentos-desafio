using DesafioFundamentos.Models;

// Set the encoding to UTF8 to display accents
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking system!\n");
Console.Write("Enter the initial price: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.Write("Now enter the price per hour: ");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instantiate the Parking class, already with the values obtained previously
Parking parking = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Execute the menu loop
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your choice:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Close");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option!");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadLine();
}

Console.WriteLine("End Of Line"); // Remembering the Master Control Program from the movie Tron!