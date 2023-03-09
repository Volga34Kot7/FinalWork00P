using CargoStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Services
{
    public class UserView
    {
        public int ShowMenu(List<string> menuList)
        {
            int menu;

            Console.Clear();
            menuList.ForEach(Console.WriteLine);

            Console.Write("> ");

            menu = Convert.ToInt32(Console.ReadLine());

            return (menu < 0 || menu > menuList.Count) ? 0 : menu;
        }

        public void PrintCargoList(List<Cargo> list)
        {
            Console.Clear();
            Console.WriteLine("Список товара:");

            list.ForEach(Console.WriteLine);

            Console.WriteLine("Нажмите клавишу...");
            Console.ReadKey();
        }

        public String GetStringValue(String message)
        {
            Console.WriteLine(message);
            Console.Write("> ");
            return Console.ReadLine();
        }

        public int GetIntValue(String message)
        {
            Console.WriteLine(message);
            Console.Write("> ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}