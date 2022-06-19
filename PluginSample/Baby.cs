using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSample
{
    public class Baby
    {
        private ISuccable _succablePlugin = null;

        /// <summary>
        /// set the succable plugin
        /// </summary>
        /// <param name="succablePlugin"></param>
        public void SetSuccablePlugin(ISuccable succablePlugin)
        {
            _succablePlugin = succablePlugin;
        }

        /// <summary>
        /// method suck - call the corresponing plugin method
        /// </summary>
        public void Suck()
        {
            _succablePlugin?.Suck();
        }
    }
}