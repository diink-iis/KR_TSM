namespace TSM.Base
{
    public interface IOnlineFilter
    {
        /// <summary>
        /// Processes one sample.
        /// </summary>
        /// <param name="sample">Input sample</param>
        float Process(float sample);

        /// <summary>
        /// Resets filter.
        /// </summary>
        void Reset();
    }
}
