using TSM.Signals;
using System;
using System.IO;
using TSM.Audio;
using TSM.Operations;

namespace TSM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaveFile waveContainer;
            using (var stream = new FileStream(@"C:\Users\isaev\Desktop\Study\3 курс\КР_1_семестр/Чапкин.wav", FileMode.Open))
            {
                waveContainer = new WaveFile(stream);
            }
            DiscreteSignal left = waveContainer[Channels.Left];
            DiscreteSignal right = waveContainer[Channels.Right];

            var str = Operation.TimeStretch(left, 0.5, Algorithms.TsmAlgorithm.Wsola);
            var str2 = Operation.TimeStretch(right, 0.5, Algorithms.TsmAlgorithm.Wsola);

            var waveFileStereo = new WaveFile(new[] { str, str2 });
            using (var stream = new FileStream(@"C:\Users\isaev\Desktop\Study\3 курс\КР_1_семестр/Чапкин2.wav", FileMode.Create))
            {
                waveFileStereo.SaveTo(stream);
            }
        }
    }
}
