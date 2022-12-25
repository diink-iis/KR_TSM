using TSM.Signals;
using System.IO;
using TSM.Audio;
using TSM.Operations;

internal class Program
{
    static void Main(string[] args)
    {
        WaveFile waveContainer;
        using (var stream = new FileStream(@"C:\Users\isaev\NWaves\test.wav", FileMode.Open))
        {
            waveContainer = new WaveFile(stream);
        }
        DiscreteSignal left = waveContainer[Channels.Left];
        DiscreteSignal right = waveContainer[Channels.Right];

        var str = Operation.TimeStretch(left, 1.75, NWaves.Operations.Tsm.TsmAlgorithm.PhaseVocoder);
        var str2 = Operation.TimeStretch(right, 1.75, NWaves.Operations.Tsm.TsmAlgorithm.Wsola);

        var waveFileStereo = new WaveFile(new[] { str, str2 });
        using (var stream = new FileStream(@"C:\Users\isaev\NWaves\test2.wav", FileMode.Create))
        {
            waveFileStereo.SaveTo(stream);
        }
    }
}