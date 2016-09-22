using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class StandardSingleton
    {
        private static StandardSingleton _standardSingletonInstance;

        private StandardSingleton() { }

        public static StandardSingleton GetStandardSingletonInstance() => _standardSingletonInstance ?? (_standardSingletonInstance = new StandardSingleton());

        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
