using CargoStorage.Controller;

namespace CargoStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CargoController controller = new CargoController();

            controller.Run();
        }
    }
}