using System;

namespace Pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton single1 = Singleton.Initialize();
            Singleton single2 = Singleton.Initialize();
            Console.WriteLine("single1: " + single1.GetHashCode() + " single2: " + single2.GetHashCode());
            single1.SetStrategy(new StrategyOne());
            single1.Strategy();
            single1.SetStrategy(new StrategyTwo());
            single1.Strategy();
        }
    }
}
