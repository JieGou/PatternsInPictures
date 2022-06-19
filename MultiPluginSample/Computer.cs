using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    public class Computer
    {
        // reference to IMouse
        public IMouse Mouse { get; set; }

        // reference to IKeyboard
        public IKeyboard Keyboard { get; set; }

        public Computer()
        {
            // defaults are set to  PlainMouse and  PlainKeyboard
            Mouse = new PlainMouse();
            Keyboard = new PlainKeyboard();
        }

        // wrapper around IMouse.X and IMouse.Y setters
        public void MoveMouse(double x, double y)
        {
            if (Mouse == null) return;

            Mouse.X = x;
            Mouse.Y = y;
        }

        // wrapper around IMouse.LeftButtonClick()
        public void MouseClick()
        {
            Mouse?.LeftButtonClick();
        }

        // Wrapper around IKeyboard.KeyClick(char c)
        public void ClickKeyboardKey(char c)
        {
            Keyboard?.KeyClick(c);
        }
    }
}