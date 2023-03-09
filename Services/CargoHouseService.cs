using CargoStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Services
{
    internal class CargoHouseService
    {
        CargoHouse<Cargo> cargoHouse = new CargoHouse<Cargo>();
        CargoService cargoService = new CargoService();

        public void AddCargo(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Cargo cargo = cargoService.GenerateCargo();
                cargoHouse.AddCargo(cargo);
            }
        }

        public List<Cargo> GetCargoList(String name)
        {
            return cargoHouse.FindCargo(name);
        }

        public List<Cargo> GetCargoList()
        {
            return cargoHouse.GetCargoList();
        }

        public void CargoShipment(int id, DateTime date)
        {
            cargoHouse.Shipment(id, date);
        }

        public void CargoDeleteOnId(int id)
        {
            cargoHouse.DeleteCargoId(id);
        }
    }
}
