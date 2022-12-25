using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSM.Algorithms
{
    public enum TsmAlgorithm
    {
        /// <summary>
        /// Phase vocoder.
        /// </summary>
        PhaseVocoder = 0,

        /// <summary>
        /// Phase vocoder with phase-locking.
        /// </summary>
        PhaseVocoderPhaseLocking = 1,

        /// <summary>
        /// Waveform similarity-based Synchrnoized Overlap-Add.
        /// </summary>
        Wsola = 2,

        /// <summary>
        /// Paul stretch.
        /// </summary>
        PaulStretch = 3
    }
}
