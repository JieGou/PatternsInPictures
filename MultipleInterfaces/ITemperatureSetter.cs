using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public interface ITemperatureSetter
    {
        /// <summary>
        /// the temperature set by hand
        /// </summary>
        double SetTemperature { get; set; }

        /// <summary>
        /// the real fridge temperature
        /// </summary>
        double RealTemperature { get; }
    }
}