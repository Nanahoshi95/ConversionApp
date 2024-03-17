using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertApp.Domain.StringConversions
{
    /// <summary>
    /// タブを改行に変換する機能を提供します。
    /// </summary>
    public class TabToLineBreakConversion : IStringConversion
    {
        /// <inheritdoc/>
        public string Name => "タブ→改行";

        /// <inheritdoc/>
        public string Convert(string source) => source.Replace("\t", "\r\n");
    }
}
