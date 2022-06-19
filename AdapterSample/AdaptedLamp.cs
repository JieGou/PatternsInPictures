using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class AdaptedLamp : AmericanLamp, IEuropeanPowerPlug
    {
        /// <summary>
        /// wrapping (adapting) the property.
        /// </summary>
        public bool IsPluggedIntoEuropeanPowerOutlet
        {
            get => IsPluggedIntoAmericanPowerOutlet;
            set
            {
                IsPluggedIntoAmericanPowerOutlet = true;
            }
        }
    }
}