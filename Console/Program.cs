namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("VD 1111","Dacia", "logan", "2131321");
            Truck truck = new Truck("VD 2222", "volvo", "XXX", "123456789");
            DisplayCar(car);
            DisplayTruck(truck);
        }

        static private void DisplayCar(Car car)
        {
            Console.WriteLine(car.ToString());
            
        }

        static private void DisplayTruck(Truck truck)
        {
            Console.WriteLine(truck.ToString());
        }
    }
}