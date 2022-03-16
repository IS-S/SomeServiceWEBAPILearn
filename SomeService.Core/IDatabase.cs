using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeService.Core
{
    public interface IDatabase
    {
        public int Get();
        public void Set(string Name, int Value);
    }
}
