using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertApp.Domain.StringConversions
{
    /// <summary>
    /// データ型をMySQLのものからPostgreSQLのものに変換します。
    /// </summary>
    public class DataTypeMySQLToPostgreSQLConversion : IStringConversion
    {
        /// <inheritdoc/>
        public string Name => "データ型 MySQL→PostgreSQL";

        /// <inheritdoc/>
        public string Convert(string source)
        {
            source = source.Replace("text", "varchar");
            source = source.Replace("timestamptz", "timestamp");

            const string Float = "float";
            source = source.Replace("double precision", Float);
            source = source.Replace("real", Float);

            return source;
        }
    }
}
