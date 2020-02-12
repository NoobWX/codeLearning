using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCashManager
{
    class ContextCash
    {
        StrategyCash strategyCash = null;
        public ContextCash(StrategyCash strategyCash)
        {
            this.strategyCash = strategyCash;
        }
        public double ContextCashInterface(double money)
        {
            return strategyCash.GetResult(money);
        }
    }
}
