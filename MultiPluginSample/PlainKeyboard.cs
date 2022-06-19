using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    /// <summary>
    /// PlainKeyboard mentions PlainKeyboard in its console messages
    /// </summary>
    public class PlainKeyboard : IKeyboard
    {
        public void KeyClick(char c)
        {
            Console.WriteLine($"Plain Keyboard clicked '{c}'");
        }
    }
}