using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertApp.Domain.StringConversions
{
    /// <summary>
    /// スペースを全角から半角に変換する機能を提供します。
    /// </summary>
    public class SpaceFullToHalfConversion : IStringConversion
    {
        /// <inheritdoc/>
        public string Name => "スペース 全角→半角";

        /// <inheritdoc/>
        public string Convert(string source) => source.Replace('　', ' ');
    }
}
