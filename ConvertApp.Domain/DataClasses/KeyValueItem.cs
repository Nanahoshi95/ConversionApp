using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertApp.Domain.DataClasses
{
    /// <summary>
    /// KeyとValueの組み合わせを提供します。
    /// </summary>
    public class KeyValueItem<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; } 

        public KeyValueItem(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
