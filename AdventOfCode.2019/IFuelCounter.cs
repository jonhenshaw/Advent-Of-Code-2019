using System.Collections.Generic;

namespace Advent.Of.Code._2019._1
{
    public interface IFuelCounter
    {
        int CalculateFuel(int mass);
        int CalculateTotalFuel(int mass);
        int SumAllFuel(List<int> massList);
    }
}