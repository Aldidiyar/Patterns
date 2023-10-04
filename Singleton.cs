using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Singleton
    {
        private static Singleton single = null;
        protected Singleton()
        {}
        public static Singleton Initialize()
        { 
            if(single == null)
                single = new Singleton();
            return single;
        }
        IStrategy strategy;
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void Strategy()
        { 
            strategy.StrategyMethod();
        }
    }
}
