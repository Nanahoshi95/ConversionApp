using ConvertApp.Domain.DataClasses;
using ConvertApp.Domain.Strategies;
using ConvertApp.Domain.StringConversions;
using Microsoft.VisualBasic;

namespace ConvertApp.Domain.Utilities
{
    /// <summary>
    /// 文字列変換のユーティリティを提供します。
    /// </summary>
    public static class StringConversionUtility
    {
        /// <summary>
        /// データソースを取得します。
        /// </summary>
        /// <returns>KeyとValueの一覧を返します。</returns>
        public static IEnumerable<KeyValueItem<IStringConversionStrategy, string>> GetDataSource()
        {
            // 文字列変換機能を生成
            IStringConversion[] stringConversions = new IStringConversion[]
            {
                new NoConversion(),
                new CommaToHalfSpaceConversion(),
                new SpaceFullToHalfConversion(),
                new TabToLineBreakConversion(),
                new DataTypeMySQLToPostgreSQLConversion(),
            };

            var result = new List<KeyValueItem<IStringConversionStrategy, string>>();   
            foreach ( var conversion in  stringConversions ) 
            {
                result.Add(new KeyValueItem<IStringConversionStrategy, string>(conversion, conversion.Name));
            }; 

            return result;
        }
    }
}
