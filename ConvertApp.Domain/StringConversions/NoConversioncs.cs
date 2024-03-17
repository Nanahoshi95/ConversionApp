namespace ConvertApp.Domain.StringConversions
{
    /// <summary>
    /// 変換無しを提供します。
    /// </summary>
    public class NoConversion : IStringConversion
    {
        /// <inheritdoc/>
        public string Name { get; } = string.Empty;

        /// <inheritdoc/>
        public string Convert(string source) => source;
    }
}
