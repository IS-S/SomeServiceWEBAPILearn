using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeService.Core
{
    
    public class Counter : ICounter
    {
        private readonly IDatabase _database;

        public Counter(IDatabase database)
        {
            _database = database;
        }

        public int GetSomething()
        {
            var value = _database.Get();
            return value;
        }
        public void DoSomething(string Name, int Value)
        {
            _database.Set(Name, Value);
        }
    }
}
