using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule
{
    public class Entry
    {
        public string Day { get; set; }
        public string Name { get; set; }
        public string Subject { get; internal set; }
        public decimal Begin { get; internal set; }
        public decimal End { get; internal set; }
    }
}
