namespace ConvertApp.Domain.Strategies
{
    /// <summary>
    /// 文字列変換ロジックのインターフェースを提供します。
    /// </summary>
    public interface IStringConversionStrategy
    {
        /// <summary>
        /// 文字列を変換します。
        /// </summary>
        /// <param name="source">変換元の値を指定します。</param>
        /// <returns>変換後の文字列を指定します。</returns>
        public string Convert(string source);
    }
}
