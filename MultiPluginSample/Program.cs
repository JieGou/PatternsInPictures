using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // create computer with default (plain) mouse and keyboard
            Computer computer = new Computer();

            // mouse and keyboard operations
            // should result in console messages mentioning
            // the plain mouse and plain keyboard
            computer.MoveMouse(20, 50);

            computer.MouseClick();

            computer.ClickKeyboardKey('h');

            // after the keyboard is changed to FancyKeyboard, the keyboard messages should mention the 'Fancy' keyboard.
            computer.Keyboard = new FancyKeyboard();

            computer.ClickKeyboardKey('h');
        }
    }
}