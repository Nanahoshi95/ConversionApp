using ConvertApp.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertApp.Domain
{
    /// <summary>
    /// 文字列変換機能を提供します。
    /// </summary>
    public interface IStringConversion : IStringConversionStrategy, IConversionName { }
}
