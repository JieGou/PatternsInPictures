﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    public class PlainMouse : IMouse
    {
        double _x = 0;
        public double X
        {
            get => _x;

            set
            {
                if (_x == value)
                    return;

                _x = value;

                Console.WriteLine($"Plain Mouse: X = {X}");
            }
        }

        double _y = 0;
        public double Y
        {
            get => _y;

            set
            {
                if (_y == value)
                    return;

                _y = value;

                Console.WriteLine($"Plain Mouse: Y = {Y}");
            }
        }

        public void LeftButtonClick()
        {
            Console.WriteLine($"Plain Mouse: Left Button Clicked");
        }
    }
}
