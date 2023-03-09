using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    public class Cargo : ACargo
    {
        private int id;

        public int Id { get { return id; } set { id = value; } }

        public Cargo()
        {
        }


        public Cargo(int id, string name, DateTime start, double price, double count, string unitName)
        {
            this.id = id;
            Name = name;
            Start = start;
            Price = price;
            Count = count;
            UnitName = unitName;
        }

        public override string? ToString()
        {
            return "Код: " + id.ToString() + " " + base.ToString();
        }
    }
}
