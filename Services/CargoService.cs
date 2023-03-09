using CargoStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Services
{
    public class CargoService: ICargoService
    {
        private static int cargo_id = 0;

        private String[] names = new String[]
        {
            "Прикормка для рыб",
            "Прикормка кукурузная",
            "Черви",
            "Спрей от насекомых",
            "Живец",
            "Жмых подсолнух",
            "Жмых кукуруза",
            "Мотыль",
            "Опарыш",
            "Спининг",
            "Карповое удилище",
            "Фидерное удилище",
            "Маховое удилище"
        };


        private String[] units = new string[]
        {
            "штуки",
            "килограмм",
            "килограмм",
            "литров",
            "литров",
            "литров",
            "штуки",
            "штуки",
            "длина",
            "длина"
        };

        public Cargo GenerateCargo()
        {
            Random random = new Random();

            Cargo cargo = new Cargo(
                ++cargo_id, 
                names[random.Next(names.Length)],
                DateTime.Now.AddDays(-random.Next(30)),
                random.NextDouble()*2000,
                random.NextDouble()*1000,
                units[random.Next(units.Length)]
            );

            return cargo;
        }
    }
}
