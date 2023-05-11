using System.Threading.Tasks;

namespace Lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.Write("\nEnter task (1 - 3): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<House<Apartment>> houses = new List<House<Apartment>>();
                        Random random = new Random();
                        int NumberHouse = random.Next(1, 4);
                        for (int i = 0; i < NumberHouse; i++)
                        {
                            House<Apartment> house = new House<Apartment>();

                            int NumberApartments = random.Next(1, 4);

                            for (int j = 0; j < NumberApartments; j++)
                            {
                                int number = random.Next(1, 6);
                                house.Apartments.Add(new Apartment { Number = number });
                            }

                            houses.Add(house);
                        }
                        foreach (var house in houses)
                        {
                            Console.WriteLine($"\nNumber of apartments in the house: {house.Apartments.Count}");

                            foreach (var apartment in house.Apartments)
                            {
                                Console.WriteLine($"Number of people in the apartment: {apartment.Number}");
                            }
                        }
                        break;
                    case 2:
                        Garage<Car> garage = new Garage<Car>();
                        Random r = new Random();
                        int NumberCars = r.Next(1, 4);
                        for (int i = 0; i < NumberCars; i++)
                        {
                            Console.Write("\nEnter car vendor: ");
                            string vendor = Console.ReadLine();

                            Console.Write("Enter car model: ");
                            string model = Console.ReadLine();

                            Console.Write("Enter car year: ");
                            int year = int.Parse(Console.ReadLine());

                            Car car = new Car { Vendor = vendor, Model = model, Year = year };
                            garage.Cars.Add(car);
                        }
                        foreach (var car in garage.Cars)
                        {
                            car.Show();
                        }
                        break;
                    case 3:
                        Alphabet<char> alphabet = new Alphabet<char>();
                        for (char letter = 'A'; letter <= 'Z'; letter++)
                        {
                            alphabet.AddLetter(letter);
                        }
                        foreach (char letter in alphabet.GetLetters())
                        {
                            Console.WriteLine(letter);
                        }
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}