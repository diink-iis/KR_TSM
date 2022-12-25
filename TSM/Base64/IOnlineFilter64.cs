namespace TSM.Base64
{
    public interface IOnlineFilter64
    {
        /// <summary>
        /// Processes one sample.
        /// </summary>
        /// <param name="sample">Input sample</param>
        double Process(double sample);

        /// <summary>
        /// Resets filter.
        /// </summary>
        void Reset();
    }
}
