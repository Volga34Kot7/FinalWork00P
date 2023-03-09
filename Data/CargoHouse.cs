using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    public class CargoHouse<A> where A : Cargo
    {
        private List<A> cargos = new List<A>();

        public void AddCargo(A cargo)
        {
            cargos.Add(cargo);
        }

        public void DeleteCargo(A cargo)
        {
            cargos.Remove(cargo);
        }

        public void DeleteCargo(int index)
        {
            cargos.RemoveAt(index);
        }

        public void DeleteCargoId(int id) => cargos.RemoveAll(x => x.Id == id);

        public List<A> FindCargo(string name) => 
            cargos.FindAll(x => x.Name == name);

        public List<A> GetCargoList()
        {
            return cargos;
        }

        public void Shipment(int id, DateTime date)
        {
            List<A> list = cargos.FindAll(x => x.Id == id);

            foreach(A c in list)
            {
                c.End = date;
            }
        }

        public void Shipment(int id)
        {
            Shipment(id, DateTime.Now.Date);
        }
    }
}