using ConvertApp.Domain.Strategies;

namespace ConvertApp.Domain.StringConversions
{
    /// <summary>
    /// カンマを半角スペースに変換する機能を提供します。
    /// </summary>
    public class CommaToHalfSpaceConversion : IStringConversion
    {
        /// <inheritdoc/>
        public string Name { get; } = "カンマ→半角スペース";

        /// <inheritdoc/>
        public string Convert(string source) => source.Replace(',', ' ');
    }
}
