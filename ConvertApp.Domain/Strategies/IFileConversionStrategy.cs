namespace ConvertApp.Domain.Strategies
{
    /// <summary>
    /// ファイル変換ロジックのインターフェースを提供します。
    /// </summary>
    public interface IFileConversionStrategy
    {
        /// <summary>
        /// ファイルを変換します。
        /// </summary>
        /// <param name="filePath">変換元ファイルのパスを指定します。</param>
        public void Convert(string filePath);
    }
}
