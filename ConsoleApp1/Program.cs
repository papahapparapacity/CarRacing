using Cars111;
namespace CarRace
{
    public class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>
        {
            new Car("E63 AMG", 100, 0),
            new Car("RS 7", 110, 0),
            new Car("M5 F10", 115, 0)
        };

            while (true)
            {
                Console.Clear();
                foreach (var car in cars)
                {
                    car.Move();
                    Console.WriteLine($"Car: {car.Name}, Speed: {car.CurrentSpeed}, Distance: {car.Distance}");
                }

                if (cars.TrueForAll(c => c.Distance >= 1000))
                {
                    Console.WriteLine("\nRace finished!");
                    cars.Sort((x, y) => y.Distance.CompareTo(x.Distance));
                    for (int i = 0; i < cars.Count; i++)
                    {
                        Console.WriteLine($"Position {i + 1}: {cars[i].Name}");
                    }
                    break;
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}