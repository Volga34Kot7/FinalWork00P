using CargoStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Services
{
    public interface ICargoService
    {
        Cargo GenerateCargo();
    }
}
