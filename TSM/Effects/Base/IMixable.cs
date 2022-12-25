using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSM.Effects.Base
{
    public interface IMixable
    {
        /// <summary>
        /// Gets or sets wet gain.
        /// </summary>
        float Wet { get; set; }

        /// <summary>
        /// Gets or sets dry gain.
        /// </summary>
        float Dry { get; set; }
    }
}
