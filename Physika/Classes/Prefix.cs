using ODModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physika.Classes {
    public struct Prefix {
        public string Name = "";
        public string Symbol = "";
        public int Order = 0;
        public NumericTextbox.MetricPrefix Linked = NumericTextbox.MetricPrefix.None;
        public Prefix(string name, string symbol, int order, NumericTextbox.MetricPrefix linked) {
            Name = name;
            Symbol = symbol;
            Order = order;
            Linked = linked;
        }
    }
}
