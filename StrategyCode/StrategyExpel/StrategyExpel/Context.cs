using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExpel
{
    class Context
    {
        private readonly Strategy strategy;//我也不知道为啥提示我要加个readonly，private和readonly可以不加的，仅仅是代码划线强迫症看着不爽。
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
