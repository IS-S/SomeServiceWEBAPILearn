using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeService.Core
{
    public interface ICounter
    {
        public void DoSomething(string Name, int Value);
        public int GetSomething();
    }
}
